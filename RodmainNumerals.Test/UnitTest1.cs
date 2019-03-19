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

        //[Fact]
        //public void DoitRetournerUneExceptionSiValeurEgale0()
        //{
        //    //Arrange
        //    var sut = new Converter();

        //    //assert
        //    Assert.Throws<ArgumentOutOfRangeException>(() => sut.Convertir(0));

        //}

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

        [Fact]
        public void DoitRetournerIVPour4()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(4);

            //assert
            result.Should().BeEquivalentTo("IV");

        }

        [Fact]
        public void DoitRetournerLeValeurEntre6Et8()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(6);
            var result7 = sut.Convertir(7);
            var result8 = sut.Convertir(8);

            //assert
            result.Should().BeEquivalentTo("VI");
            result7.Should().BeEquivalentTo("VII");
            result8.Should().BeEquivalentTo("VIII");

        }

        [Fact]
        public void DoitRetournerIXPour9()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(9);

            //assert
            result.Should().BeEquivalentTo("IX");

        }

        [Fact]
        public void DoitRetournerLeValeurEntre11Et13()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(11);
            var result7 = sut.Convertir(12);
            var result8 = sut.Convertir(13);

            //assert
            result.Should().BeEquivalentTo("XI");
            result7.Should().BeEquivalentTo("XII");
            result8.Should().BeEquivalentTo("XIII");

        }

        [Fact]
        public void DoitRetournerXIVPour14()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(14);

            //assert
            result.Should().BeEquivalentTo("XIV");

        }

        [Fact]
        public void DoitRetournerXVPour15()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(15);

            //assert
            result.Should().BeEquivalentTo("XV");

        }

        [Fact]
        public void DoitRetournerXXPour20()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(20);

            //assert
            result.Should().BeEquivalentTo("XX");

        }
        [Fact]
        public void DoitRetournerXXIXPour29()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(29);

            //assert
            result.Should().BeEquivalentTo("XXIX");

        }
        [Fact]
        public void DoitRetournerXLIXPour49()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(49);

            //assert
            result.Should().BeEquivalentTo("XLIX");

        }

        [Fact]
        public void DoitRetournerLPour50()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(50);

            //assert
            result.Should().BeEquivalentTo("L");

        }

        [Fact]
        public void DoitRetournerLXIXPour69()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(69);

            //assert
            result.Should().BeEquivalentTo("LXIX");

        }

        [Fact]
        public void DoitRetournerXCVIIIPour98()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(90);

            //assert
            result.Should().BeEquivalentTo("XC");

        }

        [Fact]
        public void DoitRetournerCDXLVIIIPour448()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(448);

            //assert
            result.Should().BeEquivalentTo("CDXLVIII");

        }

        [Fact]
        public void DoitRetournerDLXXIXPour579()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(579);

            //assert
            result.Should().BeEquivalentTo("DLXXIX");

        }

        [Fact]
        public void DoitRetournerCMLXXXVIIIPour988()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(988);

            //assert
            result.Should().BeEquivalentTo("CMLXXXVIII");

        }

        [Fact]
        public void DoitRetournerMCDLXVIPour1456()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(1466);

            //assert
            result.Should().BeEquivalentTo("MCDLXVI");

        }

        [Fact]
        public void DoitRetournerMMCMXCIXPour2999()
        {
            //Arrange
            var sut = new Converter();

            //Act
            var result = sut.Convertir(2999);

            //assert
            result.Should().BeEquivalentTo("MMCMXCIX");

        }
    }
}
