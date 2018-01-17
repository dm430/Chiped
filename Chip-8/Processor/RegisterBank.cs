using System;

namespace Chiped.Processor
{
    internal class RegisterBank : IRegisterBank
    {
        private byte v0;
        private byte v1;
        private byte v2;
        private byte v3;
        private byte v4;
        private byte v5;
        private byte v6;
        private byte v7;
        private byte v8;
        private byte v9;
        private byte vA;
        private byte vB;
        private byte vC;
        private byte vD;
        private byte vE;
        private byte vF;

        private ushort i;
        private ushort programCounter;

        public ushort ProgramCounter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void IncrementProgramCounter()
        {
            throw new NotImplementedException();
        }
    }
}
