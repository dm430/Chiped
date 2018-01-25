namespace Chiped.Instructions
{
    public class OpCodeData
    {
        private readonly ushort OpCode;

        public ushort NNN
        {
            get
            {
                return (byte) (OpCode & 0xFFF);
            }
        }

        public byte NN
        {
            get
            {
                return (byte) (OpCode & 0xFF);
            }
        }

        public byte N
        {
            get
            {
                return (byte) (OpCode & 0x000F);
            }
        }

        public byte X
        {
            get
            {
                return (byte) ((OpCode * 0x0F00) >> 8);
            }
        }

        public byte Y
        {
            get
            {
                return (byte) ((OpCode & 0x00F0) >> 4);
            }
        }

        public OpCodeData(ushort opCode)
        {
            OpCode = opCode;
        }
    }
}