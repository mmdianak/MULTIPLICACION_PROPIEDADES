using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MULTIPLICACION_PROPIEDADES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cloperaciones omul = new cloperaciones();
            omul.N1 = int.Parse(textBox1.Text);
            omul.N2 = int.Parse(textBox2.Text);
            textBox3.Text = omul.Multiplicar().ToString();
        }
    }
}
