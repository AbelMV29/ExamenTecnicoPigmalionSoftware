namespace ExamenTecnico.Test
{
    public class ProgramTest
    {
        [Theory]
        [InlineData(new int[] { 12, 15, 2, 5, 7, 8, 10, 23 }, 13, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 10, false)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0, true)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8, true)]
        [InlineData(new int[] { 100, 200, 300, 400 }, 700, true)]
        [InlineData(new int[] { 10, 20, 30, 40 }, 100, false)]
        [InlineData(new int[] { 5 }, 5, false)]
        [InlineData(new int[] { }, 10, false)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 11, true)]
        public void EfficientFindTheSumInArray_ShouldBeReturnSuccesfully(int[] nums, int requiredSum, bool expectedResult)
        {
            //Act
            bool result = Program.EfficientFindTheSumInArray(nums, requiredSum);

            //Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(new int[] { 12, 15, 2, 5, 7, 8, 10, 23 }, 13, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9, true)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 10, false)]
        [InlineData(new int[] { 0, 0, 0, 0 }, 0, true)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, -8, true)]
        [InlineData(new int[] { 100, 200, 300, 400 }, 700, true)]
        [InlineData(new int[] { 10, 20, 30, 40 }, 100, false)]
        [InlineData(new int[] { 5 }, 5, false)]
        [InlineData(new int[] { }, 10, false)]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 11, true)]
        public void InefficientFindTheSumInArray_ShouldBeReturnSuccesfully(int[] nums, int requiredSum, bool expectedResult)
        {
            //Act
            bool result = Program.InefficientFindTheSumInArray(nums, requiredSum);

            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}