using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public List<cuenta> cuentas;
        public Form1()
        {
            InitializeComponent();
            cuentas = new List<cuenta>();
            dgdata.Columns.Add("dui", "dui");
            dgdata.Columns.Add("nombre", "nombre");
            dgdata.Columns.Add("apellido", "apellido");
            dgdata.Columns.Add("tipo_cuenta", "tipo_cuenta");
            dgdata.Columns.Add("nit", "nit");
            dgdata.Columns.Add("numero_cuenta", "numero_cuenta");
            dgdata.Columns.Add("monto", "monto");
            dgdata.Columns.Add("sucursal", "sucursal");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtdui.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un DUI");
                return;
            }
            if (txtapellido.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un apellido");
                return;
            }
            if (txtmonto.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un monto");
                return;
            }
            if (txtnit.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un NIT");
                return;
            }
            if (txtnombre.Text.Equals(""))
            {
                MessageBox.Show("Favor ingresar un nombre");
                return;
            }
            if (cbsucursal.SelectedItem == null)
            {
                MessageBox.Show("Favor seleccionar una sucursal");
                return;
            }
            if (cbtipo.SelectedItem == null)
            {
                MessageBox.Show("Favor seleccionar un tipo de cuenta");
                return;
            }

            banco banco = new banco();
            cuenta cuenta = new cuenta(){
                dui = txtdui.Text,
                nombre = txtnombre.Text,
                apellido = txtapellido.Text,
                nit = txtnit.Text,
                monto = txtmonto.Text,
                sucursal = cbsucursal.SelectedItem.ToString(),
                tipo_cuenta = cbtipo.SelectedItem.ToString()
            };
            cuentas.Add(banco.ingresoCuenta(cuenta, cuentas));
            generarTabla();
        }
        public void generarTabla() {
            dgdata.Rows.Clear();
            foreach (var item in cuentas)
            {
                dgdata.Rows.Add(item.dui, item.nombre, item.apellido, item.tipo_cuenta, item.nit, item.numero_cuenta, item.monto, item.sucursal);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbtipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtipo.Items.Add("Ahorro");
            cbtipo.Items.Add("Corriente");
            cbtipo.Items.Add("Plazo");
            cbtipo.SelectedItem = "Ahorro";
            cbsucursal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbsucursal.Items.Add("Sucursal 1");
            cbsucursal.Items.Add("Sucursal 2");
            cbsucursal.Items.Add("Sucursal 3");
            cbsucursal.Items.Add("Sucursal 4");
            cbsucursal.Items.Add("Sucursal 5");
            cbsucursal.SelectedItem = "Sucursal 1";
        }
    }
}
