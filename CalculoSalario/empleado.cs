using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSalario
{
    public class empleado
    {
        private string nombre; //primer atributo
        public string Nombre //propiedad asociada al atributo nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string identificacion; //segundo atributo
        public string Identificacion //propiedad asociada al atributo identificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }
        private decimal salarioDiario; //tercer atributo
        public decimal SalarioDiario //propiedad asociada al atributo salarioDiario
        {
            get { return salarioDiario; }
            set { salarioDiario = value; }
        }
    }
}
