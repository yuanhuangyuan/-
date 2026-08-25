using System;
using System.Collections.Generic;


using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;
using System.IO;
using System.Diagnostics;


namespace NL_4_Debugger_Test
{
    public partial class Form1 : Form
    {
        const int VCI_USBCAN_2E_U = 21;
        private Random rand = new Random();
        static UInt32 m_devtype = 21;//USBCAN-2e-u
        static UInt32[] GCanBrTab = new UInt32[10]{0x060003, 0x060004, 0x060007,0x1C0008, 0x1C0011, 0x160023,
		                0x1C002C, 0x1600B3, 0x1C00E0, 0x1C01C1};
        int SendCase = 0;
        ////////////////////////////////////////
        const UInt32 STATUS_OK = 1;
        UInt32 m_bOpen = 0;
        UInt32 m_STSEND= 0;
        UInt32 m_chartm_bOpen = 0;
        UInt32 m_devind = 0;
        UInt32 m_canind = 0;
        private CanAdapterKind activeAdapter = CanAdapterKind.Zlg;
        private Int32 toomossDeviceHandle = -1;
        private Byte ToomossCanChannel { get { return (Byte)(comboBoxCanChannel.SelectedIndex == 1 ? 1 : 0); } }
        VCI_CAN_OBJ[] m_recobj = new VCI_CAN_OBJ[50];
        Int32[] Int32DataReceiveBuffer = new Int32[100];
        UInt32[] m_arrdevtype = new UInt32[20];
        bool  CANMsgREn = true ;
        bool CANMsgTEn = true;
        private readonly Dictionary<Control, ControlLayoutSnapshot> originalLayout = new Dictionary<Control, ControlLayoutSnapshot>();
        private Size designClientSize;
        private bool applyingScale;
        public Form1()
        {
            InitializeComponent();

            // 设计器只加载静态布局，避免 CAN/缩放等运行期代码干扰 Visual Studio 设计视图。
            if (IsDesignTimeHost())
                return;

         //   comboBox6.Items.Add("CompForceCtrl");//0
            comboBox6.Items.Add("ExvForceCtrl");//1
           // comboBox6.Items.Add("PumpForceCtrl");//2
           // comboBox6.Items.Add("FanForceCtrl");//3
           // comboBox6.Items.Add("CompInitTim");//4
            comboBox6.Items.Add("ExvInitTim");
           // comboBox6.Items.Add("CompInitVal");
            comboBox6.Items.Add("ExvInitVal");
           // comboBox6.Items.Add("ComChgTim");
            comboBox6.Items.Add("ExvChgTim");
            //comboBox6.Items.Add("ComOffTim");
            //comboBox6.Items.Add("PIDCompKp");
            //comboBox6.Items.Add("PIDCompKi");
            comboBox6.Items.Add("PtTarTsh");
          //  comboBox6.Items.Add("Ed1");
           // comboBox6.Items.Add("Ed2");
           // comboBox6.Items.Add("Ed3");
           // comboBox6.Items.Add("Ed4");
           // comboBox6.Items.Add("Fd1");
           // comboBox6.Items.Add("Fd2");
            //comboBox6.Items.Add("FanChgTim");
           // comboBox6.Items.Add("PumpSpeed1");
           // comboBox6.Items.Add("PumpSpeed2");
           // comboBox6.Items.Add("PumpSpeed3");
            //comboBox6.Items.Add("PumpSpeed4");
            //comboBox6.Items.Add("PumpSpeed5");
            //comboBox6.Items.Add("Wt1");
            //comboBox6.Items.Add("Wt2");
           // comboBox6.Items.Add("Wt3");
           // comboBox6.Items.Add("Bt1");
            //comboBox6.Items.Add("Bt2");
           // comboBox6.Items.Add("FanSpdMax");
           // comboBox6.Items.Add("FanInitSpd");
           // comboBox6.Items.Add("CompSpdMin");
            //comboBox6.Items.Add("FanSpdMax");
            //comboBox6.Items.Add("CompSpdMax");
            //comboBox6.Items.Add("CompHPdecTim");
            //comboBox6.Items.Add("CompOnLps");
            //comboBox6.Items.Add("CompOnHps");
            //comboBox6.Items.Add("CompChgCoef");
          //  comboBox6.Items.Add("CompOffWtemp");
            comboBox6.Items.Add("ExvOnMax");
            comboBox6.Items.Add("ExvOnMin");
            //comboBox6.Items.Add("FanOffTim");
            //comboBox6.Items.Add("PumpOffTim");
            comboBox6.DropDownHeight = comboBox6.ItemHeight * comboBox6.Items.Count;
    
          
      

          
            

            comboBoxCanAdapter.Items.Add("周立功 USB-CAN");
            comboBoxCanAdapter.Items.Add("图莫斯 TUA0503（CAN）");
            comboBoxCanAdapter.SelectedIndex = 0;
            comboBoxCanChannel.Items.Add("CAN1（通道 0）");
            comboBoxCanChannel.Items.Add("CAN2（通道 1）");
            comboBoxCanChannel.SelectedIndex = 0;
            comboBoxCanChannel.Enabled = false;

        }

