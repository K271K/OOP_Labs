using Laba6.Factory;
using Laba6.Observer;
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
        public DirectObservable observable { get; protected set; }
        public DirectObserver observer { get; protected set; }
        public CShape(int _x = 0, int _y = 0, int _size = 0, Color _color = default(Color))
        {
            x = _x;
            y = _y;
            size = _size;
            color = _color;
            observable = new DirectObservable();
            observer = new DirectObserver();
        }
        public int GetSize() { return size; }
        public bool GetSelected() { return isSelected; }
        
        public abstract bool checkHit(int ClickX, int ClickY);
        public abstract void draw(PaintEventArgs e);
        public abstract bool isAvailableLocation(int w, int h, int dX, int dY);
        public virtual bool isA(string who)
        {
            return who == "CShape";
        }
        public virtual void Select() { isSelected = true; }
        public virtual void DeSelect() { isSelected = false; }
        public virtual void move(int w, int h, int dX, int dY)
        {
            if (isAvailableLocation(w, h, dX, dY))
            {
                this.x += dX;
                this.y += dY;
                observable.NotifyObservers(w,h,dX,dY);
            }
        }
        public virtual void SizeChange(int newSize, int w, int h)
        {               
           if (newSize > 0)
            {
                if (isAvailableLocation(w, h, -5, -5) && isAvailableLocation(w,h,5,5))
                    this.size += newSize;
            }
           else
            {
                if (this.size + newSize > 0)
                {
                    this.size += newSize;
                }
            }
        }
        public virtual void ColorChange(Color newColor)
        {
            this.color = newColor;
        }
        public virtual void save(StreamWriter SW)
        {
            SW.WriteLine(x + "\n" + y + "\n" + color.ToArgb() + "\n" + size + "\n" + this.isSelected);
        }
        public virtual void load(StreamReader SR, CShapeFactory factory = default(CShapeFactory))
        {
            this.x = int.Parse(SR.ReadLine());
            this.y = int.Parse(SR.ReadLine());
            this.color = Color.FromArgb(int.Parse(SR.ReadLine()));
            this.size = int.Parse(SR.ReadLine());
            if (SR.ReadLine() == "True")
                this.isSelected = true;
            else
                this.isSelected = false;
        }
        public virtual PointF GetCenter()
        {
            return new PointF(this.x, this.y);
        }
    }
    
    

}
