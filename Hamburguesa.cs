using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Hamburguesa : ComidaPrincipal
    {
        public override int Cantidad()
        {
            return 5;
        }
    }
}
