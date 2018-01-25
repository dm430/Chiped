namespace Chiped.Instructions
{
    public interface IInstructionSet
    {
        IInstruction GetInstruction(int opcode);
    }
}