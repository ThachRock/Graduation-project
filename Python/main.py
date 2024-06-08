import math
import cv2
import numpy as np
import serial
import sys
import pyzbar.pyzbar as pyzbar
import time
ser = serial.Serial('COM9',9600)
cap = img = obj = c = []
nObj = 0  # Object
Px = Py = 0  # Trục X, Y mm
Or = 0.0  # Or là góc
Pz = 150  # Trục Z mm
s = 0  # stop & start
h = 1  # đang home
#tm = 0
t1 = 0
t2 = 0
t3 = 0
t11 = 45
t22 = -45
t33=0
t111 = -45
t222 = 45
t333=0
l1 = 200
l2 = 150
print('Ready!')
def imgProccessing():
    global img, nObj, obj,giay,giay_mili
    Objects = []
    # Xác định mã QR trong ảnh
    decodedObjects = pyzbar.decode(img)
    # Vẽ đường biên quanh mã QR và hiển thị vị trí
    for c in decodedObjects:
        x, y, w, h = c.rect
        # Lấy các đỉnh của mã QR
        pts = c.polygon

        # Vẽ các đường thẳng nối các đỉnh
        if len(pts) > 4:
            pts = pts[:4]  # Chỉ lấy 4 đỉnh đầu tiên nếu có nhiều hơn
        for j in range(len(pts)):
            cv2.line(img, tuple(pts[j]), tuple(pts[(j + 1) % len(pts)]), (255, 0, 255), 3)
        data = c.data.decode('utf-8')
        cv2.rectangle(img, (x, y), (x + w, y + h), (0, 255, 0), 2)
        cv2.putText(img, str(data), (x, y - 10), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 0, 255), 2)
        qr_x = x + w // 2
        qr_y = y + h // 2
        cv2.putText(img, '.', (qr_x, qr_y), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (0, 0, 255), 2)
        cv2.putText(img, '(' + str(qr_x) + ';' + str(qr_y) + ')', (qr_x, qr_y + 20), cv2.FONT_HERSHEY_SIMPLEX, 0.5,
                        (0, 0, 255), 2)
        # Tính toán góc quay của mã QR
        angle_rad = math.atan2(pts[1][1] - pts[0][1], pts[1][0] - pts[0][0])
        angle_deg = np.degrees(angle_rad)
        angle = np.round(angle_deg, decimals=0, out=None)
        print("Angle:", angle)
        if data == '1':
            Objects.append([qr_x, qr_y, angle, 1])
        else:
            Objects.append([qr_x, qr_y, angle, 2])
            # Hiển thị góc quay trên ảnh
        cv2.putText(img, f'Angle: {angle:.2f}', tuple(pts[0]), cv2.FONT_HERSHEY_SIMPLEX, 0.5, (255, 255, 0), 2)

    # Hiển thị ảnh
    cv2.imshow("QR Detection", img)
    cv2.waitKey(1)
    # sort
    nObj = len(Objects)  # số lượng hàng
    if nObj:
        # def X(elem):
        #    return elem[1]   #sắp xếp theo số thứ 2 trong mảng (cY)
        # Objects.sort(key=X, reverse=True)  #đảo thứ tự (bé đến lớn) theo Y

        def X(elem):
            return elem[0]  # sắp xếp theo số thứ 2 trong mảng (cX)

        Objects.sort(key=X, reverse=False)  # đảo thứ tự (lớn đến bé) theo X

        obj = Objects[0]

        print(obj)
    # Hiển thị hình ảnh có hình chữ nhật đã nhận diện
def convertCoordinates():
    global obj, Px, Py, Or, h, data_string, data_string1, data_string2, col,ix,a,b,c,d
    Px = obj[1] * 0.11111111 - 85
    Py = obj[0] * -0.11111111 + 45
    print(Px)
    print(Py)
    Or = 90 - obj[2]
    col = obj[3]
    a = math.cos(t1 + t2 - t3)
    b = math.sin(t1 + t2 - t3)
    c = l2 * math.cos(t1 + t2) + l1 * math.cos(t1)
    d = l2 * math.sin(t1 + t2) + l1 * math.sin(t1)
    A = np.array([[a, b, 0, c], [b, -a, 0, d], [0, 0, -1, 150], [0, 0, 0, 1]])
    B = np.array([[Px], [Py], [Pz], [1]])
    r = np.dot(A, B)
    data_string = ','.join(map(str, r[0]))
    data_string1 = ','.join(map(str, r[1]))
    data_string2 = ','.join(map(str, r[2]))
