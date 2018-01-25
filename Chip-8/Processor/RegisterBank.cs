namespace Chiped.Processor
{
    public class RegisterBank : IRegisterBank
    {
        public byte V0 { get; set; }
        public byte V1 { get; set; }
        public byte V2 { get; set; }
        public byte V3 { get; set; }
        public byte V4 { get; set; }
        public byte V5 { get; set; }
        public byte V6 { get; set; }
        public byte V7 { get; set; }
        public byte V8 { get; set; }
        public byte V9 { get; set; }
        public byte VA { get; set; }
        public byte VB { get; set; }
        public byte VC { get; set; }
        public byte VD { get; set; }
        public byte VE { get; set; }
        public byte VF { get; set; }

        public ushort Address { get; set; }
        public ushort ProgramCounter { get; set; }

        // I should probably create a register abstraction, but ill come back to that.
        public void IncrementProgramCounter(ushort incrementBy = 1)
        {
            ProgramCounter += incrementBy;
        }
    }
}
