namespace Chiped.Memory
{
    internal class Memory : IMemory
    {
        private readonly byte[] AddressSpace;

        public Memory()
        {
            AddressSpace = new byte[4096];
        }

        public void LoadToMemory(ushort address, byte[] data)
        {
            data.CopyTo(AddressSpace, address);
        }

        public ushort ReadDoubleWord(ushort address)
        {
            var highByte = AddressSpace[address];
            var lowByte = AddressSpace[address + 1];
            var value = (ushort) ((highByte << 4) | lowByte);

            return value;
        }

        public byte ReadWord(ushort address)
        {
            return AddressSpace[address];
        }

        public void WriteWord(ushort address, byte value)
        {
            AddressSpace[address] = value;
        }
    }
}
