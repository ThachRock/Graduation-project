#include <SoftwareSerial.h>  //https://www.proe.vn/kit-stm32f411-nucleo-nucleo-f411re
#include <CommandHandler.h>  //https://github.com/croningp/Arduino-CommandHandler
#include <AccelStepper.h> // thu vien dieu khien dong co step    
#include <ArduinoJson.h>  //https://arduinojson.org/ // gui tín hiệu đến giao diện và ngược lại
#include <Servo.h>  //thư viện điều khiển servo  

HardwareSerial Serial1(PB_7,PA_15);  //Khai báo cổng Serial 1

AccelStepper  stepperX(AccelStepper::FULL2WIRE, 2, 5); // Chân 2 là PUL- và chân 5 là DIR- // Chân 5v là chân 11
AccelStepper  stepperY(AccelStepper::FULL2WIRE, 12,13);
AccelStepper  stepperZ(1, 3, 6);
AccelStepper  stepperA(1,4,7);

Servo gripperServo;

//Khai báo Công tắc hành trình
#define Enable1 A0
#define Enable2 A3
#define Enable3 A4
#define Enable4 A5
#define limitSwitch1 17
#define limitSwitch2 18
#define limitSwitch3 19
#define limitSwitch4 20

//nút nhấn
#define but1  A1    //green
#define but2  A2    //yellow

String updateData = "";
float data[10];

int stepperXPosition, stepperYPosition, stepperZPosition, stepperAPosition;

int theta1Array[20];
int theta2Array[20];
int theta3Array[20];
int zAxisArray[20];
int gripperArray[20];
int positionsCounter = 0;

CommandHandler sc;

int cc=1,ff=1, manualS, automodeS, rbg=1;
bool  m,n,t,r,v,pt; //flag
int   w,b,l,cv,dem;     //variable cho vòng lặp switch...case
float A[5];    //[0][1][2][3][4] = px, py, pz, angle, ma hang
float th1,th2,th3,Zaxis;   //góc quay sau khi inverse

float X,Y,Z;
float L1 = 200, L2 = 150;
float conv = PI / 180;

//mấy cái biến millis() thay cho lệnh delay(), chạy động cơ step cơ chế ngắt(interrupt) thì dùng millis() hay hơn. 
unsigned long tc,tb,tg,tr,td;

const float des[3][4]={{349.5, 0, 0, 0},      
                       {0,349.5,0, 0},
                       {0,-349.5, 0}};      //thả vật từ home vào vị trí setup
//------------------------------------

