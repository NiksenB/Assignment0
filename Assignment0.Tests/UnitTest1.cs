using System;
using System.IO;
using Xunit;

namespace Assignment0.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void isLeapYear_2020_true()
        {
            //Arrange
            var input = 2020;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(true, output);
        }

        [Fact]
        public void isLeapYear_2019_false()
        {
            //Arrange
            var input = 2019;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void isLeapYear_2100_false()
        {
            //Arrange
            var input = 2100;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(false, output);
        }

        [Fact]
        public void isLeapYear_2400_true()
        {
            //Arrange
            var input = 2400;
            
            //Act
            var output = Program.IsLeapYear(input);

            //Assert
            Assert.Equal(true, output);
        }
        


        [Fact]
        public void isLeapYear_main_2020_true()
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
        public void isLeapYear_main_2019_false()
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
        public void isLeapYear_main_2100_false()
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
        public void isLeapYear_main_2400_true()
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
        
        [Fact]
        public void isLeapYear_main_1581_throwsInvalidInputException()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = new StringReader("1581");
            Console.SetIn(input);
            
            //Act
            Action action = () => 
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            var caughtException = Assert.Throws<InvalidInputException>(action);
            Assert.Equal("The year 1581 is too soon!", caughtException.Message);
        }

                [Fact]
        public void isLeapYear_main_44bc_throwsInvalidInputException()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = new StringReader("-44");
            Console.SetIn(input);
            
            //Act
            Action action = () => 
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            //Assert
            var caughtException = Assert.Throws<InvalidInputException>(action);
            Assert.Equal("The year -44 is too soon!", caughtException.Message);
        }

        [Fact]
        public void isLeapYear_main_string_catchesFormatException()
        {
            //Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            var input = new StringReader("text");
            Console.SetIn(input);

            //Act
            Program.Main(new string[0]);
            var output = writer.GetStringBuilder().ToString().Trim();

            // Assert
            Assert.Equal("Exception! Please write a number...", output);
        }

        //[Fact]
        // public void isLeapYear_main_string_throwsFormatException()
        // {
        //     // Arrange
        //     var writer = new StringWriter();
        //     Console.SetOut(writer);
        //     var input = new StringReader("text");
        //     Console.SetIn(input);

        //     // Act
        //     Action action = () => Program.Main(new string[0]); 
        //     var output = writer.GetStringBuilder().ToString().Trim();

        //     // Assert
        //     var caughtException = Assert.Throws<FormatException>(action);
        //     Assert.Equal("Exception! Please write a number...", caughtException.Message);
        // }
    }
}
