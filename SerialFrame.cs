using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PC_BT
{
    class SerialFrame
    {
        private byte[] frame;

        private const int CMD_INDEX = 0;
        private const int ADDRL_INDEX = 1;
        private const int ADDRH_INDEX = 2;
        private const int ADDRU_INDEX = 3;
        private const int DATA1_INDEX = 4;
        private const int DATA2_INDEX = 5;
        private const int DATA3_INDEX = 6;
        private const int DATA4_INDEX = 7;

        public const int DATA_MAX = 4;

        public byte[] Frame
        {
            get
            {
                return frame;
            }
            set
            {
                frame = value;
            }
        }

        public SerialFrame()
        {
            frame = new byte[8];
            frame[CMD_INDEX] = 0x00;
            frame[ADDRL_INDEX] = 0x00;
            frame[ADDRH_INDEX] = 0x00;
            frame[ADDRU_INDEX] = 0x00;
            frame[DATA1_INDEX] = 0x00;
            frame[DATA2_INDEX] = 0x00;
            frame[DATA3_INDEX] = 0x00;
            frame[DATA4_INDEX] = 0x00;
        }

        public void Default()
        {
            frame[CMD_INDEX] = 0xFF;
            frame[ADDRL_INDEX] = 0xFF;
            frame[ADDRH_INDEX] = 0xFF;
            frame[ADDRU_INDEX] = 0xFF;
            frame[DATA1_INDEX] = 0xFF;
            frame[DATA2_INDEX] = 0xFF;
            frame[DATA3_INDEX] = 0xFF;
            frame[DATA4_INDEX] = 0xFF;
        }

        public int GetAddress(string line)
        {
            const int ADDR_START_INDEX = 3;
            const int ADDR_LENGTH = 4;
            string addr = line.Substring(ADDR_START_INDEX, ADDR_LENGTH);
            return Convert.ToInt32(addr, 16);
        }

        public int GetDataLength(string line)
        {
            const int DATA_LENGTH_START_INDEX = 2;
            const int LENGTH_OF_DATA_LENGTH = 2;
            string len = line.Substring(DATA_LENGTH_START_INDEX, LENGTH_OF_DATA_LENGTH);
            return Convert.ToInt32(len, 16);
        }

        public void InsertCommand(byte b)
        {
            frame[CMD_INDEX] = b;
        }

        public void InsertAddress(string line, int addBase)
        {
            int address = GetAddress(line);
            address += addBase;
            frame[ADDRL_INDEX] = (byte)(address & 0xFF);
            frame[ADDRH_INDEX] = (byte)((address & 0xFFFF) >> 8);
            frame[ADDRU_INDEX] = (byte)(address >> 16);
        }

        public void InsertAddress(int startAddress)
        {
            frame[ADDRL_INDEX] = (byte)(startAddress & 0xFF);
            frame[ADDRH_INDEX] = (byte)((startAddress & 0xFFFF) >> 8);
            frame[ADDRU_INDEX] = (byte)(startAddress >> 16);
        }

        public void InsertLength(string line)
        {
            int length = GetDataLength(line);
            frame[CMD_INDEX + 1] = (byte)length;
        }

        public byte GetByteData(string line, int idx)
        {
            const int DATA_START_INDEX = 9;
            const int HEX_BYTE_LENGTH = 2;
            int dataLength = GetDataLength(line);
            string data = line.Substring(DATA_START_INDEX, dataLength * 2);
            string hex = data.Substring(idx, HEX_BYTE_LENGTH);
            return (Convert.ToByte(hex, 16));
        }

        public void InsertData(string line)
        {
            const int DATA_START_INDEX = 9;
            const int HEX_BYTE_LENGTH = 2;
            int dataLength = GetDataLength(line);
            string data = line.Substring(DATA_START_INDEX, dataLength * 2);
            for (int i = 0; i < dataLength; i++)
            {
                string hex = data.Substring(HEX_BYTE_LENGTH * i, HEX_BYTE_LENGTH);
                frame[CMD_INDEX + 1 + i] = Convert.ToByte(hex, 16);
            }
        }


        public void InsertData(byte b1, byte b2, byte b3, byte b4)
        {
            frame[DATA1_INDEX] = b1;
            frame[DATA2_INDEX] = b2;
            frame[DATA3_INDEX] = b3;
            frame[DATA4_INDEX] = b4;
        }

        public override string ToString()
        {
            string bytes = "";
            foreach (byte b in frame)
            {
                bytes += "0x" + b.ToString("X2") + " ";
            }
            return bytes;
        }
        public byte GetS1Data(string line, int idx) 
        {
            const int DATA_START_INDEX = 8;
            const int HEX_BYTE_LENGTH = 2;
            int dataLength = GetDataLength(line);
            string data = line.Substring(DATA_START_INDEX, (dataLength - 3) * 2);
            string hex = data.Substring(idx, HEX_BYTE_LENGTH);
            return (Convert.ToByte(hex, 16));
        }

        public byte GetS2Data(string line, int idx)
        {
            const int DATA_START_INDEX = 10;
            const int HEX_BYTE_LENGTH = 2;
            int dataLength = GetDataLength(line);
            string data = line.Substring(DATA_START_INDEX, (dataLength - 4) * 2);
            string hex = data.Substring(idx, HEX_BYTE_LENGTH);
            return (Convert.ToByte(hex, 16));
        }
        public byte GetS3Data(string line, int idx)
        {
            const int DATA_START_INDEX = 12;
            const int HEX_BYTE_LENGTH = 2;
            int dataLength = GetDataLength(line);
            string data = line.Substring(DATA_START_INDEX, (dataLength - 5) * 2);
            string hex = data.Substring(idx, HEX_BYTE_LENGTH);
            return (Convert.ToByte(hex, 16));
        }
        public int Get16BitsAddress(string line)
        {
            const int ADDR_START_INDEX = 4;
            const int ADDR_LENGTH = 4;
            string addr = line.Substring(ADDR_START_INDEX, ADDR_LENGTH);
            return Convert.ToInt32(addr, 16);
        }
        public int Get24BitsAddress(string line)
        {
            const int ADDR_START_INDEX = 4;
            const int ADDR_LENGTH = 6;
            string addr = line.Substring(ADDR_START_INDEX, ADDR_LENGTH);
            return Convert.ToInt32(addr, 16);
        }
        public int Get32BitsAddress(string line)
        {
            const int ADDR_START_INDEX = 4;
            const int ADDR_LENGTH = 8;
            string addr = line.Substring(ADDR_START_INDEX, ADDR_LENGTH);
            return Convert.ToInt32(addr, 16);
        }
    }
}
