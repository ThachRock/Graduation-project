using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using Newtonsoft.Json;
using System.Reflection.Emit;
using System.Windows.Forms.DataVisualization.Charting;


namespace ROBOT_CONTROL_GUI_01
{
    public partial class Form1 : Form
    {
        private int count1 = 0;
        double theta1 = 0, theta2 = 0, theta3 = 0;
        double L1 = 200, L2 = 150;
        double X, Y, Z;
        //string COMRecievedData;
        string data1 = "", data2 = "", data3 = "", data4 = "", data5 = "", data6 = "", data7 = "";
        string data11 = "";
        double conv = Math.PI / 180;
        double home = 0;  //data5
        string d1;
        double dx, dy, dz, da, dc;
        int tt_z = 0;
        int positionsCounter = 0, m;
        int count = 0;
        int kho2counter = 0, kho1counter = 0;  //dem hang
        String[] positions = new String[100];                        //luu vi tri
        //int[] giatri3 = new int[100];

        Color Highlight = Color.FromArgb(0, 120, 215);
        Random rand = new Random();


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbBaurate.SelectedIndex = 0;
            string[] COMPortname = SerialPort.GetPortNames();
            cmbCOMPort.Items.AddRange(COMPortname);
            cmbCOMPort.SelectedIndex = 0;

            count1 = 0;

            groupBox4.Enabled = false;
            groupBox3.Enabled = false;
            groupBox5.Enabled = false;
            tabControl1.Enabled = false;

        }



        private void m10_1_click(object sender, EventArgs e)
        {
            the1.Text = (Convert.ToDouble(the1.Text) - 5).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }
        private void m1_1_Click(object sender, EventArgs e)
        {
            the1.Text = (Convert.ToDouble(the1.Text) - 1).ToString();
            forward();
            senddata();
        }
        private void p1_1_Click(object sender, EventArgs e)
        {
            the1.Text = (Convert.ToDouble(the1.Text) + 1).ToString();
            forward();
            senddata();
        }
        private void p10_1_Click(object sender, EventArgs e)
        {
            the1.Text = (Convert.ToDouble(the1.Text) + 5).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }

        private void m10_2_Click(object sender, EventArgs e)
        {
            the2.Text = (Convert.ToDouble(the2.Text) - 5).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }
        private void m1_2_Click(object sender, EventArgs e)
        {
            the2.Text = (Convert.ToDouble(the2.Text) - 1).ToString();
            forward();
            forward();
            senddata();
        }
        private void p1_2_Click(object sender, EventArgs e)
        {
            the2.Text = (Convert.ToDouble(the2.Text) + 1).ToString();
            forward();
            senddata();
        }
        private void p10_2_Click(object sender, EventArgs e)
        {
            the2.Text = (Convert.ToDouble(the2.Text) + 5).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }

        private void m10_3_Click(object sender, EventArgs e)
        {
            the3.Text = (Convert.ToDouble(the3.Text) - 5).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }
        private void m1_3_Click(object sender, EventArgs e)
        {
            the3.Text = (Convert.ToDouble(the3.Text) - 1).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }
        private void p1_3_Click(object sender, EventArgs e)
        {
            the3.Text = (Convert.ToDouble(the3.Text) + 1).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }
        private void p10_3_Click(object sender, EventArgs e)
        {
            the3.Text = (Convert.ToDouble(the3.Text) + 5).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }


        private void px_Click(object sender, EventArgs e)
        {
            tt_z = 0;
            value_x.Text = (Convert.ToDouble(value_x.Text) + Convert.ToDouble(p.Text)).ToString();
            inverse();
        }
        private void mx_Click(object sender, EventArgs e)
        {
            tt_z = 0;
            value_x.Text = (Convert.ToDouble(value_x.Text) - Convert.ToDouble(p.Text)).ToString();
            inverse();
        }
        private void py_Click(object sender, EventArgs e)
        {
            tt_z = 0;
            value_y.Text = (Convert.ToDouble(value_y.Text) + Convert.ToDouble(p.Text)).ToString();
            inverse();
        }
        private void my_Click(object sender, EventArgs e)
        {
            tt_z = 0;
            value_y.Text = (Convert.ToDouble(value_y.Text) - Convert.ToDouble(p.Text)).ToString();
            inverse();
        }
        private void pz_Click(object sender, EventArgs e)
        {
            tt_z = 1;
            value_z.Text = (Convert.ToDouble(value_z.Text) + Convert.ToDouble(p.Text)).ToString();
            inverse();
        }
        private void mz_Click(object sender, EventArgs e)
        {
            tt_z = 1;
            value_z.Text = (Convert.ToDouble(value_z.Text) - Convert.ToDouble(p.Text)).ToString();
            inverse();
        }

