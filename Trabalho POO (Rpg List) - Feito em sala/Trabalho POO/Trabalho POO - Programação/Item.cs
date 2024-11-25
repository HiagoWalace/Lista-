using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO___Programação
{
    public abstract class Item
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public int Valor { get; set; }

        public abstract void Usar(TextBox textBox);
        public abstract void Descrição(TextBox textBox);
        
    }
}
    