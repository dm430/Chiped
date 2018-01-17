using System;

namespace Chiped.Memory
{
    internal class Memory : IMemory
    {
        public void LoadToMemory(ushort address, byte[] data)
        {
            throw new NotImplementedException();
        }

        public ushort ReadDoubleWord(ushort address)
        {
            throw new NotImplementedException();
        }

        public byte ReadWord(ushort address)
        {
            throw new NotImplementedException();
        }

        public void WriteWord(ushort address, byte value)
        {
            throw new NotImplementedException();
        }
    }
}
