using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using ZedGraph;
using System.Threading;


using System.Xml;

namespace PID_Controller
{
    public partial class Form1 : Form
    {
        string mode_PID;
        int setpoint = 0, setpoint_pulseofDeg = 0;
        string setPoint_SendARM = "0";
        string data;
        string Tam = "";
        long tickStart = 0;
        int status = 0; 
        double realtime = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (LbStatus.Text == "Disconnected")
                {
                    Com.PortName = CbSecCom.Text;   // Chon port tu ten port ghi tren text
                    Com.Open();
                    LbStatus.Text = "Connected";
                    PbConnect.Text = "Disconnect";
                }
                else
                {
                    Com.Close();
                    LbStatus.Text = "Disconnected";
                    PbConnect.Text = "Connect";

                }
            }
            catch (Exception) { }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TickStart = Environment.TickCount;

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "ĐIỀU KHIỂN PID SỐ ĐỘNG CƠ DC SERVO";
            myPane.XAxis.Title.Text = "Time(Seconds)";
            myPane.YAxis.Title.Text = "Speed(RPM) or Position(Deg)";

            RollingPointPairList list = new RollingPointPairList(60000);
            RollingPointPairList list1 = new RollingPointPairList(60000);    //set
            LineItem curve = myPane.AddCurve("Current value", list, Color.Red, SymbolType.None);
            LineItem curve1 = myPane.AddCurve("Set value", list1, Color.Blue, SymbolType.None);    //set
            // tao scale cho truc toa do
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 30;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 5;

            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 1000;
            myPane.YAxis.Scale.MinorStep = 50;
            myPane.YAxis.Scale.MajorStep = 100;
            zedGraphControl1.AxisChange();
            

        }
        int intlen = 0; //luu gia tri so COM ket noi vao may tinh
        private void timer1_Tick(object sender, EventArgs e)              //Lay tat ca cac COM noi voi PC luu vao
        {

            string[] ports = SerialPort.GetPortNames();               //Lay tat ca cac COM noi voi PC luu vao
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                CbSecCom.Items.Clear();
                for (int j = 0; j < intlen; j++)
                {
                    CbSecCom.Items.Add(ports[j]);
                }

            }
            GraphPane myPane = zedGraphControl1.GraphPane;
            if (checkBoxSpeed.Checked==true)
            {
                
                myPane.Title.Text = "ĐIỀU KHIỂN PID VẬN TỐC ĐỘNG CƠ DC SERVO";
                myPane.XAxis.Title.Text = "Time(Seconds)";
                myPane.YAxis.Title.Text = "Speed(RPM)";
            }
            else if(checkBoxPosition.Checked==true)
            {
                myPane.Title.Text = "ĐIỀU KHIỂN PID VỊ TRÍ ĐỘNG CƠ DC SERVO";
                myPane.XAxis.Title.Text = "Time(Seconds)";
                myPane.YAxis.Title.Text = "Position(Deg)";
            }
            Draw(txtReceive.Text, txtSend.Text);

        }

        private void PbSend_Click(object sender, EventArgs e)
        {
            Thread thrd1 = new Thread(Send_thrd1);
            thrd1.Start();
        }
        void Send_thrd1()
        {   
            if (checkBoxSpeed.Checked == true)
            {
                mode_PID = "s";
                if (txtSend.Text == "")
                {
                    setpoint = 0;
                    setPoint_SendARM = string.Format("{0:D4}", 0);         
                }
                else
                {
                    setpoint = int.Parse(txtSend.Text);
                    setPoint_SendARM = string.Format("{0:D4}", setpoint);
                }
            }
            if (checkBoxPosition.Checked == true)
            {
                mode_PID = "p";
                if (txtSend.Text == "")
                {
                    setpoint = 0;
                    setPoint_SendARM = string.Format("{0:D4}", 0);
                }
                else
                {
                    setpoint = int.Parse(txtSend.Text);
                    setpoint_pulseofDeg = setpoint * 800 / 360;
                    setPoint_SendARM = string.Format("{0:D4}", setpoint_pulseofDeg);
                }
            }
            data = "%"+ mode_PID + "" + setPoint_SendARM + "e";
            Com.Write(data);
        }
        int TickStart, intMode = 1;

        private void PbExit_Click(object sender, EventArgs e)
        { try
            {
                Application.Exit();
                //  Close();
            }
            catch (Exception) { }

        }
       private string rxString;
        private void OnCom(object sender,SerialDataReceivedEventArgs e)
        {
            try
            {
                rxString = Com.ReadExisting();
                //this.Invoke(new EventHandler(displayText));

                  Display(rxString);
            }
            catch (Exception) { }


        }
        private void displayText(object o,EventArgs e)
        {  
                txtReceive.Text = rxString;
            
            
          //  txtReceive.AppendText(rxString);
        }
       
        private delegate void DlDisplay(string s);
        private void Display(string s)
        {
            try
            {
                if (txtReceive.InvokeRequired)
                {
                    DlDisplay sd = new DlDisplay(Display);
                    txtReceive.Invoke(sd, new object[] { s });
                }
                else
                {
                    //  txtReceive.Text = s;

                    txtReceive.Text = s;
                }
            }
            catch (Exception) { }
           
        }
                          
        private void PbMode_Click(object sender, EventArgs e)
        {
            try
            {
                if (PbMode.Text == "SROLL")
                {
                    intMode = 1;
                    PbMode.Text = "COMPACT";
                }
                else
                {
                    intMode = 0;
                    PbMode.Text = "SROLL";
                }
            }
            catch (Exception) { }
         
        }                


        private void btnIncrease_Click(object sender, EventArgs e)
        {        
            Com.Write("%"+"I" + "e");
            //   btnStart_Clicked(sender, e);
            if (checkBoxSpeed.Checked == true)
            {
                setpoint += 100;
                txtSend.Text = setpoint.ToString();
            }
            else if (checkBoxPosition.Checked == true)
            {
                setpoint += 60;
                txtSend.Text = setpoint.ToString();
            }
            setpoint = int.Parse(txtSend.Text);
        }
      

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            Com.Write("%"+"D" + "e");
            //  btnStart_Clicked(sender, e);
            if (checkBoxSpeed.Checked == true)
            {
                setpoint -= 100;
                txtSend.Text = setpoint.ToString();
            }
            else if (checkBoxPosition.Checked == true)
            {
                setpoint -= 60;
                txtSend.Text = setpoint.ToString();
            }
            setpoint = int.Parse(txtSend.Text);
        }
     

        private void txtReceive_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            ThreadStart nhanstop = new ThreadStart(HamStop);
            Thread thrd2 = new Thread(nhanstop);
            thrd2.Start();
        }
        void HamStop()
        {

            try
            {
                data ="%"+ "S" + "e";
                Com.Write(data);
            }
            catch (Exception)
            {

            }
        }
        private void Draw(string current,string setvalue)
        {
                double intcurrent;
                double intsetvalue;
                double.TryParse(current, out intcurrent);
                double.TryParse(setvalue, out intsetvalue);
                if (zedGraphControl1.GraphPane.CurveList.Count <= 0)
                    return;
                //get the first CurveItem in the graph
                LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
                if (curve == null)               //neu khong co duong curve thi se tra ve chuong trinh chinh 
                    return;

                LineItem curve1 = zedGraphControl1.GraphPane.CurveList[1] as LineItem;
                if (curve1 == null)               //neu khong co duong curve thi se tra ve chuong trinh chinh 
                    return;


                // kiem tra list chua tat ca cac diem cua duong cong
                IPointListEdit list = curve.Points as IPointListEdit;
                if (list == null)
                    return;
                IPointListEdit list1 = curve1.Points as IPointListEdit;
                if (list1 == null)
                    return;

                double time = (Environment.TickCount - TickStart) / 1000.0;   // thoi gian hien tai-thoi gian bat dau/1000 ra milis
                list.Add(time, intcurrent);
                list1.Add(time, intsetvalue);
                //SCALE
                Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
                Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;
            if (time > xScale.Max - xScale.MajorStep)
                {
                    if (intMode == 1)
                    {
                        xScale.Max = time + xScale.MajorStep;
                        xScale.Min = xScale.Max - 30.0;

                    }
                    else
                    {
                        xScale.Max = time + xScale.MajorStep;
                        xScale.Min = 0;
                    }
                }             
            
            if (realtime > xScale.Max - xScale.MajorStep)
            {
                xScale.Max = realtime + xScale.MajorStep;
                xScale.Min = xScale.Max - 30;
            }

            if (setpoint > yScale.Max - yScale.MajorStep)
            {
                yScale.Max = setpoint + yScale.MajorStep;
            }
            else if (setpoint < yScale.Min + yScale.MajorStep)
            {
                yScale.Min = setpoint - yScale.MajorStep;
            }
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

    }
}
