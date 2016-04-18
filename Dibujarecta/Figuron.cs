using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dibujarecta
{
   abstract class Figuron
    {
        public int X, Y;
        public Pen pluma;
        public Brush brocha;
        public int ancho, largo;

        public Figuron(int x, int y)
        {
            X = x;
            Y = y;
            pluma = new Pen(Color.Red, 2);
            ancho = 100;
            largo = 100;
        }
        public abstract void Dibuja(Form f);
    }


   class rectangulo : Figuron
   {
       public rectangulo(int x, int y)
           : base(x, y)
       {
       }
       public override void Dibuja(Form f)
       {
           Graphics g = f.CreateGraphics();
           g.DrawRectangle(pluma, X, Y, ancho, largo);
       }
   }


   class circulo : Figuron
   {
       public circulo(int x, int y)
           : base(x, y)
       {
       }
       public override void Dibuja(Form f)
       {
           Graphics g = f.CreateGraphics();
           g.DrawEllipse(pluma, X, Y, ancho, largo);
       }
   }

}
