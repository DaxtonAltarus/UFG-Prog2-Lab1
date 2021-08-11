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

        private void cmdtamaño_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj1 = new cManejoCadenas();//instancia a la clase
            txtcaracteres.Text = Convert.ToString(obj1.tamaño(txtfrase.Text));
        }

        private void cmdnumvocales_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj2 = new cManejoCadenas();
            txtvocales.Text = Convert.ToString(obj2.vocales(txtfrase.Text));
        }

        private void cmdnumconso_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj3 = new cManejoCadenas();
            txtconsonantes.Text = Convert.ToString(obj3.consonantes(txtfrase.Text));
        }

        private void cmdnumpalabras_Click(object sender, EventArgs e)
        {
            cManejoCadenas obj4 = new cManejoCadenas();
            txtpalabras.Text = Convert.ToString(obj4.palabras(txtfrase.Text));
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
