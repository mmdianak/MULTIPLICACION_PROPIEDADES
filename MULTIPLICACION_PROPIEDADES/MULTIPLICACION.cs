﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MULTIPLICACION_PROPIEDADES
{
        internal class cloperaciones
        {
            // Propiedades, campos, etc.
            private int n1;
            private int n2;

            // Encapsulamiento de las propiedades.
            public int N1 { get => n1; set => n1 = value; }
            public int N2 { get => n2; set => n2 = value; }

            // Metodo
            public int Multiplicar()
            {
                return n1 * n2;
            }
        }
}
