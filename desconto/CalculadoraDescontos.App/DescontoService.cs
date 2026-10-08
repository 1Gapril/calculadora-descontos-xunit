using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraDescontos.App
{
    public class DescontoService
    {
        public string ObterCategoriaCliente(int totalCompras)
        {
            if (totalCompras < 5)
            {
                return "BRONZE";
            }
            else if (totalCompras <= 10)
            {
                return "PRATA";
            }
            else
            {
                return "OURO";
            }
        }
        public int CalcularDescontoPorPercentual(int valorOriginal, int percentualDesconto)
        {
            int desconto = (int)(valorOriginal * (percentualDesconto / 100.0));
            return valorOriginal - desconto;
        }
        public bool EValidoParaCupom(int idade, bool primeiraCompra)
        {
            return idade >= 18 || primeiraCompra;
        }
    }
}
