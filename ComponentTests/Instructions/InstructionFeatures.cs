using Xunit;

namespace ComponentTests.Instructions
{
    public class InstructionFeatures
    {
        private readonly InstructionSteps InstructionSteps;

        public InstructionFeatures()
        {
            InstructionSteps = new InstructionSteps();
        }

        [Theory]
        [InlineData(0x0F00, 0xF)]
        [InlineData(0x0A00, 0xA)]
        [InlineData(0x0100, 0x1)]
        [InlineData(0x0000, 0x0)]
        [InlineData(0x0DA0, 0xD)]
        [InlineData(0xCB00, 0xB)]
        public void OpcodeDataXReturnsCorrectValue(ushort opCodeRaw, byte expectedValue)
        {
            InstructionSteps.GivenThatIHaveAnOpcodeData(opCodeRaw);
            InstructionSteps.ThenICanVerifyThatOpCodeDataXValueEquals(expectedValue);
        }

        [Theory]
        [InlineData(0x00F0, 0xF)]
        [InlineData(0x00A0, 0xA)]
        [InlineData(0x0010, 0x1)]
        [InlineData(0x0000, 0x0)]
        [InlineData(0x00DA, 0xD)]
        [InlineData(0x0CB0, 0xB)]
        public void OpcodeDataYReturnsCorrectValue(ushort opCodeRaw, byte expectedValue)
        {
            InstructionSteps.GivenThatIHaveAnOpcodeData(opCodeRaw);
            InstructionSteps.ThenICanVerifyThatOpCodeDataYValueEquals(expectedValue);
        }

        [Theory]
        [InlineData(0x000F, 0xF)]
        [InlineData(0x000A, 0xA)]
        [InlineData(0x0001, 0x1)]
        [InlineData(0x0000, 0x0)]
        [InlineData(0x00AD, 0xD)]
        [InlineData(0x00CB, 0xB)]
        public void OpcodeDataNReturnsCorrectValue(ushort opCodeRaw, byte expectedValue)
        {
            InstructionSteps.GivenThatIHaveAnOpcodeData(opCodeRaw);
            InstructionSteps.ThenICanVerifyThatOpCodeDataNValueEquals(expectedValue);
        }

        [Theory]
        [InlineData(0x00FF, 0xFF)]
        [InlineData(0x00AB, 0xAB)]
        [InlineData(0x0010, 0x10)]
        [InlineData(0x0000, 0x0)]
        [InlineData(0x0BAD, 0xAD)]
        [InlineData(0x0C5B, 0x5B)]
        public void OpcodeDataNNReturnsCorrectValue(ushort opCodeRaw, byte expectedValue)
        {
            InstructionSteps.GivenThatIHaveAnOpcodeData(opCodeRaw);
            InstructionSteps.ThenICanVerifyThatOpCodeDataNNValueEquals(expectedValue);
        }

        [Theory]
        [InlineData(0x0FFF, 0xFFF)]
        [InlineData(0x0DAB, 0xDAB)]
        [InlineData(0x0101, 0x101)]
        [InlineData(0x0000, 0x0)]
        [InlineData(0x0BAD, 0xBAD)]
        [InlineData(0xAC5B, 0xC5B)]
        public void OpcodeDataNNNReturnsCorrectValue(ushort opCodeRaw, ushort expectedValue)
        {
            InstructionSteps.GivenThatIHaveAnOpcodeData(opCodeRaw);
            InstructionSteps.ThenICanVerifyThatOpCodeDataNNNValueEquals(expectedValue);
        }
    }
}