        // Visual Studio 新版 WinForms 设计器通过独立进程加载窗体，
        // 此时 LicenseManager 不一定会返回 Designtime，必须同时识别设计器宿主。
        private static bool IsDesignTimeHost()
        {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return true;

            string processName = Process.GetCurrentProcess().ProcessName;
            return processName.IndexOf("devenv", StringComparison.OrdinalIgnoreCase) >= 0 ||
                   processName.IndexOf("designtools", StringComparison.OrdinalIgnoreCase) >= 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 仅在程序真实运行后启用缩放。设计器在加载窗体时也会触发 Resize，
            // 若在构造阶段订阅会改写设计画布中的控件坐标。
            if (IsDesignTimeHost())
                return;

            CaptureDesignLayout();
            Resize += Form1_Resize;
        }

        private void CaptureDesignLayout()
        {
            designClientSize = ClientSize;
            CaptureControlLayout(this);
        }

        private void CaptureControlLayout(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                originalLayout[control] = new ControlLayoutSnapshot(control.Bounds, control.Font);
                if (control.HasChildren)
                    CaptureControlLayout(control);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (applyingScale || designClientSize.Width == 0 || designClientSize.Height == 0)
                return;

            // 使用统一比例缩放，避免控件随窗口宽高比变化而变形。
            float scale = Math.Min((float)ClientSize.Width / designClientSize.Width,
                                   (float)ClientSize.Height / designClientSize.Height);
            scale = Math.Max(0.55F, scale);
            int offsetX = Math.Max(0, (ClientSize.Width - (int)(designClientSize.Width * scale)) / 2);
            int offsetY = Math.Max(0, (ClientSize.Height - (int)(designClientSize.Height * scale)) / 2);

            applyingScale = true;
            SuspendLayout();
            try
            {
                ApplyScaledLayout(this, scale, offsetX, offsetY, true);
            }
            finally
            {
                ResumeLayout(true);
                applyingScale = false;
            }
        }

        private void ApplyScaledLayout(Control parent, float scale, int offsetX, int offsetY, bool isRoot)
        {
            foreach (Control control in parent.Controls)
            {
                ControlLayoutSnapshot snapshot;
                if (!originalLayout.TryGetValue(control, out snapshot))
                    continue;

                int x = (int)Math.Round(snapshot.Bounds.X * scale) + (isRoot ? offsetX : 0);
                int y = (int)Math.Round(snapshot.Bounds.Y * scale) + (isRoot ? offsetY : 0);
                int width = Math.Max(1, (int)Math.Round(snapshot.Bounds.Width * scale));
                int height = Math.Max(1, (int)Math.Round(snapshot.Bounds.Height * scale));

                float fontSize = Math.Max(6F, snapshot.Font.SizeInPoints * scale);
                control.Font = new Font(snapshot.Font.FontFamily, fontSize, snapshot.Font.Style, GraphicsUnit.Point);
                TextBox textBox = control as TextBox;
                if (textBox != null)
                    textBox.AutoSize = false;
                control.Bounds = new Rectangle(x, y, width, height);

                if (control.HasChildren)
                    ApplyScaledLayout(control, scale, 0, 0, false);
            }
        }

        private sealed class ControlLayoutSnapshot
        {
            public readonly Rectangle Bounds;
            public readonly Font Font;

            public ControlLayoutSnapshot(Rectangle bounds, Font font)
            {
                Bounds = bounds;
                Font = font;
            }
        }

        private enum CanAdapterKind { Zlg, ToomossUsb2xxx }

        private bool UsingToomoss { get { return activeAdapter == CanAdapterKind.ToomossUsb2xxx; } }

        private void butCANConnect_Click(object sender, EventArgs e)
        {
            if (m_bOpen == 1)
            {
                CloseActiveCan();
                m_bOpen = 0;
            }
            else
            {
                activeAdapter = comboBoxCanAdapter.SelectedIndex == 1 ? CanAdapterKind.ToomossUsb2xxx : CanAdapterKind.Zlg;
                if (!OpenActiveCan()) return;
                m_bOpen = 1;
            }

            butCANConnect.Text = m_bOpen == 1 ? "断开" : "连接";
            butCANConnect.BackColor = m_bOpen == 1 ? Color.Lime : SystemColors.ControlLight;
            comboBoxCanAdapter.Enabled = m_bOpen == 0;
            comboBoxCanChannel.Enabled = m_bOpen == 0 && UsingToomoss;
            timerCANRec.Enabled = m_bOpen == 1;
        }

        private void comboBoxCanAdapter_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCanChannel.Enabled = m_bOpen == 0 && comboBoxCanAdapter.SelectedIndex == 1;
        }

