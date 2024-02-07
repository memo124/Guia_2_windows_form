using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        Celular telefono = new Celular("Samsung", "S", "blanco", 1500);

        public Form1()
        {
            InitializeComponent();
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            txtnumero.Visible = false;
            txtmensaje.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = telefono.Encender();
            MessageBox.Show(mensaje);
            button2.Visible = true;
            button1.Visible = false;
            button3.Visible = true;
            button4.Visible = true;
            txtnumero.Visible = true;
            txtmensaje.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = telefono.Encender();
            MessageBox.Show(mensaje);
            button2.Visible = false;
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            txtnumero.Visible = false;
            txtmensaje.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string numero = txtnumero.Text;

            if (numero.Equals("") || numero.Equals(null))
            {
                MessageBox.Show("Favor ingresar un numero de teléfono");
            }
            MessageBox.Show(telefono.Llamar(numero));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensaje = txtmensaje.Text;
            string numero = txtnumero.Text;
            if (numero.Equals("") || numero.Equals(null))
            {
                MessageBox.Show("Favor ingresar un numero de teléfono");
            }
            if (numero.Equals("") || numero.Equals(null))
            {
                MessageBox.Show("Favor ingresar un mensaje");
            }
            MessageBox.Show(telefono.EnviarMensaje(numero, mensaje));
        }
    }
}