void setup() {
  Serial1.begin(9600); // kết nối với python
  Serial.begin(115200); // kết nối với giao diện
  Serial.println("ready");
  
  pinMode(3, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(4, OUTPUT);
  pinMode(7, OUTPUT);
  pinMode(Enable1, OUTPUT);
  pinMode(Enable2, OUTPUT);
  pinMode(Enable3, OUTPUT);
  pinMode(Enable4, OUTPUT);

  digitalWrite(Enable1, LOW);
  digitalWrite(Enable2, LOW);
  digitalWrite(Enable3, LOW);
  digitalWrite(Enable4, LOW);

  pinMode(limitSwitch1, INPUT_PULLUP);
  pinMode(limitSwitch2, INPUT_PULLUP);
  pinMode(limitSwitch3, INPUT_PULLUP);
  pinMode(limitSwitch4, INPUT_PULLUP); 
  gripperServo.attach(11, 600, 2500);

  manualS = 1; v=1;

  data[7] = 145;    //open: 30 - close: 170
  gripperServo.write(data[7]);
  
  pinMode(but1,INPUT_PULLUP);     //button1
  pinMode(but2,INPUT_PULLUP);     //button2
  
  stepperX.setMaxSpeed(10000);
  stepperX.setAcceleration(8000);
  stepperY.setMaxSpeed(10000);
  stepperY.setAcceleration(8000);
  stepperZ.setMaxSpeed(200);
  stepperZ.setAcceleration(500);
  stepperA.setMaxSpeed(200);
  stepperA.setAcceleration(500);


  sc.addCommand("1", Reset);            //auto home
  sc.addCommand("2", Start);            //flag bắt đầu
  sc.addCommand("on", On);              //khởi động robot
  sc.addCommand("off",Off);             //tắt robot
  sc.addCommand("h", setHome);          //về home
  sc.addCommand("r", Ready_Pos);        //về ready position
  sc.addCommand("obj",Obj);             //Nhận data từ python
  sc.addCommand("rsF",resetFlag);       //tín hiệu reset flag từ python
  sc.addCommand("manual",manual_flag);  //chuyển qua chế độ bằng tay  
  sc.setDefaultHandler(unrecognized);   //khi nhận lệnh lạ
}



//------------------------------------
void loop()
{ 
button();
if (manualS == 1) manual();
else if (automodeS == 1) auto_mode();
}
//------------------------------------


//------------------------------------manual mode---------------------------------
void manual()
{
  stepperXPosition = data[1] * 115 * 2;         //115 la ti so truyen, 8 la x xung 
  stepperYPosition = data[2] * 28  * 8;
  stepperZPosition = data[3] * 1.25 ;
  stepperAPosition = data[4] * 10.75;          //Chay yeu la do thieu xung

  stepperX.setMaxSpeed(data[6]);          //set toc do
  stepperY.setMaxSpeed(data[6]);
  stepperZ.setMaxSpeed(data[6]);
  stepperA.setMaxSpeed(data[6]);

  stepperX.moveTo(stepperXPosition);
  stepperY.moveTo(stepperYPosition);
  stepperZ.moveTo(stepperZPosition);
  stepperA.moveTo(stepperAPosition);
  gripperServo.write(data[7]);

  while (stepperX.currentPosition() != stepperXPosition || 
         stepperY.currentPosition() != stepperYPosition || 
         stepperZ.currentPosition() != stepperZPosition || 
         stepperA.currentPosition() != stepperAPosition) 
  {
    stepperX.run();
    stepperY.run();
    stepperZ.run();
    stepperA.run();

    if (stepperX.currentPosition() == stepperXPosition && //khi chạy xong tất cả 4 khớp thì gửi data qua
         stepperY.currentPosition() == stepperYPosition && 
         stepperZ.currentPosition() == stepperZPosition && 
         stepperA.currentPosition() == stepperAPosition)
    {
    Serial.println("{\"d1\":\"" + String(1) + "\"," + "\"dx\":\"" + String(A[0]) + "\"," + "\"dy\":\"" + String(A[1]) + "\"," + "\"dz\":\"" + String(A[2]) + "\"," + "\"da\":\"" + String(A[3]) +"\"," +"\"dc\":\"" + String(A[4]) + "\"}");  //done !!
    }   
  }
  
  
  if (Serial.available())
  {
    StaticJsonDocument<500> doc;

    DeserializationError err = deserializeJson(doc, Serial);
    
    if (err == DeserializationError::Ok)
    {
      if (data[1] == doc["d1"].as<int>() &&                                                             
          data[2] == doc["d2"].as<int>() &&                                                          
          data[3] == doc["d3"].as<int>() &&                                                          
          data[4] == doc["d4"].as<int>() &&  
          data[5] == doc["d5"].as<int>() &&                                                            
          data[6] == doc["d6"].as<int>() &&      
          data[7] == doc["d7"].as<int>())
         
        { Serial.println("{\"d1\":\"" + String(2) + "\"," + "\"dx\":\"" + String(A[0]) + "\"," + "\"dy\":\"" + String(A[1]) + "\"," + "\"dz\":\"" + String(A[2]) + "\"," + "\"da\":\"" + String(A[3]) +"\"," +"\"dc\":\"" + String(A[4]) + "\"}"); }
   
      data[1] = doc["d1"].as<int>(); //theta1                                                             
      data[2] = doc["d2"].as<int>(); //theta2                                                             
      data[3] = doc["d3"].as<int>(); //theta3                                                             
      data[4] = doc["d4"].as<int>(); //Z-axis                                                             
      data[5] = doc["d5"].as<int>(); //autohome, sethome, record, play
      data[6] = doc["d6"].as<int>(); //speed        
      data[7] = doc["d7"].as<int>(); //grip                                                                                                                                                             
    }
      updateData = "{\"d1\":\"" + String(data[1]) + "\"," + 
                    "\"d2\":\"" + String(data[2]) + "\"," + 
                    "\"d3\":\"" + String(data[3]) + "\"," + 
                    "\"d4\":\"" + String(data[4]) + "\"," + 
                    "\"d5\":\"" + String(data[5]) + "\"," + 
                    "\"d6\":\"" + String(data[6]) + "\"," + 
                    "\"d7\":\"" + String(data[7]) + "\"}"; 




//d5 !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1
  if (data[5] != 10000 && (data[5] != 3))    //???
  {
    Serial.println(updateData);   //SENDATA BACK
  }

  if (data[5] <= 7 && data[5] >= 0)
  {
////////////////////////////////////SAVE BUTTON/////////////////////////
    if (data[5] == 1) 
    {
      theta1Array[positionsCounter] = data[1] * 115 * 2;;    
      theta2Array[positionsCounter] = data[2] * 28  * 8;
      theta3Array[positionsCounter] = data[3] * 1.25;
      zAxisArray[positionsCounter]  = data[4] * 10.75;
      gripperArray[positionsCounter] = data[7];
      positionsCounter++; 
    }
/////////////////////////////////////////////////////////////////////////////

      
////////////////////////////////////CLEAR SAVED BUTTON/////////////////////////
    if (data[5] == 2) 
    {
      memset(theta1Array, 0, sizeof(theta1Array));
      memset(theta2Array, 0, sizeof(theta2Array));
      memset(theta3Array, 0, sizeof(theta3Array));
      memset(zAxisArray, 0, sizeof(zAxisArray));
      memset(gripperArray, 0, sizeof(gripperArray));
      positionsCounter = 0;
    }
//////////////////////////////////////////////////////////////////////////////////////


///////////////////////////////////// RUN program/////////////////////////////////////
    while (data[5] == 3)
    {
      stepperX.setMaxSpeed(data[6]);
      stepperY.setMaxSpeed(data[6]);
      stepperZ.setMaxSpeed(data[6]);
      stepperA.setMaxSpeed(data[6]);
        
      for (int i = 0; i <= (positionsCounter - 1); i++) 
      {
        if (data[5] == 0)
        {
          break;
        }
        
        stepperX.moveTo(theta1Array[i]);
        stepperY.moveTo(theta2Array[i]);
        stepperZ.moveTo(theta3Array[i]);
        stepperA.moveTo(zAxisArray[i]);
        gripperArray[i]=gripperServo.read();

      while (stepperX.currentPosition() != theta1Array[i] || 
              stepperY.currentPosition() != theta2Array[i] || 
              stepperZ.currentPosition() != theta3Array[i] || 
              stepperA.currentPosition() !=  zAxisArray[i]) 
      {
        stepperX.run();
        stepperY.run();
        stepperZ.run();
        stepperA.run();
        if (Serial.available())
        {
          StaticJsonDocument<500> doc;

          DeserializationError err = deserializeJson(doc, Serial);
          
          if (err == DeserializationError::Ok)
          {
            data[1] = doc["d1"].as<int>(); //theta1                                                             
            data[2] = doc["d2"].as<int>(); //theta2                                                             
            data[3] = doc["d3"].as<int>(); //theta3                                                             
            data[4] = doc["d4"].as<int>(); //Z-axis                                                             
            data[5] = doc["d5"].as<int>(); //autohome, sethome, record, play
            data[6] = doc["d6"].as<int>(); //speed        
            data[7] = doc["d7"].as<int>(); //grip                                                                                                                                                             
          }
              if (data[5] == 0) {break;}      
          } 
        stepperX.setMaxSpeed(data[6]);
        stepperY.setMaxSpeed(data[6]);
        stepperZ.setMaxSpeed(data[6]);
        stepperA.setMaxSpeed(data[6]);
      }
      gripperServo.write(gripperArray[i]);

      if (Serial.available())
      {
        StaticJsonDocument<500> doc;

        DeserializationError err = deserializeJson(doc, Serial);
        
        if (err == DeserializationError::Ok)
        {
          data[1] = doc["d1"].as<int>(); //theta1                                                             
          data[2] = doc["d2"].as<int>(); //theta2                                                             
          data[3] = doc["d3"].as<int>(); //theta3                                                             
          data[4] = doc["d4"].as<int>(); //Z-axis                                                             
          data[5] = doc["d5"].as<int>(); //autohome, sethome, record, play
          data[6] = doc["d6"].as<int>(); //speed        
          data[7] = doc["d7"].as<int>(); //grip                                                                                                                                                             
        }
            if (data[5] == 0) {break;}      
        } 
      }
    }



/////////////////////////////////HOMING//////////////////////////////
    if (data[5] == 6) 
    {
      data[5] = 0; 
    }
/////////////////////////////////////////////////////////////////////


/////////////////////////////////SET HOME//////////////////////////////
    if (data[5] == 7)                                             //                       
    {                                                             //        
      data[1] = 0; //theta1                                   //                                
      data[2] = 0; //theta2                                   //                                 
      data[3] = 0; //theta3                                   //                                 
      data[4] = 0; //Z-axis                                   //                                 
      stepperX.setCurrentPosition(0);                         //                                           
      stepperY.setCurrentPosition(0);                         //                                           
      stepperZ.setCurrentPosition(0);                         //                                           
      stepperA.setCurrentPosition(0);                         //                                           
      data[5] = 0;                                            //                        
    }
/////////////////////////////////////////////////////////////////////
}


    else if (data[5] == 10000)
    {
      stepperX.setMaxSpeed(data[6]*5);
      stepperY.setMaxSpeed(data[6]*5);
      stepperZ.setMaxSpeed(data[6]*5);
      stepperA.setMaxSpeed(data[6]*5);
      cc=1;
      A[0]=A[1]=A[2]=A[3]=0;
      automodeS=1;
      manualS=0;
      data[5] = 0;
    }
  }
  //Serial.println(updateData);
}
//---------------------------------------
  

//--------------------AUTO MODE-------------------
void auto_mode()
{
  if (cc==1)      // chạy 1 lần đầu tiên 
  { 
    Start();
    cc=0;
  }
  
  sc.processSerial(Serial1);  //Serial
  sc.processSerial(Serial);  //Serial

  stepperX.run();        //chạy đến toạ độ (thực ra thì đến vòng lặp thứ 2 mới chạy)
  stepperY.run();        
  stepperZ.run();
  stepperA.run();
  
  /*/ khi n=1  >> chạy th 4,5 trước 
               >> [export_th()] chạy từ case 2 
               >> loop case (đợi vòng lặp thứ 2 mới chạy) 
               >> tạp flag cho [wait()] 
               >> n=0 flag cho wait() /*/
  Homegd();
  Check_pos();    

  //Khi t=1,n=0 >> [export_th()] loop (chạy chu trình gắp thả vật)   Chạy xong case1 là t=1
  wait();           

  /*/ khi r=1  >> export_all_xung() 
      >> chuẩn bị xung, góc chạy cho 5 th 
      >> tạo flag cho [Check_pos()] (n=1), r=0 /*/
  export_xung();
  Homept();
}
//------------------------------------------------
void Homegd()
{
  if (Serial.available())
  {
    StaticJsonDocument<500> doc;

    DeserializationError err = deserializeJson(doc, Serial);
    
    if (err == DeserializationError::Ok)
    {
      if (data[1] == doc["d1"].as<int>() &&                                                             
          data[2] == doc["d2"].as<int>() &&                                                          
          data[3] == doc["d3"].as<int>() &&                                                          
          data[4] == doc["d4"].as<int>() &&  
          data[5] == doc["d5"].as<int>() &&                                                            
          data[6] == doc["d6"].as<int>() &&      
          data[7] == doc["d7"].as<int>())
         
        { Serial.println("{\"d1\":\"" + String(2) + "\"," + "\"dx\":\"" + String(A[0]) + "\"," + "\"dy\":\"" + String(A[1]) + "\"," + "\"dz\":\"" + String(A[2]) + "\"," + "\"da\":\"" + String(A[3]) +"\"," +"\"dc\":\"" + String(A[4]) + "\"}"); }
   
      data[1] = doc["d1"].as<int>(); //theta1                                                             
      data[2] = doc["d2"].as<int>(); //theta2                                                             
      data[3] = doc["d3"].as<int>(); //theta3                                                             
      data[4] = doc["d4"].as<int>(); //Z-axis                                                             
      data[5] = doc["d5"].as<int>(); //autohome, sethome, record, play
      data[6] = doc["d6"].as<int>(); //speed        
      data[7] = doc["d7"].as<int>(); //grip                                                                                                                                                             
    }
      updateData = "{\"d1\":\"" + String(data[1]) + "\"," + 
                    "\"d2\":\"" + String(data[2]) + "\"," + 
                    "\"d3\":\"" + String(data[3]) + "\"," + 
                    "\"d4\":\"" + String(data[4]) + "\"," + 
                    "\"d5\":\"" + String(data[5]) + "\"," + 
                    "\"d6\":\"" + String(data[6]) + "\"," + 
                    "\"d7\":\"" + String(data[7]) + "\"}"; 
      if(data[5] == 8 && v==1)
      {
          l = 1;
          Serial1.print("1");
          set3Home();
          export_all_xung();
          Start1();
      }
      else if(data[5] == 9 && v==1)
      {
          l = 2;
          Serial1.print("2");
          set3Home();
          export_all_xung();
          Start2();
      }
      else if(data[5] == 10 && v==1)
      {
        goHome();
        export_all_xung();
      }   
      else if(data[5] == 12)
      {
        v = 1;
      }
      else if(data[5] == 11)
      {
        v = 0;
      }

  }
}
void Cho()
{
  if((millis()- td >= 5000))
  v=0;
}
void Homept()
{
  if(v == 0 && (millis()- tr >= 5000))
  {
    if(cv == 0)
    {
      l++;
      {
        if(l == 1)
        {
          Serial1.print("1");
          set3Home();
          export_all_xung();
          
        }
        else if(l == 2)
        {
          Serial1.print("2");
          set3Home();
          export_all_xung();
        }
        else if(l == 3)
        {
          dem++;
          {
            Serial1.print("1");
            l=1;
            set3Home();
            export_all_xung();
          }
          
        }
      }
    }
    
  }
}
void set3Home()
{
  if(l == 1)
  {
    th1 = 45; //th1
    th2 = -45; //th2
    th3 = 0; //th3
    Zaxis = 0;
  }
  else if(l == 2)
  {
    th1 = -45; //th1
    th2 = 45; //th2
    th3 = 0; //th3
    Zaxis = 0;
  }
  Serial1.println("s1");
}

void Start()
{
  m=1;
  b=1; 
  Serial1.println("s1");
}
void Start1()
{
  m=1;
  b=1; 
  Serial1.println("1s1");
}
void Start2()
{
  m=1;
  b=1; 
  Serial1.println("2s1");
}

//------------------------------------

void Obj()
{
  if(m&&b==1)
  {
    cv = 1;
    update_Data();
    tb=millis();
    w=0;
    export_th();
  }
}


//-----------------------------------

void update_Data()
{
  //Serial1.println("nhận data từ python");
  char *arg;
  
  for(int i=0;i<5;i++)
  {
    arg = sc.next();
    if(arg == NULL) 
      break;
    A[i] = atof(arg); 
    //Serial1.print(A[i]);1
    //Serial1.print("\t");
  }
  int c=A[4];              //c là mã hàng, 0 cho red, 1 cho green, 2 cho blue
  c=constrain(c,1,2);      //c= 1, 2 
                    
    if (c==1)       {  Serial.println("{\"d1\":\"" + String("kho1") + "\"," + "\"dx\":\"" + String(A[0]) + "\"," + "\"dy\":\"" + String(A[1]) + "\"," + "\"dz\":\"" + String(A[2]) + "\"," + "\"da\":\"" + String(A[3]) +"\"," +"\"dc\":\"" + String(A[4]) + "\"}"); }   
    else if (c==2)  {  Serial.println("{\"d1\":\"" + String("kho2") + "\"," + "\"dx\":\"" + String(A[0]) + "\"," + "\"dy\":\"" + String(A[1]) + "\"," + "\"dz\":\"" + String(A[2]) + "\"," + "\"da\":\"" + String(A[3]) +"\"," +"\"dc\":\"" + String(A[4]) + "\"}"); }
}

//---------------------------------------
void export_th() 
{
  int c=A[4];              //c là mã hàng, 0 cho red, 1 cho green, 2 cho blue
  c=constrain(c,1,2);
  l=constrain(l,0,2);
  w++;                      //sau mỗi vòng loop thì w=w+1                
  switch (w) 
  {
    case 1: Invert(A[0],A[1],A[2],A[3]);  //(z high, go to)
            open_gripper();t=1;
            Serial.println("{\"d1\":\"" + String(3) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;         //mở miệng gripper, t=1 flag cho [export_xung()] chạy
    case 2: Invert(A[0],A[1],A[2]+1,A[3]);         //hạ trục z (z low)
            export_all_xung();
            Serial.println("{\"d1\":\"" + String(4) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;
    case 3: Invert(A[0],A[1],A[2]+190,A[3]);         //hạ trục z (z low)
            export_all_xung();
            Serial.println("{\"d1\":\"" + String(4) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;             //chạy stepper, chạy 2 servo 1,2
                      
    case 4: Invert(A[0],A[1],A[2],A[3]);     //close grip sau đó z high
            close_gripper(); 
            Serial.println("{\"d1\":\"" + String(5) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}"); 
            break;            
          
    case 5: Invert(des[c][0], des[c][1], des[c][2], des[c][3]);   //go to kho setup, z high, 
            export_all_xung();
            Serial.println("{\"d1\":\"" + String(6) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;                                         
                       
    case 6: Invert(des[c][0], des[c][1], des[c][2]+190, des[c][3]);     //go to kho setup, z low,   
            export_all_xung();
            Serial.println("{\"d1\":\"" + String(7) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;                                        
                                                                         
    case 7: Invert(des[c][0], des[c][1], des[c][2], des[c][3]); //open grip, sau do z high
            open_gripper();   
            Serial.println("{\"d1\":\"" + String(8) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;                               //mở miệng gripper
    case 8: w=0;
            if(cv == 1){
              {
                if(l == 1)
                {
                  Serial1.print("1");
                  set3Home();
                  export_all_xung();
                }
                else if(l == 2)
                {
                  Serial1.print("2");
                  set3Home();
                  export_all_xung();
                }
              }
                cv = 0;
            }
            Serial.println("{\"d1\":\"" + String(9) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
            break;                                                   
                                                    
   default: break;
  }
}
//---------------------------------------


//---------------------------------------
void Invert(float X, float Y, float Z, float Or)
{
                th2 = acos((X * X + Y * Y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
                if (X < 0 && Y < 0)
                {
                    th2 = (-1) * th2;
                }

                th1 = atan(X / Y) - atan( (L2 * sin(th2) ) / ( L1 + L2 * cos(th2) ) );

                Zaxis = Z;

                th2 = (-1) * th2 / conv;
                th1 = th1 / conv;

                // Angles adjustment depending in which quadrant the final tool coordinate x,y is
                if (X >= 0 && Y >= 0)
                {       // 1st quadrant
                    th1 = 90 - th1;
                }
                if (X < 0 && Y > 0)
                {       // 2nd quadrant
                    th1 = 90 - th1;
                }
                if (X < 0 && Y < 0)
                {       // 3d quadrant
                    th1 = 270 - th1;
                }
                if (X > 0 && Y < 0)
                {       // 4th quadrant
                    th1 = -90 - th1;
                }
                if (X < 0 && Y == 0)
                {
                    th1 = 270 + th1;
                }
                if (X == 0 && Y < 0)
                {
                    th1 = -90 - th1;
                }



                th3 = 90 + th1 + th2;
                th3 = (-1)*th3;

                th3=th3+Or;

                if (abs(th3) > 120) 
                {
                  th3 = 180 + th3;
                } 
        

                th1 = round(th1);
                th2 = round(th2);
                th3 = round(th3);
                Zaxis = round(Zaxis);
}
//---------------------------------------

//Chạy 3 stepper, 2 servo 1,2
void export_all_xung()
{
  data[1] = round(th1 * 115 * 2);
  data[2] = round(th2 * 28  * 8); 
  data[3] = round(th3 * 1.25);
  data[4] = round(Zaxis * 10.75);  

  
  stepperX.moveTo(data[1]);
  stepperY.moveTo(data[2]);
  stepperZ.moveTo(data[3]);    
  stepperA.moveTo(data[4]);
  n=1;                  //flag để [Check_pos()]
}
//---------------------------------------

//---------------------------------------
void wait()
{
  if( t   &&  (n==0)  &&  (millis()- tb >= 500) )  //delay(2000)
  {
    t=0;    //flag cho [wait()]
    export_th();
  }
}
//---------------------------------------


//---------------------------------------
void open_gripper()           //mở miệng gripper
{ 
  gripperServo.write(30); //mở gripper
  r=1;              //flag cho [export_xung()] chạy
  tg=millis();      //thời gian chương trình bắt đầu chạy
}

void close_gripper()           //ngậm miệng gripper
{
  gripperServo.write(140); //đóng gripper
  r=1;              //flag cho [export_xung()] chạy
  tg=millis();      //thời gian chương trình bắt đầu chạy
}
//---------------------------------------

//----------------------------------------
void export_xung()                           
{
  if( r && ( (millis()-tg) >= 500 ))  //delay(180)
  {
    r=0;                              //flag cho [export_xung()] ko chạy nữa
    export_all_xung();                //xác định xung, góc cho 5 th
  }
}
//----------------------------------------

//----------------------------------------
void Check_pos()                   //chạy servo 1, 2
{
  if(n && (millis()-tc>=100) )      //delay(15)
  {
    tc=millis();
    tr=millis();
    td=millis();

    if( (stepperX.distanceToGo()==0) && (stepperY.distanceToGo()==0) && 
        (stepperZ.distanceToGo()==0) && (stepperA.distanceToGo()==0) )
      {
        n=0;                              //flag cho [Check_pos()] dừng, (dừng servo 1, 2)
        if( (w!=0) && (w!=1) )            //khi ở case 2, 3, 4, 5, 6, 7
            export_th();                   // >> loop gắp thả vật
      }
  } 
}
//----------------------------------------
void goHome()
{
  th1 = 0; //th1
  th2 = 0; //th2
  th3 = 0; //th3
  Zaxis = 0;
}
void goHome1()
{
  th1 = 45; //th1
  th2 = -45; //th2
  th3 = 0; //th3
  Zaxis = 0;
}
void goHome2()
{
  th1 = -45; //th1
  th2 = 45; //th2
  th3 = 0; //th3
  Zaxis = 0;
}

//----------------------------------------
void setHome()
{
  if(m)
  { 
    w=0; t=0;              //flag cho [Wait()] không chạy
    th1 = 0; //th1
    th2 = 0; //th2
    th3 = 0; //th3
    Zaxis = 0;
    open_gripper();                  //ngậm miệng gripper
    cc=1;
  }
}
//----------------------------------------

//----------------------------------------
void Ready_Pos()
{ 
  if (ff==1)
  { 
    ff=0;
  }

  if(m)
  {
    open_gripper();                  //ngậm miệng gripper
    Serial.println("{\"d1\":\"" + String(11) + "\"," + "\"dx\":\"" + String(0) + "\"," + "\"dy\":\"" + String(0) + "\"," + "\"dz\":\"" + String(0) + "\"," + "\"da\":\"" + String(0) +"\"," +"\"dc\":\"" + String(0) + "\"}");
  }
}
//----------------------------------------


//----------------------------------------
void Stop()
{
  b=2;
  Serial1.println("s0");  
  setHome();              //về bị trí 0
}

//----------------------------------------


//----------------------------------------
// CHUYỆN của những cái nút

void button()
{
  if(digitalRead(but2)==0)
  {
    cc=1;
    manualS=1;
    automodeS=0;
  }
  else if(digitalRead(but1)==0) 
  {
    automodeS=1;
    manualS=0;
  }
}

void Reset()
{
  b=3;
  Serial1.println("s0");  //lệnh dừng
  On();                  //khởi động lại >> [autohome()]
}

void On() 
{
  m=1;                    //flag cho [Th()] chạy
}

void Off()
{
  m=0; n=0;               //flag ko cho [Th()] & [Run_Z5] chạy
}
//----------------------------------------


//----------------------------------------
void unrecognized(const char *command)  //const char *command
{
  Serial1.println(*command);
  Serial1.println("UNknown");
  return;
}

void resetFlag()
{
  ff=1;
  Cho();
}

void manual_flag()
{
  manualS=1;
  automodeS=0;
  A[0]=A[1]=A[2]=A[3]==0;
}
//----------------------------------------


//=========================================== THE END :) ==============================================================//
