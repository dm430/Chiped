namespace Chiped.Memory
{
    internal interface IMemory
    {
        void LoadToMemory(ushort address, byte[] data);
        void WriteWord(ushort address, byte value);
        byte ReadWord(ushort address);
        ushort ReadDoubleWord(ushort address);
    }
}