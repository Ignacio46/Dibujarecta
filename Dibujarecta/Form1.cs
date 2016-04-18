using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dibujarecta
{
    public partial class Form1 : Form
    {
        List<Figuron> figuras;
        
        public Form1()
        {
            figuras = new List<Figuron>(); 
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                circulo c = new circulo(e.X, e.Y);
                c.Dibuja(this);
                figuras.Add(c);

            }
            else if (e.Button == MouseButtons.Right)
            {
                rectangulo r = new rectangulo(e.X, e.Y);
                r.Dibuja(this);
                figuras.Add(r);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figuron f in figuras)
            {
                f.Dibuja(this);
            }
        }
    }
}
