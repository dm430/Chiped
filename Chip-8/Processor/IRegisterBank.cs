namespace Chiped.Processor
{
    internal interface IRegisterBank
    {
        ushort ProgramCounter { get; set; }

        void IncrementProgramCounter();
    }
}