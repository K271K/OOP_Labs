using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Laba6.Figures;

namespace Laba6.Factory
{

    internal class CMyShapeFactory : CShapeFactory
    {
        public override CShape createShape(char code)
        {
            CShape shape = null;
            switch (code)
            {
                case 'C':
                    shape = new CCircle(0,0,0,Color.Blue);
                    break;
                default:
                    break;
            }
            return shape;
        }
    }


}
