using Chiped.Memory;
using Chiped.Processor;

namespace Chiped.Instructions
{
    internal interface IInstruction
    {
        void Execute(OpCodeData data, IRegisterBank registerBank, IMemory memory);
    }
}
