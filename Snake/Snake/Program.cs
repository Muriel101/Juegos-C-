﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Snake";
            Console.CursorVisible = false;
            Console.SetWindowSize(120, 30);

            Tablero t = new Tablero(new Point(24,2), new Point(95, 27));
            Manzana m = new Manzana(t);
            Snake s = new Snake(t, m);
            m.posicionar(s);
            t.dibujar();
            
            while (true)
            {
                if (s.Vivo)
                {
                    t.dibujarInfo(s);
                    m.dibujar();
                    s.moverse();
                    s.dibujar();
                }
                
            }
        }
    }
}
