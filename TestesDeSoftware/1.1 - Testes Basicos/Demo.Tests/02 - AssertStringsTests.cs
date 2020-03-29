using Xunit;

namespace Demo.Tests
{
    public class AssertStringsTests
    {
        [Fact]
        public void StringsTools_UnirNomes_RetornarNomeCompleto()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Rodrigo", "Galante");

            // Assert
            Assert.Equal("Rodrigo Galante", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveIgnorarCase()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Rodrigo", "Galante");

            // Assert
            Assert.Equal("RODRIGO GALANTE", nomeCompleto, true);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveConterTrecho()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Rodrigo", "Galante");

            // Assert
            Assert.Contains("drig", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveComecarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Rodrigo", "Galante");

            // Assert
            Assert.StartsWith("Rod", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_DeveAcabarCom()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Rodrigo", "Galante");

            // Assert
            Assert.EndsWith("nte", nomeCompleto);
        }

        [Fact]
        public void StringsTools_UnirNomes_ValidarExpressaoRegular()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var nomeCompleto = sut.Unir("Rodrigo", "Galante");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}