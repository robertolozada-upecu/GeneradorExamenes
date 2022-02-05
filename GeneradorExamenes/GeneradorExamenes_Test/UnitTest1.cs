using FluentAssertions;
using Xunit;

namespace GeneradorExamenes_Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(true, true, "Correcto")]
        [InlineData(false, false, "Correcto")]
        [InlineData(true, false, "Incorrecto")]
        [InlineData(false, true, "Incorrecto")]
        public void DeberiaDevolverBoleanoCuandoEnvioSeleccionUsuario(bool SeleccionUsuario, bool OpcionCorrecta, string ResultadoEsperado)
        {
            //Arrenge

            //Act
            var resulto = EvaluacionRespuesta.Evaluar(SeleccionUsuario, OpcionCorrecta);

            //Assert
            resulto.Should().Be(ResultadoEsperado);
        }
    }
}