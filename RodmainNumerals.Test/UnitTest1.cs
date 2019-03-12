using FluentAssertions;
using System;
using Xunit;

namespace RomainNumerals.Test
{

    public class UnitTest1
    {
        [Fact]
        public void DoitLeverExceptionSilEntreeSuperieur3000()
        {
            //Arrange
            var sut = new Converter();

            //Act
            try
            {
                sut.Convertir(3001);
            }
            catch (ArgumentOutOfRangeException)
            {
                //Assert
                return;
            }

            Assert.False(true, "Exception n'est pas un argumentexception");

        }
        [Fact]
        public void DoitRetournerIpour1()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(1);

            //assert
            result.Should().BeEquivalentTo("I");
        }

        [Fact]
        public void DoitRetournerVPour5()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(5);

            //assert
            result.Should().BeEquivalentTo("V");

        }
        [Fact]
        public void DoitRetournerXPour10()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(10);

            //assert
            result.Should().BeEquivalentTo("X");

        }
        [Fact]
        public void DoitRetournerCPour100()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(100);

            //assert
            result.Should().BeEquivalentTo("C");

        }

        [Fact]
        public void DoitRetournerUneExceptionSiValeurEgale0()
        {
            //Arrange
            var sut = new Converter();

            //assert
            Assert.Throws<ArgumentOutOfRangeException>(() => sut.Convertir(0));

        }

        [Fact]
        public void DoitRetournerIIPour2()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(2);

            //assert
            result.Should().BeEquivalentTo("II");

        }

    }
}
