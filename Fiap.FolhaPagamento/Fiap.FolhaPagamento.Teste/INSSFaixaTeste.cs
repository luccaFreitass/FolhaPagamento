using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.FolhaPagamento.Teste
{
    public class INSSFaixaTeste
    {
        public static IEnumerable<object> DadosValorFaixa => new List<object[]>()
        {
            new object[]{0, 14120.01m, 7.5m, 1412m},
            new object[]{14120.01m, 2666.68m, 9m, 688}
        };

        [Fact] //Fact representa um cenario de Teste
        public void INSS_Faixa_Deve_Conter_Valor()
        {
            var faixa = new INSSFaixa
            {
                Piso = 0,
                Teto = 1422
            };

            Assert.True(faixa.ContemValor(1200));
        }

       // [Theory]
        //[MemberData(nameof(DadosValorFaixa))]
        //public void 

        [Fact]
        public void Deve_Obter_1412()
        {
            var faixa = new INSSFaixa {
                Piso = 0,
                Teto = 1412,
                Aliquota = 7.5m
            };

            //Act
            var resultado = faixa.ObterValorFaixa(1412);
            const decimal esperado = 1412m;

            //Assert
            Assert.Equal(esperado, resultado);
        }
    }
}

