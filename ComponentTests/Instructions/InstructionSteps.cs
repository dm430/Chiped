using System;
using Chiped.Instructions;
using Xunit;

namespace ComponentTests.Instructions
{
    internal class InstructionSteps
    {
        private OpCodeData opCodeData;

        internal void GivenThatIHaveAnOpcodeData(ushort opCodeRaw)
        {
            opCodeData = new OpCodeData(opCodeRaw);
        }

        internal void ThenICanVerifyThatOpCodeDataXValueEquals(byte expectedXValue)
        {
            Assert.Equal(expectedXValue, opCodeData.X);
        }

        internal void ThenICanVerifyThatOpCodeDataYValueEquals(byte expectedValue)
        {
            Assert.Equal(expectedValue, opCodeData.Y);
        }

        internal void ThenICanVerifyThatOpCodeDataNValueEquals(byte expectedValue)
        {
            Assert.Equal(expectedValue, opCodeData.N);
        }

        internal void ThenICanVerifyThatOpCodeDataNNValueEquals(byte expectedValue)
        {
            Assert.Equal(expectedValue, opCodeData.NN);
        }

        internal void ThenICanVerifyThatOpCodeDataNNNValueEquals(ushort expectedValue)
        {
            Assert.Equal(expectedValue, opCodeData.NNN);
        }
    }
}