        private bool OpenActiveCan()
        {
            try { return UsingToomoss ? OpenToomossCan() : OpenZlgCan(); }
            catch (DllNotFoundException)
            {
                MessageBox.Show("未找到所选 CAN 适配器的驱动 DLL，请确认程序目录内的驱动文件完整。", "驱动缺失", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            catch (EntryPointNotFoundException)
            {
                MessageBox.Show("CAN 驱动版本不匹配，请使用随安装包提供的驱动文件。", "驱动错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        private unsafe bool OpenZlgCan()
        {
            m_devtype = VCI_USBCAN_2E_U; m_devind = 0; m_canind = 0;
            if (PublicClass.VCI_OpenDevice(m_devtype, m_devind, 0) == 0)
            {
                MessageBox.Show("打开周立功 CAN 设备失败，请检查设备和驱动。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false;
            }
            UInt32 baud = GCanBrTab[2];
            if (PublicClass.VCI_SetReference(m_devtype, m_devind, m_canind, 0, (byte*)&baud) != STATUS_OK)
            { PublicClass.VCI_CloseDevice(m_devtype, m_devind); MessageBox.Show("设置 500 kbps 波特率失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            VCI_INIT_CONFIG config = new VCI_INIT_CONFIG { AccCode = 0, AccMask = 0xFFFFFFFF, Timing0 = 0x00, Timing1 = 0x1c, Filter = 1, Mode = 0 };
            if (PublicClass.VCI_InitCAN(m_devtype, m_devind, m_canind, ref config) != STATUS_OK || PublicClass.VCI_StartCAN(m_devtype, m_devind, m_canind) != STATUS_OK)
            { PublicClass.VCI_CloseDevice(m_devtype, m_devind); MessageBox.Show("初始化周立功 CAN 通道失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            return true;
        }

        private bool OpenToomossCan()
        {
            Int32[] devices = new Int32[20];
            if (ToomossCan.USB_ScanDevice(devices) <= 0)
            { MessageBox.Show("未检测到图莫斯 USB2XXX 设备，请检查 USB 连接和驱动。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            toomossDeviceHandle = devices[0];
            if (!ToomossCan.USB_OpenDevice(toomossDeviceHandle))
            { toomossDeviceHandle = -1; MessageBox.Show("打开图莫斯 USB2XXX 设备失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            ToomossCan.CanInitConfig config = new ToomossCan.CanInitConfig();
            if (ToomossCan.CAN_GetCANSpeedArg(toomossDeviceHandle, ref config, 500000) != ToomossCan.Success)
            { CloseActiveCan(); MessageBox.Show("图莫斯设备不支持 500 kbps 波特率。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            // 与图莫斯 EXAMPLE 一致：正常模式 + 内置 120 Ω 终端电阻。
            config.CanMode = 0x80;
            if (ToomossCan.CAN_Init(toomossDeviceHandle, 0, ref config) != ToomossCan.Success ||
                ToomossCan.CAN_Init(toomossDeviceHandle, 1, ref config) != ToomossCan.Success ||
                ToomossCan.CAN_StartGetMsg(toomossDeviceHandle, ToomossCanChannel) != ToomossCan.Success)
            { CloseActiveCan(); MessageBox.Show("初始化图莫斯 CAN 通道失败。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return false; }
            ToomossCan.CAN_ClearMsg(toomossDeviceHandle, ToomossCanChannel);
            return true;
        }

        private void CloseActiveCan()
        {
            if (UsingToomoss)
            {
                if (toomossDeviceHandle >= 0) { ToomossCan.CAN_StopGetMsg(toomossDeviceHandle, ToomossCanChannel); ToomossCan.CAN_Stop(toomossDeviceHandle, 0); ToomossCan.CAN_Stop(toomossDeviceHandle, 1); ToomossCan.USB_CloseDevice(toomossDeviceHandle); toomossDeviceHandle = -1; }
            }
            else PublicClass.VCI_CloseDevice(m_devtype, m_devind);
        }

        unsafe private void timerCANRec_Tick(object sender, EventArgs e)
        {
            if (UsingToomoss)
            {
                ReceiveToomossFrames();
                return;
            }
            UInt32 res = new UInt32();
            int MAXCOUNT = 19;
            bool scroll = false;
            res = PublicClass.VCI_GetReceiveNum(m_devtype, m_devind, m_canind);
            if (res == 0)
                return;
            /////////////////////////////////////
            UInt32 con_maxlen = 50;
            IntPtr pt = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(VCI_CAN_OBJ)) * (Int32)con_maxlen);
            res = PublicClass.VCI_Receive(m_devtype, m_devind, m_canind, pt, con_maxlen, 100);
            ////////////////////////////////////////////////////////
            String str = "";
            for (UInt32 i = 0; i < res; i++)
            {
                VCI_CAN_OBJ obj = (VCI_CAN_OBJ)Marshal.PtrToStructure((IntPtr)((UInt32)pt + i * Marshal.SizeOf(typeof(VCI_CAN_OBJ))), typeof(VCI_CAN_OBJ));

                str = "RX  "+ DateTime.Now.TimeOfDay.ToString() + ": ";
                str += " ID:0x" + System.Convert.ToString((Int32)obj.ID, 16) + "   ";
                Int32DataReceiveBuffer[0] = (Int32)obj.ID;
                //////////////////////////////////////////
                if (obj.RemoteFlag == 0)
                {
                    //str += "数据: ";
                    byte len = (byte)(obj.DataLen % 9);

                    for (byte j = 0; j < len; j++)
                    {
                        str += "  " + System.Convert.ToString(obj.Data[j], 16).PadLeft(2, '0');
                        Int32DataReceiveBuffer[j + 1] = obj.Data[j];
                    }
                    ReceivedMsgAnalyse(Int32DataReceiveBuffer);
                }

                //if (true == CANMsgREn && (0x18FF0E19 == Int32DataReceiveBuffer[0] || 0x18FF0f19 == Int32DataReceiveBuffer[0]))//&& Int32DataReceiveBuffer[0] == 0x438
                //{
                //    listBoxCANMsg_R.Items.Add(str);
                //    listBoxCANMsg_R.SelectedIndex = listBoxCANMsg_R.Items.Count - 1;
                //}

                if (false == CANMsgREn)
                {

                }
                else
                {
                    //listBoxCANMsg_R.Items.Add(str);
                    //// listBox1.SelectedIndex = listBox1.Items.Count - 1;

                    //if (listBoxCANMsg_R.TopIndex == listBoxCANMsg_R.Items.Count - (int)(listBoxCANMsg_R.Height / listBoxCANMsg_R.ItemHeight))
                    //    scroll = true;
                    //if (scroll)
                    //    listBoxCANMsg_R.TopIndex = listBoxCANMsg_R.Items.Count - (int)(listBoxCANMsg_R.Height / listBoxCANMsg_R.ItemHeight);
                    //if (listBoxCANMsg_R.Items.Count == (MAXCOUNT + 1))
                    //{
                    //    listBoxCANMsg_R.Items.RemoveAt(0);
                    //    listBoxCANMsg_R.TopIndex = listBoxCANMsg_R.Items.Count - (int)(listBoxCANMsg_R.Height / listBoxCANMsg_R.ItemHeight);
                    //}
                }


            }
            Marshal.FreeHGlobal(pt);
        }

        private void ReceiveToomossFrames()
        {
            if (toomossDeviceHandle < 0) return;
            const int maxCount = 50;
            int messageSize = Marshal.SizeOf(typeof(ToomossCan.CanMessage));
            IntPtr buffer = Marshal.AllocHGlobal(messageSize * maxCount);
            try
            {
                int count = ToomossCan.CAN_GetMsgWithSize(toomossDeviceHandle, ToomossCanChannel, buffer, maxCount);
                for (int i = 0; i < count; i++)
                {
                    IntPtr item = IntPtr.Add(buffer, i * messageSize);
                    ToomossCan.CanMessage message = (ToomossCan.CanMessage)Marshal.PtrToStructure(item, typeof(ToomossCan.CanMessage));
                    if ((message.RemoteFlag & 0x01) != 0 || message.Data == null) continue;
                    Int32DataReceiveBuffer[0] = unchecked((Int32)message.Id);
                    int length = Math.Min(8, (int)message.DataLen);
                    for (int j = 0; j < length; j++) Int32DataReceiveBuffer[j + 1] = message.Data[j];
                    ReceivedMsgAnalyse(Int32DataReceiveBuffer);
                }
            }
            finally { Marshal.FreeHGlobal(buffer); }
        }

        private unsafe void SetTransmitTimeout(int timeoutMilliseconds)
        {
            if (!UsingToomoss) PublicClass.VCI_SetReference(m_devtype, m_devind, m_canind, 4, (byte*)&timeoutMilliseconds);
        }

        private unsafe UInt32 TransmitFrame(ref VCI_CAN_OBJ frame)
        {
            if (!UsingToomoss) return PublicClass.VCI_Transmit(m_devtype, m_devind, m_canind, ref frame, 1);
            if (toomossDeviceHandle < 0) return 0;
            ToomossCan.CanMessage message = new ToomossCan.CanMessage
            {
                Id = frame.ID,
                RemoteFlag = (byte)(frame.RemoteFlag & 0x01),
                ExternFlag = frame.ExternFlag,
                DataLen = (byte)Math.Min(8, (int)frame.DataLen),
                Data = new byte[8]
            };
            for (int i = 0; i < message.DataLen; i++) message.Data[i] = frame.Data[i];
            return ToomossCan.CAN_SendMsg(toomossDeviceHandle, ToomossCanChannel, new[] { message }, 1) == 1 ? 1U : 0U;
        }

        private void timerFrame_0x2a5_Tick(object sender, EventArgs e)
        {
            Ctrl_Frame_Send();

        }

        unsafe void Ctrl_Frame_Send()
        {
            string strNum;
            int vartemp =0;
            int vartemp1 ;
            if (m_bOpen == 0)
                return;

            VCI_CAN_OBJ sendFrame1 = new VCI_CAN_OBJ();
            sendFrame1.SendType = 0x0;                  //正常发送
            sendFrame1.RemoteFlag = 0x0;                //数据帧
            sendFrame1.ExternFlag = 0x1;                //正常帧
            sendFrame1.DataLen = 8;

            switch (SendCase++)
            {
                case 0:
                    sendFrame1.ID = 0x18FF25EF;
            
                    
     
                    sendFrame1.Data[1] = (byte)vartemp;
                    sendFrame1.Data[2] = 0;
                    sendFrame1.Data[3] = 0;
                    sendFrame1.Data[4] = 0;
                    sendFrame1.Data[5] = 0;
                   
                    break;
                case 1:
                    sendFrame1.ID = 0x18FF13EF;
                 
                    sendFrame1.Data[1] = 0;
                    sendFrame1.Data[2] = 0;
                    sendFrame1.Data[3] = 0;
                    sendFrame1.Data[4] = 0;
                    sendFrame1.Data[5] = 0;
                    sendFrame1.Data[6] = (byte)(vartemp);
                    sendFrame1.Data[7] = 0;

                    break;
                case 2:

                    break;
                case 3:

                    break;
                default:
                    SendCase = 0;
                    break;

            }



            string frame1SendStr = "TX  " + DateTime.Now.TimeOfDay.ToString() + ": " + " ID:0x" + System.Convert.ToString((Int32)sendFrame1.ID, 16) + "   ";
             
            for (int i = 0; i < 8; i++)
            {
                frame1SendStr += "  " + System.Convert.ToString((Int32)sendFrame1.Data[i], 16).PadLeft(2, '0');
            }

            int nTimeOut = 3000;
            SetTransmitTimeout(nTimeOut);
            //VCI_Transmit(m_devtype, m_devind, m_canind, ref sendFrame1, 1);
            if (TransmitFrame(ref sendFrame1) == 1)
            {
                //MessageBox.Show("发送失败", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // if (true == CtrlFrameDataDisEn)
                //{
                //    listBoxPC_Ctrl_Frame.Items.Add(frame1SendStr);
                //    listBoxPC_Ctrl_Frame.SelectedIndex = listBoxPC_Ctrl_Frame.Items.Count - 1;
                // }

                //listBoxCANMsg_R.Items.Add(frame1SendStr);
                //listBoxCANMsg_R.SelectedIndex = listBoxCANMsg_R.Items.Count - 1;
                if (false == CANMsgTEn)
                {

                }
                else
                {
                    //listBoxCANMsg_T.Items.Add(frame1SendStr);
                    //// listBox1.SelectedIndex = listBox1.Items.Count - 1;

                    //if (listBoxCANMsg_T.TopIndex == listBoxCANMsg_T.Items.Count - (int)(listBoxCANMsg_T.Height / listBoxCANMsg_T.ItemHeight))
                    //    scroll = true;
                    //if (scroll)
                    //    listBoxCANMsg_T.TopIndex = listBoxCANMsg_T.Items.Count - (int)(listBoxCANMsg_T.Height / listBoxCANMsg_T.ItemHeight);
                    //if (listBoxCANMsg_T.Items.Count == (MAXCOUNT + 1))
                    //{
                    //    listBoxCANMsg_T.Items.RemoveAt(0);
                    //    listBoxCANMsg_T.TopIndex = listBoxCANMsg_T.Items.Count - (int)(listBoxCANMsg_T.Height / listBoxCANMsg_T.ItemHeight);
                    //}
                }

            }
        }

        void ReceivedMsgAnalyse(Int32[] ReceiveBuffer)
        {
            
            switch (ReceiveBuffer[0])

            {
                
                case 0x18FF25EF:
                    if (((ReceiveBuffer[2]>>4) & 0x03) == 0)
                    {
                       
                    }
                    else if (((ReceiveBuffer[2] >> 4) & 0x03) == 1)
                    {
                        
                    }
                    else if (((ReceiveBuffer[2] >> 4) & 0x03) == 2)
                    {
                       
                    }
                    break;
                case 0x18FF13EF:
                    if (((ReceiveBuffer[7] >> 5) & 0x03) == 0)
                    {
                       
                    }
                    else if (((ReceiveBuffer[7] >> 4) & 0x03) > 0)
                    {
                       
                    }
                    break;
                case 0x18FFBD80:

                    break;
                case 0x18FFBB86:

                


                    break;
                case 0x18FFBC86:
                    textBox9.Text = (ReceiveBuffer[1] + (ReceiveBuffer[2]<<8)).ToString();
                    textBox16.Text = (ReceiveBuffer[3]&0x0f).ToString();
                    textBox14.Text = ((ReceiveBuffer[3]>>5) & 0x03).ToString();
                    textBox11.Text = ((ReceiveBuffer[3] >>7)).ToString();
                  
             
  
   
                    textBox3.Text = (((ReceiveBuffer[7] & 0x3f) *16 )+ ((ReceiveBuffer[6] >> 4)&0x0f)).ToString();//((ReceiveBuffer[6] >> 4) & 0X0F+(ReceiveBuffer[7]<<4)).ToString();
                    textBox7.Text = ((ReceiveBuffer[7] >> 6) & 0X01).ToString();
                 
                    break;
                case 0x18FF3A86:
                 

                    break;
                case 0x18FF7321:

                    break;
                case 0x18FF7319:
                    switch (ReceiveBuffer[3])
                    {
                        case 0:

                            
                            break;
                        case 1:

                            if ((ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)) == 65535)
                            {
                                textBox28.Text = "-1";
                            }
                            else
                            {
                                textBox28.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            }
                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:
                 
                            break;
                        case 5:
                            textBox18.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 6:
                    
                            break;
                        case 7:
                            textBox19.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 8:
                     
                            break;
                        case 9:
                            textBox21.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 10:
                  
                            break;
                        case 11:
                   
                            break;
                        case 12:
     
                            break;
                        case 13:
                            textBox57.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 14:
                           // textBox56.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 15:
                           // textBox61.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 16:
                           // textBox60.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 17:
                           // textBox59.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 18:
                            //textBox85.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 19:
                           // textBox84.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 20:
                           // textBox83.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 21:
                           // textBox82.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 22:
                          //  textBox81.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 23:
                           // textBox80.Text = (ReceiveBuffer[5] + (ReceiveBuffer[6] << 8)).ToString();
                            break;
                        case 24:
                          
                            break;
                        case 25:
                           
                            break;
                        case 26:
                           
                            break;
                        case 27:

                          
                            break;
                        case 28:
                            
                            break;
                        case 29:
                          
                            break;
                        case 30:
              
                            break;
                        case 31:
                  
                            break;
                        case 32:
                       
                            break;
                        case 33:
                            
                            break;
                        case 34:
                           
                            break;
                        case 35:
                      
                            break;
                        case 36:
                           
                            break;
                        case 37:
                          
                            break;
                        case 38:
                           
                            break;
                        case 39:
                          
                            break;
                        case 40:
                            
                            break;
                        case 41:
                           
                            break;
                        case 42:

                            break;
                        case 43:

                            break;
                        default:

                            break;
                    }
                    break;
                default:
                    break;

            }
            ReceiveBuffer[0] = 0;
            ReceiveBuffer[1] = 0;
            ReceiveBuffer[2] = 0;
            ReceiveBuffer[3] = 0;
            ReceiveBuffer[4] = 0;
            ReceiveBuffer[5] = 0;
            ReceiveBuffer[6] = 0;
            ReceiveBuffer[7] = 0;
            ReceiveBuffer[8] = 0;

        }

        unsafe private void button1_Click(object sender, EventArgs e)
        {
            string strNum;
            string strNumAdr;
            string strNumRAW;
            int age;
            VCI_CAN_OBJ sendFrame1 = new VCI_CAN_OBJ();
            sendFrame1.SendType = 0x0;                  //正常发送
            sendFrame1.RemoteFlag = 0x0;                //数据帧
            sendFrame1.ExternFlag = 0x1;                //正常帧
            sendFrame1.DataLen = 8;
            sendFrame1.ID = 0x18FF7320;



                    sendFrame1.Data[0] = 0;
                    sendFrame1.Data[1] = 1;
                    strNum = textBox6.Text;
                    age = int.Parse(strNum);
                    sendFrame1.Data[4] = (byte)(age&0xff);
                    sendFrame1.Data[5] = (byte)((age>>8) & 0xff);
                    sendFrame1.Data[3] = 0;
                    sendFrame1.Data[6] = 0;
                    sendFrame1.Data[7] = 0;
                    strNumAdr = comboBox6.Text;
                    switch (strNumAdr)

                    {
                        case "CompForceCtrl":
                            sendFrame1.Data[2] = 0;
                            break;
                        case "ExvForceCtrl":
                            sendFrame1.Data[2] = 1;
                            break;
                        case "PumpForceCtrl":
                            sendFrame1.Data[2] = 2;
                            break;
                        case "FanForceCtrl":
                            sendFrame1.Data[2] = 3;
                            break;
                        case "CompInitTim":
                            sendFrame1.Data[2] = 4;
                            break;
                        case "ExvInitTim":
                            sendFrame1.Data[2] = 5;
                            break;
                        case "CompInitVal":
                            sendFrame1.Data[2] = 6;
                            break;
                        case "ExvInitVal":
                            sendFrame1.Data[2] = 7;
                            break;
                        case "ComChgTim":
                            sendFrame1.Data[2] = 8;
                            break;
                        case "ExvChgTim":
                            sendFrame1.Data[2] = 9;
                            break;
                        case "ComOffTim":
                            sendFrame1.Data[2] = 10;
                            break;
                        case "PIDCompKp":
                            sendFrame1.Data[2] = 11;
                            break;
                        case "PIDCompKi":
                            sendFrame1.Data[2] = 12;
                            break;
                        case "PtTarTsh":
                            sendFrame1.Data[2] = 13;
                            break;
                        case "Ed1":
                            sendFrame1.Data[2] = 14;
                            break;
                        case "Ed2":
                            sendFrame1.Data[2] = 15;
                            break;
                        case "Ed3":
                            sendFrame1.Data[2] = 16;
                            break;
                        case "Ed4":
                            sendFrame1.Data[2] = 17;
                            break;
                        case "Fd1":
                            sendFrame1.Data[2] = 18;
                            break;
                        case "Fd2":
                            sendFrame1.Data[2] = 19;
                            break;
                        case "FanChgTim":
                            sendFrame1.Data[2] = 20;
                            break;
                        case "PumpSpeed1":
                            sendFrame1.Data[2] = 21;
                            break;
                        case "PumpSpeed2":
                            sendFrame1.Data[2] = 22;
                            break;
                        case "PumpSpeed3":
                            sendFrame1.Data[2] = 23;
                            break;
                        case "PumpSpeed4":
                            sendFrame1.Data[2] = 24;
                            break;
                        case "PumpSpeed5":
                            sendFrame1.Data[2] = 25;
                            break;
                        case "Wt1":
                            sendFrame1.Data[2] = 26;
                            break;
                        case "Wt2":
                            sendFrame1.Data[2] = 27;
                            break;
                        case "Wt3":
                            sendFrame1.Data[2] = 28;
                            break;
                        case "Bt1":
                            sendFrame1.Data[2] = 29;
                            break;
                        case "Bt2":
                            sendFrame1.Data[2] = 30;
                            break;
                        case "FanSpdMax":
                            sendFrame1.Data[2] = 31;
                            break;
                        case "FanInitSpd":
                            sendFrame1.Data[2] = 32;
                            break;
                        case "CompSpdMin":
                            sendFrame1.Data[2] = 33;
                            break;
                        case "CompSpdMax":
                            sendFrame1.Data[2] = 34;
                            break;
                        case "CompHPdecTim":
                            sendFrame1.Data[2] = 35;
                            break;
                        case "CompOnLps":
                            sendFrame1.Data[2] = 36;
                            break;
                        case "CompOnHps":
                            sendFrame1.Data[2] = 37;
                            break;
                        case "CompChgCoef":
                            sendFrame1.Data[2] = 38;
                            break;
                        case "CompOffWtemp":
                            sendFrame1.Data[2] = 39;
                            break;
                        case "ExvOnMax":
                            sendFrame1.Data[2] = 40;
                            break;
                        case "ExvOnMin":
                            sendFrame1.Data[2] = 41;
                            break;
                        case "FanOffTim":
                            sendFrame1.Data[2] = 42;
                            break;
                        case "PumpOffTim":
                            sendFrame1.Data[2] = 43;
                            break;
                        default:
                                    break;

                    }

            string frame1SendStr = "TX  " + DateTime.Now.TimeOfDay.ToString() + ": " + " ID:0x" + System.Convert.ToString((Int32)sendFrame1.ID, 16) + "   ";

            for (int i = 0; i < 8; i++)
            {
                frame1SendStr += "  " + System.Convert.ToString((Int32)sendFrame1.Data[i], 16).PadLeft(2, '0');
            }

            int nTimeOut = 3000;
            SetTransmitTimeout(nTimeOut);
            if (TransmitFrame(ref sendFrame1) == 1)
            {


            }

        }

        unsafe private void button3_Click(object sender, EventArgs e)
        {
            VCI_CAN_OBJ sendFrame1 = new VCI_CAN_OBJ();
            sendFrame1.SendType = 0x0;                  //正常发送
            sendFrame1.RemoteFlag = 0x0;                //数据帧
            sendFrame1.ExternFlag = 0x1;                //正常帧
            sendFrame1.DataLen = 8;
            sendFrame1.ID = 0x18FF7320;

            sendFrame1.Data[0] = 0;
            sendFrame1.Data[1] = 2;
            sendFrame1.Data[3] = 0;
            sendFrame1.Data[5] = 0;
            sendFrame1.Data[6] = 0;
            sendFrame1.Data[7] = 0;
            sendFrame1.Data[1] = 3;
            sendFrame1.Data[2] = 3;


            string frame1SendStr = "TX  " + DateTime.Now.TimeOfDay.ToString() + ": " + " ID:0x" + System.Convert.ToString((Int32)sendFrame1.ID, 16) + "   ";

            for (int i = 0; i < 8; i++)
            {
                frame1SendStr += "  " + System.Convert.ToString((Int32)sendFrame1.Data[i], 16).PadLeft(2, '0');
            }

            int nTimeOut = 3000;
            SetTransmitTimeout(nTimeOut);
            if (TransmitFrame(ref sendFrame1) == 1)
            {


            }
        }

        unsafe private void button2_Click(object sender, EventArgs e)
        {
            string strNum;
            string strNumAdr;
            string strNumRAW;
            int age;
            VCI_CAN_OBJ sendFrame1 = new VCI_CAN_OBJ();
            sendFrame1.SendType = 0x0;                  //正常发送
            sendFrame1.RemoteFlag = 0x0;                //数据帧
            sendFrame1.ExternFlag = 0x1;                //正常帧
            sendFrame1.DataLen = 8;
            sendFrame1.ID = 0x18FF7320;
            strNumAdr = comboBox6.Text;
            switch (strNumAdr)

            {
                case "CompForceCtrl":
                    sendFrame1.Data[2] = 0;
                    break;
                case "ExvForceCtrl":
                    sendFrame1.Data[2] = 1;
                    break;
                case "PumpForceCtrl":
                    sendFrame1.Data[2] = 2;
                    break;
                case "FanForceCtrl":
                    sendFrame1.Data[2] = 3;
                    break;
                case "CompInitTim":
                    sendFrame1.Data[2] = 4;
                    break;
                case "ExvInitTim":
                    sendFrame1.Data[2] = 5;
                    break;
                case "CompInitVal":
                    sendFrame1.Data[2] = 6;
                    break;
                case "ExvInitVal":
                    sendFrame1.Data[2] = 7;
                    break;
                case "ComChgTim":
                    sendFrame1.Data[2] = 8;
                    break;
                case "ExvChgTim":
                    sendFrame1.Data[2] = 9;
                    break;
                case "ComOffTim":
                    sendFrame1.Data[2] = 10;
                    break;
                case "PIDCompKp":
                    sendFrame1.Data[2] = 11;
                    break;
                case "PIDCompKi":
                    sendFrame1.Data[2] = 12;
                    break;
                case "PtTarTsh":
                    sendFrame1.Data[2] = 13;
                    break;
                case "Ed1":
                    sendFrame1.Data[2] = 14;
                    break;
                case "Ed2":
                    sendFrame1.Data[2] = 15;
                    break;
                case "Ed3":
                    sendFrame1.Data[2] = 16;
                    break;
                case "Ed4":
                    sendFrame1.Data[2] = 17;
                    break;
                case "Fd1":
                    sendFrame1.Data[2] = 18;
                    break;
                case "Fd2":
                    sendFrame1.Data[2] = 19;
                    break;
                case "FanChgTim":
                    sendFrame1.Data[2] = 20;
                    break;
                case "PumpSpeed1":
                    sendFrame1.Data[2] = 21;
                    break;
                case "PumpSpeed2":
                    sendFrame1.Data[2] = 22;
                    break;
                case "PumpSpeed3":
                    sendFrame1.Data[2] = 23;
                    break;
                case "PumpSpeed4":
                    sendFrame1.Data[2] = 24;
                    break;
                case "PumpSpeed5":
                    sendFrame1.Data[2] = 25;
                    break;
                case "Wt1":
                    sendFrame1.Data[2] = 26;
                    break;
                case "Wt2":
                    sendFrame1.Data[2] = 27;
                    break;
                case "Wt3":
                    sendFrame1.Data[2] = 28;
                    break;
                case "Bt1":
                    sendFrame1.Data[2] = 29;
                    break;
                case "Bt2":
                    sendFrame1.Data[2] = 30;
                    break;
                case "FanSpdMax":
                    sendFrame1.Data[2] = 31;
                    break;
                case "FanInitSpd":
                    sendFrame1.Data[2] = 32;
                    break;
                case "CompSpdMin":
                    sendFrame1.Data[2] = 33;
                    break;
                case "CompSpdMax":
                    sendFrame1.Data[2] = 34;
                    break;
                case "CompHPdecTim":
                    sendFrame1.Data[2] = 35;
                    break;
                case "CompOnLps":
                    sendFrame1.Data[2] = 36;
                    break;
                case "CompOnHps":
                    sendFrame1.Data[2] = 37;
                    break;
                case "CompChgCoef":
                    sendFrame1.Data[2] = 38;
                    break;
                case "CompOffWtemp":
                    sendFrame1.Data[2] = 39;
                    break;
                case "ExvOnMax":
                    sendFrame1.Data[2] = 40;
                    break;
                case "ExvOnMin":
                    sendFrame1.Data[2] = 41;
                    break;
                case "FanOffTim":
                    sendFrame1.Data[2] = 42;
                    break;
                case "PumpOffTim":
                    sendFrame1.Data[2] = 43;
                    break;
                default:
                    break;

            }
            sendFrame1.Data[0] = 0;
            sendFrame1.Data[1] = 2;
            sendFrame1.Data[3] = 0;
            sendFrame1.Data[5] = 0;
            sendFrame1.Data[6] = 0;
            sendFrame1.Data[7] = 0;
            string frame1SendStr = "TX  " + DateTime.Now.TimeOfDay.ToString() + ": " + " ID:0x" + System.Convert.ToString((Int32)sendFrame1.ID, 16) + "   ";

            for (int i = 0; i < 8; i++)
            {
                frame1SendStr += "  " + System.Convert.ToString((Int32)sendFrame1.Data[i], 16).PadLeft(2, '0');
            }

            int nTimeOut = 3000;
            SetTransmitTimeout(nTimeOut);
            if (TransmitFrame(ref sendFrame1) == 1)
            {


            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

            // 获取ComboBox控件
            ComboBox comboBox = sender as ComboBox;
            if (comboBox != null)
            {
                // 重置滚动位置到最顶端
                comboBox6.TabIndex = 0;
            }
        
        }

        unsafe private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认执行此操作吗？", "确认", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                VCI_CAN_OBJ sendFrame1 = new VCI_CAN_OBJ();
                sendFrame1.SendType = 0x0;                  //正常发送
                sendFrame1.RemoteFlag = 0x0;                //数据帧
                sendFrame1.ExternFlag = 0x1;                //正常帧
                sendFrame1.DataLen = 8;
                sendFrame1.ID = 0x18FF7320;

                sendFrame1.Data[0] = 0;
                sendFrame1.Data[1] = 4;
                sendFrame1.Data[3] = 0;
                sendFrame1.Data[5] = 0;
                sendFrame1.Data[6] = 0;
                sendFrame1.Data[7] = 0;
                string frame1SendStr = "TX  " + DateTime.Now.TimeOfDay.ToString() + ": " + " ID:0x" + System.Convert.ToString((Int32)sendFrame1.ID, 16) + "   ";

                for (int i = 0; i < 8; i++)
                {
                    frame1SendStr += "  " + System.Convert.ToString((Int32)sendFrame1.Data[i], 16).PadLeft(2, '0');
                }

                int nTimeOut = 3000;
                SetTransmitTimeout(nTimeOut);
                if (TransmitFrame(ref sendFrame1) == 1)
                {


                }
            }
            else
            {
                // 用户点击取消后的逻辑
            }


        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (m_STSEND == 0)
            {
                m_STSEND = 1;
                timerFrame_0x2a5.Enabled = true;
            }
            else
            {
                m_STSEND = 0;
                timerFrame_0x2a5.Enabled = false;
                
            }
            button5.BackColor = m_STSEND == 1 ? System.Drawing.Color.Lime : System.Drawing.Color.LightGray;
        }
    }

}
