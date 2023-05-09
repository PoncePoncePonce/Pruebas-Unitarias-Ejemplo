using System.Reflection.Metadata;

namespace ejemplotest
{
    public class UnitTest1
    {
        //Theory es para Hacer la misma prueba varias veces con diferentes valores
        //Fact es para una prueba estatica
        //Especificamos que espertamos de la prueba en el "Assert"!
        //Para ejecutar las pruebas abre "explorador de pruebas" en el menu "Ver"

        //--------------------------------------------------------------------------------

        //Comprobar si da Error (En caso de que de error la prueba es exitosa)
        [Theory]
        [InlineData(1)]
        [InlineData(5)]
        [InlineData(8)]
        [InlineData(12)]
        public void ValidarMayorADiez_Error(int parametro)
        {
            var result = parametro;
            Assert.Throws<ArgumentException>(() => MayorADiez(result));
        }
         //Mismo Test pero usando Fact
        [Fact]
        public void ValidarMayorADiez_Error_Fact()
        {
            var result = 15;
            Assert.Throws<ArgumentException>(() => MayorADiez(result));
        }

        //-----------------------------------------------------------------------------------


        //Comprobar si no a Error (En caso de no dar error la prueba es exitosa)
        [Fact]
        public void ValidarMayorADiez()
        {
            var result = 14;
            Assert.True(MayorADiez(result));
        }

        //------------------------------------------------------------------------------------

        //Metodo a verificar (Normalmente no se encuentra en esta clase!)
        public bool MayorADiez(int valor)
        {
            if (valor < 10)
            {
                throw new ArgumentException();
            }
            else
            {
                return true;
            }
        }
    }
}