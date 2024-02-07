using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoSalario
{
    public partial class Form1 : Form
    {
        empleado miEmpleado = new empleado(); //instancia de la clase Empleado
        salario miSalario = new salario(); //objeto de la clase Salario
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*los valores obtenidos en los textbox son pasados a los atributos por medio de sus 
                propiedades, note que mandamos a llamar a través de los objetos creados*/
            miEmpleado.Nombre = txtnombre.Text;
            miEmpleado.Identificacion = txtidentificacion.Text;
            miEmpleado.SalarioDiario = Convert.ToDecimal(txtasignacion.Text);
            miSalario.DiasLaborados = int.Parse(txtdias.Text);
            MessageBox.Show("Datos ingresados con éxito");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Enviaremos el valor de salario calculado al textbox respectivo, como es un dato 
numérico debemos convertirlo a texto, el cálculo lo hace el método de la clase salario*/
            txttotal.Text = Convert.ToString(miSalario.CalcularSalario(miSalario.DiasLaborados,
            miEmpleado.SalarioDiario));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //limpiando todo para ingresar nuevos datos
            txtnombre.Clear();
            txtidentificacion.Clear();
            txtdias.Clear();
            txtasignacion.Clear();
            txttotal.Clear();
            txtnombre.Focus(); //regresa el cursor al textbox del nombre
        }
    }
}
