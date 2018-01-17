using Chiped.Instructions;
using Chiped.Memory;
using System;

namespace Chiped.Processor
{
    public class CPU
    {
        private readonly IMemory Memory;
        private readonly IRegisterBank RegisterBank;

        public void Tick()
        {
            var opCode = FetchOpcode();
            var instruction = Decode(opCode);
            var opCodeData = new OpCodeData(opCode);

            instruction.Execute(opCodeData, RegisterBank, Memory);
        }

        private IInstruction Decode(ushort opCode)
        {
            throw new NotImplementedException();
        }

        private ushort FetchOpcode()
        {
            var memoryAddress = RegisterBank.ProgramCounter;
            var vaule = Memory.ReadDoubleWord(memoryAddress);

            RegisterBank.IncrementProgramCounter();

            return vaule;
        }
    }
}
