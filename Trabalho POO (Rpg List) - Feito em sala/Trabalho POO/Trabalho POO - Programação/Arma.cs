using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO___Programação
{
    public class Arma : Item
    {
        public override void Usar(TextBox textBox)
        {
            textBox.Text = "Usou a arma";
        }

        public override void Descrição(TextBox textBox)
        { 
            textBox.Text = "Você pode usar esta arma para se defender, além disso ela aumenta seu dano" ;
        }

       
    }
}
