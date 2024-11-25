using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO___Programação
{
    internal class Pocao : Item
    {
        
        public override void Usar(TextBox textBox)
        {
            textBox.Text = "Você tomou uma poção";
        }

        public override void Descrição(TextBox textBox)
        {
            textBox.Text = "Essa poção te cura";
        }
    }
}
