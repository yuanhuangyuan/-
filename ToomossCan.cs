using System;
using System.Runtime.InteropServices;

namespace NL_4_Debugger_Test
{
    internal static class ToomossCan
    {
        internal const int Success = 0;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        internal struct CanMessage
        {
            public UInt32 Id;
            public UInt32 TimeStamp;
            public Byte RemoteFlag;
            public Byte ExternFlag;
            public Byte DataLen;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public Byte[] Data;
            public Byte TimeStampHigh;
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct CanInitConfig
        {
            public UInt32 CanBrp;
            public Byte CanSjw;
            public Byte CanBs1;
            public Byte CanBs2;
            public Byte CanMode;
            public Byte CanAbom;
            public Byte CanNart;
            public Byte CanRflm;
            public Byte CanTxfp;
        }

        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 USB_ScanDevice([Out] Int32[] deviceHandles);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool USB_OpenDevice(Int32 deviceHandle);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        [return: MarshalAs(UnmanagedType.I1)]
        internal static extern bool USB_CloseDevice(Int32 deviceHandle);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_GetCANSpeedArg(Int32 deviceHandle, ref CanInitConfig config, UInt32 speedBps);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_Init(Int32 deviceHandle, Byte canIndex, ref CanInitConfig config);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_StartGetMsg(Int32 deviceHandle, Byte canIndex);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_StopGetMsg(Int32 deviceHandle, Byte canIndex);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_Stop(Int32 deviceHandle, Byte canIndex);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_ClearMsg(Int32 deviceHandle, Byte canIndex);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_SendMsg(Int32 deviceHandle, Byte canIndex, [In] CanMessage[] messages, UInt32 count);
        [DllImport("USB2XXX.dll", CallingConvention = CallingConvention.StdCall)]
        internal static extern Int32 CAN_GetMsgWithSize(Int32 deviceHandle, Byte canIndex, IntPtr messages, Int32 bufferSize);
    }
}
