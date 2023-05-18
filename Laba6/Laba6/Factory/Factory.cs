using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba6.Figures;

namespace Laba6.Factory
{

    internal abstract class CShapeFactory
    {
        public abstract CShape createShape(string code, int x, int y, int size, Color color);

    }
}
