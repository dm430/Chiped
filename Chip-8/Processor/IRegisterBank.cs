namespace Chiped.Processor
{
    public interface IRegisterBank
    {
        byte V0 { get; set; }

        byte V1 { get; set; }

        byte V2 { get; set; }

        byte V3 { get; set; }

        byte V4 { get; set; }

        byte V5 { get; set; }

        byte V6 { get; set; }

        byte V7 { get; set; }

        byte V8 { get; set; }

        byte V9 { get; set; }

        byte VA { get; set; }

        byte VB { get; set; }

        byte VC { get; set; }

        byte VD { get; set; }

        byte VE { get; set; }

        byte VF { get; set; }

        ushort Address { get; set; }

        ushort ProgramCounter { get; set; }

        void IncrementProgramCounter(ushort incrermentBy = 1);
    }
}