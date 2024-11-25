using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO___Programação
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<inventario> inventarios = new List<inventario>();

        private void Form1_Load (object sender, EventArgs e)
        {
            inventarios.Add(new inventario()
            {

            });
        }


        public void InfoBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UsarItem_Click(object sender, EventArgs e)
        {
           Pocao pocao = new Pocao();
            pocao.Usar(InfoBox);
            pocao.Descrição(DescriBox);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
