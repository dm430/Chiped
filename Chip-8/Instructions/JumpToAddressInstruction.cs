using Chiped.Memory;
using Chiped.Processor;

namespace Chiped.Instructions {
    public class JumpToAddressInstruction : IInstruction 
    {
        public void Execute(OpCodeData data, IRegisterBank registerBank, IMemory memory) 
        {
            registerBank.ProgramCounter = data.NNN;
        }
    }
}