def convertCoordinates1():
    global obj, Px, Py, Or, h, data_string, data_string1, data_string2, col,ix,a,b,c,d
    Px = obj[1] * 0.11111111 - 55
    Py = obj[0] * -0.11111111 + 90
    print(Px)
    print(Py)
    Or = 90 - obj[2]
    col = obj[3]
    a = math.cos(t11 + t22 - t33)
    b = math.sin(t11 + t22 - t33)
    c = l2 * math.cos(t11 + t22) + l1 * math.cos(t11)
    d = l2 * math.sin(t11 + t22) + l1 * math.sin(t11)
    A = np.array([[a, b, 0, c], [b, -a, 0, d], [0, 0, -1, 150], [0, 0, 0, 1]])
    B = np.array([[Px], [Py], [Pz], [1]])
    r = np.dot(A, B)
    data_string = ','.join(map(str, r[0]))
    data_string1 = ','.join(map(str, r[1]))
    data_string2 = ','.join(map(str, r[2]))
def convertCoordinates2():
    global obj, Px, Py, Or, h, data_string, data_string1, data_string2, col,ix,a,b,c,d
    Px = obj[1] * 0.11111111 - 95
    Py = obj[0] * -0.11111111 + 45
    print(Px)
    print(Py)
    Or = 90 - obj[2]
    col = obj[3]
    a = math.cos(t111 + t222 - t333)
    b = math.sin(t111 + t222 - t333)
    c = l2 * math.cos(t111 + t222) + l1 * math.cos(t111)
    d = l2 * math.sin(t111 + t222) + l1 * math.sin(t111)
    A = np.array([[a, b, 0, c], [b, -a, 0, d], [0, 0, -1, 150], [0, 0, 0, 1]])
    B = np.array([[Px], [Py], [Pz], [1]])
    r = np.dot(A, B)
    data_string = ','.join(map(str, r[0]))
    data_string1 = ','.join(map(str, r[1]))
    data_string2 = ','.join(map(str, r[2]))
def sendData():
    global data_string, data_string1, data_string2, Or, col
    Tx = 'obj' + ',' + data_string + ',' + data_string1 + ',' + data_string2 + ',' + str(round(Or, 2)) + ',' + str(
        round(col, 2)) + ';'
    print(Tx)
    ser.write(Tx.encode())
    ser.flush()

def ad():
    global s, h, nObj,x
    if s:  # khi s >0
        imgProccessing()
        if nObj:  # khi có hàng
            if s == 1:
                convertCoordinates()
            elif s ==4:
                convertCoordinates1()
            elif s == 5:
                convertCoordinates2()
            sendData()
            s = 0
            h = 0

        else:  # khi không có hàng  nObj<0
            s = 1  # lập lại chu trình
            if h == 0:  # đảo ngôi của h: 1 thành 0, 0 thành 1, nếu nghịch đảo của h lớn hơn 1
                ser.write("r;".encode())  # encode cái h
                ser.flush()
                h = 1
                # sleep(0.001)


def receiverData():
    global s
    if (ser.in_waiting > 0):
        Rx = ser.readline()
        Rx = Rx.decode()
        print(Rx)
        Rx = Rx.rstrip()  # read string input
        if Rx == 's1':  # start
            s = 1
        elif Rx =='0s1':
            s = 3
        elif Rx =='1s1':
            s = 4
        elif Rx =='2s1':
            s = 5
        elif Rx == 's0':  # stop
            s = 0
        time.sleep(4.5)


try:
    ser.write("rsF;".encode())
    ser.write("r;".encode())
    cap = cv2.VideoCapture(0)
    s = 1
    while (1):
        receiverData()
        _, img = cap.read()
        k = cv2.waitKey(5)
        if k == 27:  # exit by pressing Esc key
            cv2.destroyAllWindows()
            sys.exit()
        ad()
except KeyboardInterrupt:
    cap.release()
    cv2.destroyAllWindows()
    ser.close()
    print('killed rasp')