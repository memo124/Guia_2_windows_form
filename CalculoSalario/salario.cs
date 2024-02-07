using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    public class salario
    {
        private int diasLaborados; //atributo
        public int DiasLaborados //propiedad del atributo
        { get; set; }
        //método para calcular salario
        public decimal CalcularSalario(int diaslab, decimal valordia)
        {
            decimal totalsalario = diaslab * valordia;
            return totalsalario;
        }

    }
}