        private void j1slider_Scroll(object sender, EventArgs e)
        {
            the1.Text = j1slider.Value.ToString();
            forward();
        }
        private void j2slider_Scroll(object sender, EventArgs e)
        {
            the2.Text = j2slider.Value.ToString();
            forward();
        }
        private void j3slider_Scroll(object sender, EventArgs e)
        {
            the3.Text = j3slider.Value.ToString();
            forward();
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wanna go home with me?", "Robot GUI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                home = 6;
                forward();
                senddata();
                sendDataStr.Text = "[ Homing... ]";
                home = 0;
            }

            if (result == System.Windows.Forms.DialogResult.Cancel)
                { };
        }


        private void resetF_Click(object sender, EventArgs e)
        {
            the1.Text = "0";
            the2.Text = "0";
            the3.Text = "0";
            value_z.Text = "0";
            forward();
            sendDataStr.Text = "Reset all !";
        }

        private void z_pos_Click(object sender, EventArgs e)
        {
            home = 7;
            forward();
            senddata();
            sendDataStr.Text = "Set home done!";
            home = 0;
            the1.Text = "0";
            the2.Text = "0";
            the3.Text = "0";
            value_z.Text = "0";
            forward();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Robot GUI", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (result == System.Windows.Forms.DialogResult.OK)
                Application.Exit();
            if (result == System.Windows.Forms.DialogResult.Cancel)
                { };
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.BackColor = Highlight;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void pz_MouseMove(object sender, MouseEventArgs e)
        {
            pz.ForeColor = Color.DeepPink;
            pz.BackColor = Highlight;
            value_z.ForeColor = Highlight;
            value_z.Font = new Font(value_z.Font.FontFamily, value_z.Font.Size, FontStyle.Bold);
        }
        private void pz_MouseLeave(object sender, EventArgs e)
        {
            pz.ForeColor = Highlight;
            pz.BackColor = Color.WhiteSmoke;
            value_z.ForeColor = Color.Black;
            value_z.Font = new Font(value_z.Font.FontFamily, value_z.Font.Size, FontStyle.Regular);
        }
        private void mz_MouseMove(object sender, MouseEventArgs e)
        {
            mz.ForeColor = Color.DeepPink;
            mz.BackColor = Highlight;
            value_z.ForeColor = Highlight;
            value_z.Font = new Font(value_z.Font.FontFamily, value_z.Font.Size, FontStyle.Regular);
        }
        private void mz_MouseLeave(object sender, EventArgs e)
        {
            mz.ForeColor = Highlight;
            mz.BackColor = Color.WhiteSmoke;
            value_z.ForeColor = Color.Black;
            value_z.Font = new Font(the1.Font.FontFamily, value_z.Font.Size, FontStyle.Regular);
        }
        private void mx_MouseMove(object sender, MouseEventArgs e)
        {
            mx.ForeColor = Color.DeepPink;
            mx.BackColor = Highlight;
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(value_x.Font.FontFamily, value_x.Font.Size, FontStyle.Bold);
        }
        private void mx_MouseLeave(object sender, EventArgs e)
        {
            mx.ForeColor = Highlight;
            mx.BackColor = Color.WhiteSmoke;
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(value_x.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
        }
        private void px_MouseMove(object sender, MouseEventArgs e)
        {
            px.ForeColor = Color.DeepPink;
            px.BackColor = Highlight;
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Bold);
        }
        private void px_MouseLeave(object sender, EventArgs e)
        {
            px.ForeColor = Highlight;
            px.BackColor = Color.WhiteSmoke;
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
        }
        private void py_MouseMove(object sender, MouseEventArgs e)
        {
            py.ForeColor = Color.DeepPink;
            py.BackColor = Highlight;
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void py_MouseLeave(object sender, EventArgs e)
        {
            py.ForeColor = Highlight;
            py.BackColor = Color.WhiteSmoke;
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void my_MouseMove(object sender, MouseEventArgs e)
        {
            my.ForeColor = Color.DeepPink;
            my.BackColor = Highlight;
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void my_MouseLeave(object sender, EventArgs e)
        {
            my.ForeColor = Highlight;
            my.BackColor = Color.WhiteSmoke;
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }

        private void RUNN_btn_MouseMove(object sender, MouseEventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
        }
        private void RUNN_btn_MouseLeave(object sender, EventArgs e)
        {
            timer1.Stop();
            RUNN_btn.ForeColor = Color.Transparent;
            RUNN_btn.BackColor = Highlight;
        }
        private void send_btn_MouseMove(object sender, MouseEventArgs e)
        {
            timer2.Start();
            timer2.Enabled = true;
        }
        private void send_btn_MouseLeave(object sender, EventArgs e)
        {
            timer2.Stop();
            send_btn.ForeColor = Color.LavenderBlush;
            send_btn.BackColor = Highlight;
        }

        private void j1slider_MouseMove(object sender, MouseEventArgs e)
        {
            the1.ForeColor = Highlight;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void j1slider_MouseLeave(object sender, EventArgs e)
        {
            the1.ForeColor = Color.Black;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void j2slider_MouseMove(object sender, MouseEventArgs e)
        {
            the2.ForeColor = Highlight;
            the2.Font = new Font(the1.Font.FontFamily, the2.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void j2slider_MouseLeave(object sender, EventArgs e)
        {
            the2.ForeColor = Color.Black;
            the2.Font = new Font(the1.Font.FontFamily, the2.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void j3slider_MouseMove(object sender, MouseEventArgs e)
        {
            the3.ForeColor = Highlight;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Bold);
        }
        private void j3slider_MouseLeave(object sender, EventArgs e)
        {
            the3.ForeColor = Color.Black;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Regular);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            send_btn.BackColor = Color.FromArgb(rand.Next(125, 255), rand.Next(125, 255), rand.Next(125, 255), rand.Next(125, 255));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnCon.ForeColor == Color.Black && btnCon.Enabled == true)
            {
                btnCon.BackColor = Color.FromArgb(rand.Next(125, 255), rand.Next(125, 255), rand.Next(125, 255), rand.Next(125, 255));
            }

            else if (btnCon.Enabled == false)
            {
                RUNN_btn.BackColor = Color.FromArgb(rand.Next(125, 255), rand.Next(125, 255), rand.Next(125, 255), rand.Next(125, 255));
            }
        }

        private void j1slider_MouseDown(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void j1slider_MouseUp(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void j2slider_MouseDown(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void j2slider_MouseUp(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void j3slider_MouseDown(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void j3slider_MouseUp(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
        }

        private void pz_MouseDown(object sender, MouseEventArgs e)
        {
            value_z.Font = new Font(value_z.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void pz_MouseUp(object sender, MouseEventArgs e)
        {
            value_z.Font = new Font(value_z.Font.FontFamily, 8, FontStyle.Bold);
        }
        private void mz_MouseDown(object sender, MouseEventArgs e)
        {
            value_z.Font = new Font(value_z.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void mz_MouseUp(object sender, MouseEventArgs e)
        {
            value_z.Font = new Font(value_z.Font.FontFamily, 8, FontStyle.Bold);
        }
        private void mx_MouseDown(object sender, MouseEventArgs e)
        {
            value_x.Font = new Font(value_z.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void mx_MouseUp(object sender, MouseEventArgs e)
        {
            value_x.Font = new Font(value_z.Font.FontFamily, 8, FontStyle.Bold);
        }
        private void px_MouseDown(object sender, MouseEventArgs e)
        {
            value_x.Font = new Font(value_z.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void px_MouseUp(object sender, MouseEventArgs e)
        {
            value_x.Font = new Font(value_z.Font.FontFamily, 8, FontStyle.Bold);
        }
        private void py_MouseDown(object sender, MouseEventArgs e)
        {
            value_y.Font = new Font(value_z.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void py_MouseUp(object sender, MouseEventArgs e)
        {
            value_y.Font = new Font(value_z.Font.FontFamily, 8, FontStyle.Bold);
        }
        private void my_MouseDown(object sender, MouseEventArgs e)
        {
            value_y.Font = new Font(value_z.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void my_MouseUp(object sender, MouseEventArgs e)
        {
            value_y.Font = new Font(value_z.Font.FontFamily, 8, FontStyle.Bold);
        }

        private void send_btn_MouseDown(object sender, MouseEventArgs e)
        {
            send_btn.Font = new Font(send_btn.Font.FontFamily, 12, FontStyle.Bold);
            send_btn.ForeColor = Color.Black;
        }
        private void send_btn_MouseUp(object sender, MouseEventArgs e)
        {
            send_btn.Font = new Font(send_btn.Font.FontFamily, 9, FontStyle.Regular);
            send_btn.ForeColor = Color.Transparent;
        }

        private void RUNN_btn_MouseDown(object sender, MouseEventArgs e)
        {
            RUNN_btn.Font = new Font(RUNN_btn.Font.FontFamily, 12, FontStyle.Bold);
            RUNN_btn.ForeColor = Color.Black;
        }
        private void RUNN_btn_MouseUp(object sender, MouseEventArgs e)
        {
            RUNN_btn.Font = new Font(RUNN_btn.Font.FontFamily, 9, FontStyle.Regular);
            RUNN_btn.ForeColor = Color.Transparent;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data11 = serialPort1.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }
        private void p10_1_MouseMove(object sender, MouseEventArgs e)
        {
            the1.ForeColor = Highlight;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void p10_1_MouseLeave(object sender, EventArgs e)
        {
            the1.ForeColor = Color.Black;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void p10_1_MouseDown(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void p10_1_MouseUp(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void p1_1_MouseMove(object sender, MouseEventArgs e)
        {
            the1.ForeColor = Highlight;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void p1_1_MouseLeave(object sender, EventArgs e)
        {
            the1.ForeColor = Color.Black;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void p1_1_MouseDown(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void p1_1_MouseUp(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void m1_1_MouseMove(object sender, MouseEventArgs e)
        {
            the1.ForeColor = Highlight;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void m1_1_MouseLeave(object sender, EventArgs e)
        {
            the1.ForeColor = Color.Black;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void m1_1_MouseDown(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void m1_1_MouseUp(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void m10_1_MouseMove(object sender, MouseEventArgs e)
        {
            the1.ForeColor = Highlight;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void m10_1_MouseLeave(object sender, EventArgs e)
        {
            the1.ForeColor = Color.Black;
            the1.Font = new Font(the1.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the1.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the1.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void m10_1_MouseDown(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the1.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void m10_1_MouseUp(object sender, MouseEventArgs e)
        {
            the1.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the1.Font.FontFamily, 8, FontStyle.Regular);
        }

        private void p10_2_MouseMove(object sender, MouseEventArgs e)
        {
            the2.ForeColor = Highlight;
            the2.Font = new Font(the2.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void p10_2_MouseLeave(object sender, EventArgs e)
        {
            the2.ForeColor = Color.Black;
            the2.Font = new Font(the2.Font.FontFamily, the2.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the2.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void p10_2_MouseDown(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void p10_2_MouseUp(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void p1_2_MouseMove(object sender, MouseEventArgs e)
        {
            the2.ForeColor = Highlight;
            the2.Font = new Font(the2.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void p1_2_MouseLeave(object sender, EventArgs e)
        {
            the2.ForeColor = Color.Black;
            the2.Font = new Font(the2.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the2.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void p1_2_MouseDown(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void p1_2_MouseUp(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void m1_2_MouseMove(object sender, MouseEventArgs e)
        {
            the2.ForeColor = Highlight;
            the2.Font = new Font(the2.Font.FontFamily, the1.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void m1_2_MouseLeave(object sender, EventArgs e)
        {
            the2.ForeColor = Color.Black;
            the2.Font = new Font(the2.Font.FontFamily, the2.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the2.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void m1_2_MouseDown(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void m1_2_MouseUp(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void m10_2_MouseMove(object sender, MouseEventArgs e)
        {
            the2.ForeColor = Highlight;
            the2.Font = new Font(the2.Font.FontFamily, the2.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void m10_2_MouseLeave(object sender, EventArgs e)
        {
            the2.ForeColor = Color.Black;
            the2.Font = new Font(the2.Font.FontFamily, the2.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the2.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the2.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void m10_2_MouseDown(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the2.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void m10_2_MouseUp(object sender, MouseEventArgs e)
        {
            the2.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the2.Font.FontFamily, 8, FontStyle.Regular);
        }

        private void p10_3_MouseMove(object sender, MouseEventArgs e)
        {
            the3.ForeColor = Highlight;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void p10_3_MouseLeave(object sender, EventArgs e)
        {
            the3.ForeColor = Color.Black;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the3.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void p10_3_MouseDown(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void p10_3_MouseUp(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void p1_3_MouseMove(object sender, MouseEventArgs e)
        {
            the3.ForeColor = Highlight;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void p1_3_MouseLeave(object sender, EventArgs e)
        {
            the3.ForeColor = Color.Black;
            the3.Font = new Font(the3.Font.FontFamily, the1.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the3.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void p1_3_MouseDown(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void p1_3_MouseUp(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
        }

        private void m1_3_MouseMove(object sender, MouseEventArgs e)
        {
            the3.ForeColor = Highlight;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void m1_3_MouseLeave(object sender, EventArgs e)
        {
            the3.ForeColor = Color.Black;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the3.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void m1_3_MouseDown(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void m1_3_MouseUp(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
        }
        private void m10_3_MouseMove(object sender, MouseEventArgs e)
        {
            the3.ForeColor = Highlight;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Bold);
            value_x.ForeColor = Highlight;
            value_x.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
            value_y.ForeColor = Highlight;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Bold);
        }
        private void m10_3_MouseLeave(object sender, EventArgs e)
        {
            the3.ForeColor = Color.Black;
            the3.Font = new Font(the3.Font.FontFamily, the3.Font.Size, FontStyle.Regular);
            value_x.ForeColor = Color.Black;
            value_x.Font = new Font(the3.Font.FontFamily, value_x.Font.Size, FontStyle.Regular);
            value_y.ForeColor = Color.Black;
            value_y.Font = new Font(the3.Font.FontFamily, value_y.Font.Size, FontStyle.Regular);
        }
        private void m10_3_MouseDown(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_x.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
            value_y.Font = new Font(the3.Font.FontFamily, 10, FontStyle.Bold);
        }
        private void m10_3_MouseUp(object sender, MouseEventArgs e)
        {
            the3.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_x.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
            value_y.Font = new Font(the3.Font.FontFamily, 8, FontStyle.Regular);
        }

        private void rst1_Click(object sender, EventArgs e)
        {
            the1.Text = "0";
            forward();
            senddata();
            sendDataStr.Text = "Reset joint 1 !";
        }
        private void rst2_Click(object sender, EventArgs e)
        {
            the2.Text = "0";
            forward();
            senddata();
            sendDataStr.Text = "Reset joint 2 !";
        }
        private void rst3_Click(object sender, EventArgs e)
        {
            the3.Text = "0";
            forward();
            senddata();
            sendDataStr.Text = "Reset joint 3 !";
        }

        private void rec_btn_Click(object sender, EventArgs e)
        {
            positions[positionsCounter] = "J1=" + Math.Round(Convert.ToDouble(the1.Text), 2).ToString()
                                      + "; J2=" + Math.Round(Convert.ToDouble(the2.Text), 2).ToString()
                                      + "; J3=" + Math.Round(Convert.ToDouble(the3.Text), 2).ToString()
                                      + "; Z=" + Math.Round(Convert.ToDouble(value_z.Text), 2).ToString();
            positionsCounter++;
            home = 1;
            forward();
            senddata();
            home = 0;
            RecPos();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            home = 2;
            forward();
            senddata();
            sendDataStr.Text = "Reset saved position !";
            positionsCounter = 0;
            RecPos();
            home = 0;
        }
        private void runprogress_btn_Click(object sender, EventArgs e)
        {
            if (home == 0)
            {
                home = 3;

                runprogress_btn.Text = "STOP";
                runprogress_btn.ForeColor = Color.White;
                runprogress_btn.BackColor = Color.Red;
                forward();
                senddata();
                sendDataStr.Text = "Running Program...";
            }
            else if (home == 3)
            {
                home = 0;
                runprogress_btn.Text = "Run program";
                runprogress_btn.ForeColor = Color.White;
                runprogress_btn.BackColor = Highlight;
                forward();
                senddata();
                sendDataStr.Text = "Stopped Running Program !";
            }
        }

        private void resetGrip_Click(object sender, EventArgs e)
        {
            Grip_value.Text = "95";
            forward();
            senddata();
            sendDataStr.Text = "Reset gripper !";
        }

        private void gripper_slider_Scroll(object sender, EventArgs e)
        {
            Grip_value.Text = gripper_slider.Value.ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }

        private void Speed_Slider_Scroll(object sender, EventArgs e)
        {
            speed_value.Text = Speed_Slider.Value.ToString();
        }

        private void p_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void p10G_Click(object sender, EventArgs e)
        {
            Grip_value.Text = (Convert.ToInt32(Grip_value.Text) + 10).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            home = 8;
            forward();
            senddata();
            sendDataStr.Text = "HOME 1!";
            home = 0;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            home = 9;
            forward();
            senddata();
            sendDataStr.Text = "HOME 2!";
            home = 0;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            home = 11;
            forward();
            senddata();
            sendDataStr.Text = "STOP!";
            home = 0;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            home = 12;
            forward();
            senddata();
            sendDataStr.Text = "DIEU KHIEN HOME BANG TAY!";
            home = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            home = 10;
            forward();
            senddata();
            sendDataStr.Text = "HOME!";
            home = 0;
        }

        private void tab1_Click(object sender, EventArgs e)
        {

        }

        private void p1G_Click(object sender, EventArgs e)
        {
            Grip_value.Text = (Convert.ToDouble(Grip_value.Text) + 1).ToString();
            forward();
            senddata();
        }

        private void m1G_Click(object sender, EventArgs e)
        {
            Grip_value.Text = (Convert.ToDouble(Grip_value.Text) - 1).ToString();
            forward();
            senddata();
        }

        private void m10G_Click(object sender, EventArgs e)
        {
            Grip_value.Text = (Convert.ToDouble(Grip_value.Text) - 10).ToString();
            forward();
            System.Threading.Thread.Sleep(100);
            senddata();
        }

        private void Grap_btn_Click(object sender, EventArgs e)
        {

            if (Grip_value.Text != "145")
            {
                Grip_value.Text = "145";
                Grap_btn.Text = "Drop";
                Grap_btn.ForeColor = Color.White;
                Grap_btn.BackColor = Color.Red;
            }


            else if (Grip_value.Text == "145")
            {
                Grip_value.Text = "30";
                Grap_btn.Text = "Grip";
                Grap_btn.ForeColor = Color.White;
                Grap_btn.BackColor = Color.DeepPink;
            }

            forward();
            senddata();
        }


        private void Speed_Slider_MouseUp(object sender, MouseEventArgs e)
        {
            forward();
            senddata();
            sendDataStr.Text = "Speed Changed !";
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tab1)
            {
                Speed_Slider.Enabled = true;
                rst4.Enabled = true;
                groupBox5.Show();
                //serialPort1.WriteLine("h;");
                serialPort1.WriteLine("bt0;");
                //System.Threading.Thread.Sleep(2500);
                serialPort1.WriteLine("manual;");
                sendDataStr.Text = "[ ==== <Manual mode> ==== ]";
            }
            else if (tabControl1.SelectedTab == tab2)
            {
                groupBox5.Show();
                speed_value.Text = "1000";
                home = 10000;
                forward();
                senddata();
                serialPort1.WriteLine("bt1;");
                rst4.Enabled = false;
                sendDataStr.Text = "[ ===== <Auto mode> ===== ]";
                home = 0;
                reData.Text = "            !!! Please TURN OFF python program before switching to 'Manual mode' !!!            * Object detection on conveyor belt: *";
            }
        }

        private void rst4_Click(object sender, EventArgs e)
        {
            speed_value.Text = "550";
            forward();
            senddata();
            sendDataStr.Text = "Reset robot speed !";
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (data11 != null)
            {

                var DataJson = JsonConvert.DeserializeObject<dynamic>(data11.Trim());

                if (DataJson.d1 == 1)
                {
                    sendDataStr.Text = "Auto home done!";
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 3)
                {
                    sendDataStr.Text = "Done !";
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 6)
                {
                    sendDataStr.Text = "Tell me what to do, buddy !";
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == "kho1")
                {
                    sendDataStr.Text = "Kho 1!";
                    kho1counter++;
                    dx = DataJson.dx;
                    dy = DataJson.dy;
                    dz = DataJson.dz;
                    da = DataJson.da;
                    dc = DataJson.dc;
                    vcount.Text = kho1counter.ToString();
                    if (dc == 1)
                    {
                        count++;
                        dataGridView1.Rows.Add(count, dx, dy, dz, da, "Kho 1");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                    }
                }
                else if (DataJson.d1 == "kho2")
                {
                    sendDataStr.Text = "Kho 2!";
                    kho2counter++;
                    dx = DataJson.dx;
                    dy = DataJson.dy;
                    dz = DataJson.dz;
                    da = DataJson.da;
                    dc = DataJson.dc;
                    gcount.Text = kho2counter.ToString();
                    if (dc == 2)
                    {
                        count++;
                        dataGridView1.Rows.Add(count, dx, dy, dz, da, "Kho 2");
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;

                    }
                }

                else if (DataJson.d1 == 11)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 12)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 13)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 14)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 15)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 16)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 17)
                {
                    dc = DataJson.dc;
                }
                else if (DataJson.d1 == 18)
                {
                    dc = DataJson.dc;
                }
                else reData.Text = data11;

                }
            totalcount.Text = (kho1counter + kho2counter).ToString();

            int[] giatri  = new int[7]; //{ 0, 0, 0, 0, 0, 0, 0, 0 };
            int[] giatri1 = new int[3];
            int[] giatri4 = new int[3];

            giatri[1] = kho2counter;
            giatri[5] = kho1counter;

            giatri1[0] = kho2counter;
            giatri1[2] = kho1counter;


            BeginInvoke(new Action(() =>
            {

            }));
        }

        void RecPos()
        {
            if (positionsCounter > 0)
            {
                REC_data1.Text = "Last saved position: No." + (positionsCounter - 1).ToString();
                REC_data2.Text = positions[positionsCounter - 1];
            }
            else
            {
                REC_data1.Text = "Last saved position: ";
                REC_data2.Text = "none";
            }
        }

        //Connect button// Disconnect
        private void btnCon_Click(object sender, EventArgs e)
        {
            if (btnCon.Text == "CONNECTED")
            {
                btnCon.Text = "DISCONNECTED";
                btnCon.BackColor = Color.Red;

                if (serialPort1.IsOpen == false) return;
                serialPort1.Close();

                btnCon.Enabled = true;
                groupBox4.Enabled = false;
                groupBox3.Enabled = false;
                groupBox5.Enabled = false;
                tabControl1.Enabled = false;
                sendDataStr.Text = "DISCONNECTED !";
            }


            else if (btnCon.Text == "DISCONNECTED")
            {
                btnCon.Text = "CONNECTED";
                btnCon.BackColor = Color.Green;

                serialPort1.PortName = cmbCOMPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(cmbBaurate.Text);
                if (serialPort1.IsOpen) return;
                serialPort1.Open();
                serialPort1.WriteLine("p");

                tabControl1.Enabled = true;
                groupBox4.Enabled = true;
                groupBox3.Enabled = true;
                groupBox5.Enabled = true;

                p.Text = "10";
                value_x.Text = "350";
                Grip_value.Text = "95";
                speed_value.Text = "550";
                sendDataStr.Text = "CONNECTED !";
                gripper_slider.Value = Convert.ToInt16(Grip_value.Text);
                Speed_Slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(speed_value.Text)));
            }
        }

        //forward kinematics
        private void send_btn_Click(object sender, EventArgs e)
        {
            forward();
            senddata();
            sendDataStr.Text = "Going...!";
        }

        //inverse kinmatics
        private void Compute_btn_Click(object sender, EventArgs e)
        {
            inverse();
            senddata();
            sendDataStr.Text = "Running...!";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }

        void senddata()
        {
            String data = "{" + "\"d1\":" + data1 + "," +
                                "\"d2\":" + data2 + "," +
                                "\"d3\":" + data3 + "," +
                                "\"d4\":" + data4 + "," +
                                "\"d5\":" + data5 + "," +
                                "\"d6\":" + data6 + "," +
                                "\"d7\":" + data7 + "}";


            //String data =   data1 + "," +
            //                data2 + "," +
            //                data3 + "," +
            //                data4 + "," +
            //                data5 + "," +
            //                data6 + "," +
            //                data7;


            serialPort1.WriteLine(data);
            sendDataStr.Text = data;
        }

        void forward()
        {
            if (Convert.ToDouble(the1.Text) < -180 || Convert.ToDouble(the1.Text) > 180)
            {
                MessageBox.Show("The value of Theta1 is allowed from -180 to 180 angle.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Convert.ToDouble(the1.Text) < -180)
                {
                    the1.Text = "-180";
                }
                if (Convert.ToDouble(the1.Text) > 180)
                {
                    the1.Text = "180";
                }
            }
            else if (Convert.ToDouble(the2.Text) < -90 || Convert.ToDouble(the2.Text) > 90)
            {
                MessageBox.Show("The value of Theta2 is allowed from -90 to 90 angle.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Convert.ToDouble(the2.Text) < -90)
                {
                    the2.Text = "-90";
                }
                if (Convert.ToDouble(the2.Text) > 90)
                {
                    the2.Text = "90";
                }
            }
            else if (Convert.ToDouble(the3.Text) < -90 || Convert.ToDouble(the3.Text) > 90)
            {
                MessageBox.Show("The value of Theta3 is allowed from -90 to 90 angle.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Convert.ToDouble(the3.Text) < -90)
                {
                    the3.Text = "-90";
                }
                if (Convert.ToDouble(the3.Text) > 90)
                {
                    the3.Text = "90";
                }
            }
            else
            {
                data1 = Math.Round(Convert.ToDouble(the1.Text)).ToString();
                data2 = Math.Round(Convert.ToDouble(the2.Text)).ToString();
                data3 = Math.Round(Convert.ToDouble(the3.Text)).ToString();
                data4 = Math.Round(Convert.ToDouble(value_z.Text)).ToString();
                data5 = home.ToString();
                data6 = (Math.Round(Convert.ToDouble(speed_value.Text)) * 8).ToString();
                data7 = Math.Round(Convert.ToDouble(Grip_value.Text)).ToString();

                X = Math.Round(L1 * Math.Cos(Convert.ToDouble(the1.Text) * conv) + L2 * Math.Cos((Convert.ToDouble(the1.Text) + Convert.ToDouble(the2.Text)) * conv),2);
                Y = Math.Round(L1 * Math.Sin(Convert.ToDouble(the1.Text) * conv) + L2 * Math.Sin((Convert.ToDouble(the1.Text) + Convert.ToDouble(the2.Text)) * conv),2);

                value_x.Text = X.ToString();
                value_y.Text = Y.ToString();

                j1slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(the1.Text)));
                j2slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(the2.Text)));
                j3slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(the3.Text)));
                gripper_slider.Value = Convert.ToInt16(Convert.ToDouble(Grip_value.Text));
                Speed_Slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(speed_value.Text)));
            }
        }

        void inverse()
        {
            X = Convert.ToDouble(value_x.Text);
            Y = Convert.ToDouble(value_y.Text);
            if (tt_z == 1)
            {
                if (Convert.ToDouble(value_z.Text) < -70 || Convert.ToDouble(value_z.Text) > 70)
                {
                    MessageBox.Show("The value of z is allowed from -70 to 70 mm.", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (Convert.ToDouble(value_z.Text) < -70)
                    {
                        value_z.Text = "-70";
                    }
                    if (Convert.ToDouble(value_z.Text) > 70)
                    {
                        value_z.Text = "70";
                    }
                }
                data1 = Math.Round(Convert.ToDouble(the1.Text)).ToString();
                data2 = Math.Round(Convert.ToDouble(the2.Text)).ToString();
                data3 = Math.Round(Convert.ToDouble(the3.Text)).ToString();
                data4 = Math.Round(Convert.ToDouble(value_z.Text)).ToString();
                data5 = home.ToString();
                data6 = (Math.Round(Convert.ToDouble(speed_value.Text)) * 8).ToString();
                data7 = Math.Round(Convert.ToDouble(Grip_value.Text)).ToString();
            }

            else if ((X * X + Y * Y - L1 * L1 - L2 * L2) / (2 * L1 * L2) <= -1 || (X * X + Y * Y - L1 * L1 - L2 * L2) / (2 * L1 * L2) >= 1)
            { MessageBox.Show("The value of work space is exceeded. Enter again, please!", "Out of range", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else  //neu dung dieu kien
            {
                theta2 = Math.Acos((X * X + Y * Y - L1 * L1 - L2 * L2) / (2 * L1 * L2));
                if (X < 0 & Y < 0)
                {
                    theta2 = (-1) * theta2;
                }

                theta1 = Math.Atan(X / Y) - Math.Atan((L2 * Math.Sin(theta2)) / (L1 + L2 * Math.Cos(theta2)));

                theta2 = (-1) * theta2 / conv;

                theta1 = theta1 / conv;

                // Angles adjustment depending in which quadrant the final tool coordinate x,y is
                if (X >= 0 & Y >= 0)
                {       // 1st quadrant
                    theta1 = 90 - theta1;
                }
                if (X < 0 & Y > 0)
                {       // 2nd quadrant
                    theta1 = 90 - theta1;
                }
                if (X < 0 & Y < 0)
                {       // 3d quadrant
                    theta1 = 270 - theta1;
                }
                if (X > 0 & Y < 0)
                {       // 4th quadrant
                    theta1 = -90 - theta1;
                }
                if (X < 0 & Y == 0)
                {
                    theta1 = 270 + theta1;
                }
                if (X == 0 && Y < 0)
                {
                    theta1 = -90 - theta1;
                }

                the1.Text = Math.Round(theta1).ToString();
                the2.Text = Math.Round(theta2).ToString();

                data1 = Math.Round(Convert.ToDouble(the1.Text)).ToString();
                data2 = Math.Round(Convert.ToDouble(the2.Text)).ToString();
                data3 = Math.Round(Convert.ToDouble(the3.Text)).ToString();
                data4 = Math.Round(Convert.ToDouble(value_z.Text)).ToString();
                data5 = home.ToString();
                data6 = (Math.Round(Convert.ToDouble(speed_value.Text)) * 8).ToString();
                data7 = Math.Round(Convert.ToDouble(Grip_value.Text)).ToString();

                j1slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(the1.Text)));
                j2slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(the2.Text)));
                j3slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(the3.Text)));
                gripper_slider.Value = Convert.ToInt16(Grip_value.Text);
                Speed_Slider.Value = Convert.ToInt16(Math.Round(Convert.ToDouble(speed_value.Text)));
            }
        }
    }
}
