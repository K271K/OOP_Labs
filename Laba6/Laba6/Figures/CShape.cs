using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Figures
{
    internal abstract class CShape
    {
        protected int x;
        protected int y;
        protected int size = 50;
        protected Color color;
        protected bool isSelected = false;
        public CShape(int _x, int _y, int _size, Color _color)
        {
            x = _x;
            y = _y;
            size = _size;
            color = _color;
        }
        public bool GetSelected() { return isSelected; }
        public void Select() { isSelected = true; }
        public void DeSelect() { isSelected = false; }
        public abstract bool checkHit(int ClickX, int ClickY);
        public abstract void draw(PaintEventArgs e);
        public abstract void save();
        public abstract void load();

    }
    
    

}
