using System;
using Xunit;

namespace ProgramaTDD
{
    public class Testes
    {
        [Fact]
        public void testeSucesso()
        {
            Assert.Equal(4, soma(2, 2));
        }

        [Fact]
        public void testeFalha()
        {
            Assert.Equal(4, soma(2, 2)); //A SOMA AQUI NAO VAI RETORNA 5 COMO ESPERANDO GERANDO UMA FALHA
        }

        int soma(int x, int y)
        {
            return x + y;
        }
    }
}
