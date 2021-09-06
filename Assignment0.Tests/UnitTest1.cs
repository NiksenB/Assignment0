using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void test_true_isLeapYear_2020()
        {
            //Arrange
            var input = 2020;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void test_true_isLeapYear_44bc()
        {
            //Arrange
            var input = -44;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void test_false_isLeapYear_2019()
        {
            //Arrange
            var input = 2019;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void test_false_isLeapYear_2100()
        {
            //Arrange
            var input = 2100;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void test_true_isLeapYear_2400()
        {
            //Arrange
            var input = 2400;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(true, output);
        }
        


        [Fact]
        public void test_main_true_isLeapYear_2020()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            var input = new StringReader("2020");
            Console.SetIn(input);
            
            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("yay", output);
        }

        [Fact]
        public void test_main_true_isLeapYear_44bc()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            var input = new StringReader("-44");
            Console.SetIn(input);
            
            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("yay", output);
        }

        [Fact]
        public void test_main_false_isLeapYear_2019()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            var input = new StringReader("2019");
            Console.SetIn(input);
            
            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("nay", output);
        }

        [Fact]
        public void test_main_false_isLeapYear_2100()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            var input = new StringReader("2100");
            Console.SetIn(input);
            
            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("nay", output);
        }

        [Fact]
        public void test_main_true_isLeapYear_2400()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            var input = new StringReader("2400");
            Console.SetIn(input);
            
            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            Assert.Equal("yay", output);
        }
        
    }
}
