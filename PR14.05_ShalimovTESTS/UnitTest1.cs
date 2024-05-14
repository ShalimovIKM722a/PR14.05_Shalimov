using PR14._05_Shalimov;

namespace PR14._05_ShalimovTESTS
{
    public class UnitTest1
    {


        [Theory]
        [InlineData(3, 6)]
        public void TestFactorial(int input, int expected)
        {
            //Arrange


            //Act
            int result = Functions.Factorial(input);

            //Assert
            Assert.Equal(expected, result);

        }

        [Theory]
        [InlineData(11, false)]
        public void TestParity5(int input, bool expected)
        {
            //Arrange


            //Act
            bool result1 = Functions.Parity(input);


            //Assert
            Assert.Equal(expected, result1);

        }

        [Theory]
        [InlineData(22, true)]
        public void TestParity2(int input, bool expected)
        {
            //Arrange


            //Act
            bool result1 = Functions.Parity(input);


            //Assert
            Assert.Equal(expected, result1);

        }


        [Theory]
        [InlineData(new int[] {45,80,3,13,15}, 80)]
        public void TestMaxNumber(int[] input, int expected)
        {
            //Arrange 


            //Act
            int result1 = Functions.MaxNumber(input);


            //Assert
            Assert.Equal(expected, result1);

        }

        [Theory]
        [InlineData("Привіт,"," Петро", "Привіт, Петро")]
        public void SumString(string str1, string str2, string strResult)
        {
            //Arrange 

            //Act
            string result1 = Functions.SumString(str1,str2);

            //Assert
            Assert.Equal(strResult, result1);

        }

        [Theory]
        [InlineData(new double[] { 45, 80, 3, 13, 15 }, 80 ,true)]
        [InlineData(new double[] { 45, 80, 3, 13, 15 }, 12, false)]
        public void TestNumberInList(double[] input, double num,bool expected)
        {
            //Arrange 

            //Act
            bool result1 = Functions.NumberInList(input, num);

            //Assert
            Assert.Equal(expected, result1);

        }

        [Theory]
        [InlineData(101101,true)]
        public void TestPolindrom(int input, bool expected)
        {
            //Arrange 

            //Act
            bool result1 = Functions.AverageNumber(input);

            //Assert
            Assert.Equal(expected, result1);

        }

        [Theory]
        [InlineData(new double[] { 45, 80, 3, 13, 15 }, 31.2)]
        public void TestAverage(double[] input, double expected)
        {
            //Arrange 

            //Act
            double result1 = Functions.AverageNumber(input);

            //Assert
            Assert.Equal(expected, result1);

        }



    }
}