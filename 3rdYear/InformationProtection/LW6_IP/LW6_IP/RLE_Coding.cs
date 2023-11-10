using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW6_IP
{
    internal class RLE_Coding
    {
        public byte[] RLE_array = new byte[0];

        public byte[] RLEEncode(byte[] data)
        {
            List<byte> encodedData = new List<byte>();
            for (int i = 0; i < data.Length; i++)
            {
                byte currentByte = data[i];
                int count = 1;
                while (i + 1 < data.Length && data[i + 1] == currentByte && count < 255)
                {
                    count++;
                    i++;
                }
                encodedData.Add((byte)count);
                encodedData.Add(currentByte);
            }
            return encodedData.ToArray();
        }


    }
}
