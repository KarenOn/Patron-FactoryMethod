using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class Pizza : ComidaPrincipal
    {
        public override int Cantidad()
        {
            return 10;
        }
    }
}
