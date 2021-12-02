using System;
using System.IO.Ports;

public class Arduino_USB
{
    /// <summary>
    /// 接收暫存
    /// </summary>
    public String ReceiveContant { get; set; }
    public Int64 ReceiveID  { get; set; }
    public bool ISOpen { get; set; }
    private SerialPort mySerialPort;

    /// <summary>
    /// 初始化建構式
    /// </summary>
    /// <param name="Port">連接的COM埠口，格式"COM1"</param>
    public Arduino_USB(string Port)
    {
        mySerialPort = new SerialPort(Port);
        mySerialPort.BaudRate = 12000000;
        mySerialPort.RtsEnable = true;
        mySerialPort.DtrEnable = true;
        mySerialPort.ReadTimeout = 5000;
        mySerialPort.WriteTimeout = 1000;
        mySerialPort.NewLine = "\r\n";
        mySerialPort.DataReceived += new SerialDataReceivedEventHandler(ReceiveEven);
    }
    /// <summary>
    /// 觸發接收事件
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ReceiveEven(object sender, SerialDataReceivedEventArgs e)
    {
        if (ISOpen)
        {
            SerialPort sp = (SerialPort)sender;
            String data = sp.ReadExisting();
            ReceiveContant = data;
            ReceiveID++;
        }
    }
    public string DoubleToUsbString(double left, double right)
    {
        string fmt = "0";

        return "Left=" + left.ToString(fmt) + "&Right=" + right.ToString(fmt) + "&";
    }
    /// <summary>
    /// 發送字串
    /// </summary>
    /// <param name="content">字串內容</param>
    public void Transmit(string content)
    {
        try
        {
            if (ISOpen)
            {
                mySerialPort.WriteLine(content);
            }
        }
        catch (Exception e)
        {
            ReceiveContant = e.GetType() + "	" + e.Message;
        }
    }
    /// <summary>
    /// 開啟埠口
    /// </summary>
    public void Open()
    {
        try
        {
            mySerialPort.Open();
            ISOpen = true;
            ReceiveID = 1;
        }
        catch (Exception e)
        {
            ReceiveContant = e.GetType() + "	" + e.Message;
        }
    }
    /// <summary>
    /// 關閉埠口
    /// </summary>
    public void Close()
    {
        try
        {
            ISOpen = false;
            mySerialPort.Close();            
        }
        catch (Exception e)
        {
            ReceiveContant = e.GetType() + "	" + e.Message;
        }
    }
}
