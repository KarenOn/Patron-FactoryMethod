using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    public class Creador
    {
        public const int pizza = 1;
        public const int hamb = 2;

        public static ComidaPrincipal CreadorComida(int tipo)
        {
            switch(tipo)
            {
                case pizza:
                    return new Pizza();
                case hamb:
                    return new Hamburguesa();
                default: return null;
            }
        }
    }
}
