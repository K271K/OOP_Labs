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
        public override CShape createShape(string code, int x, int y, int size, Color color)
        {
            CShape shape = null;
            switch (code)
            {
                case "Circle":
                    shape = new CCircle(x, y, size, color);
                    break;
                case "Triangle":
                    shape = new CTriangle(x, y, size, color);
                    break;
                case "Square":
                    shape = new CSquare(x, y, size, color);
                    break;
                default:
                    break;
            }
            return shape;
        }
    }


}
