using Chiped.Instructions;
using Chiped.Memory;

namespace Chiped.Processor
{
    public class CentralProcessingUnit
    {
        private const int PorogramStartAddress = 512;

        private readonly IMemory Memory;
        private readonly IRegisterBank RegisterBank;
        private readonly IInstructionSet InstructionSet;

        public CentralProcessingUnit(IMemory memory, IRegisterBank registerBank, IInstructionSet instructionSet)
        {
            Memory = memory;
            RegisterBank = registerBank;
            InstructionSet = instructionSet;
        }

        public void Reset()
        {
            RegisterBank.ProgramCounter = PorogramStartAddress;
            RegisterBank.Address = 0;
            RegisterBank.V0 = 0;
            RegisterBank.V1 = 0;
            RegisterBank.V2 = 0;
            RegisterBank.V3 = 0;
            RegisterBank.V4 = 0;
            RegisterBank.V5 = 0;
            RegisterBank.V6 = 0;
            RegisterBank.V7 = 0;
            RegisterBank.V8 = 0;
            RegisterBank.V9 = 0;
            RegisterBank.VA = 0;
            RegisterBank.VB = 0;
            RegisterBank.VC = 0;
            RegisterBank.VD = 0;
            RegisterBank.VE = 0;
            RegisterBank.VF = 0;
        }

        public void Tick()
        {
            var opCode = FetchOpcode();
            var instruction = Decode(opCode);
            var opCodeData = new OpCodeData(opCode);

            instruction.Execute(opCodeData, RegisterBank, Memory);
        }

        private IInstruction Decode(ushort opCode)
        {
            var opCodeFirstNibble = (opCode & 0xF000) >> 12;
            var instruction = InstructionSet.GetInstruction(opCodeFirstNibble);

            return instruction;
        }

        private ushort FetchOpcode()
        {
            var memoryAddress = RegisterBank.ProgramCounter;
            var vaule = Memory.ReadDoubleWord(memoryAddress);

            RegisterBank.IncrementProgramCounter(2);

            return vaule;
        }
    }
}
