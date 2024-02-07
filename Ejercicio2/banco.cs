using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class banco
    {

        public cuenta ingresoCuenta(cuenta cuenta, List<cuenta> cuentas)
        {
            cuenta.numero_cuenta = $"C{cuenta.tipo_cuenta.Substring(0,1)}-{retornarIndice(cuenta.tipo_cuenta,cuentas).ToString("D4")}";
            return cuenta;
        }

        public int retornarIndice(string cuenta, List<cuenta> cuentas)
        {
            int count = 0;
            if (cuentas != null)
            {
                foreach (var item in cuentas)
                {
                    if (item.tipo_cuenta.Equals(cuenta)) count++;
                }
                return count;
            }
            return 1;
        }
       
    }
}
