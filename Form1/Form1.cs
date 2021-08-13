using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj5 = new cManejoCadenas();//instancia a la clase
            txtcaracteres.Text = Convert.ToString(obj5.tamaño(txtfrase.Text));
            txtvocales.Text = Convert.ToString(obj5.vocales(txtfrase.Text));
            txtconsonantes.Text = Convert.ToString(obj5.consonantes(txtfrase.Text));
            txtpalabras.Text = Convert.ToString(obj5.palabras(txtfrase.Text));
        }
        private void cmdlimpiar_Click(object sender, EventArgs e)
        {
            txtfrase.Clear();
            txtcaracteres.Clear();
            txtvocales.Clear();
            txtconsonantes.Clear();
            txtpalabras.Clear();
        }

        private void cmdsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
