using Laba6.Figures;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Observer
{
    internal class DirectObservable
    {
        public List<CShape> observers { get; }
        public List<bool> visited { get; }
        List<CShape> lines;

        public DirectObservable()
        {
            observers = new List<CShape>();
            visited = new List<bool>();
            lines = new List<CShape>();
        }
        public void NotifyObservers(int w, int h, int dx, int dy)
        {
            for (int i = 0; i< observers.Count; i++)
            {
                    observers[i].move(w,h,dx,dy);
                
            }
        }
        public void AddObserver(CShape s)
        {
            observers.Add(s);
            visited.Add(false);
        }
        public void RemoveObserver(CShape s)
        {
            observers.Remove(s);
        }
        public void Clear()
        {
            observers.Clear();
        }
        public bool IsObserver(CShape s)
        {
            return observers.Contains(s);
        }
        public void ShowLines(float start_x, float start_y, PaintEventArgs pict)
        {
            foreach(CShape s in observers)
            {
                Pen pen = new Pen(Color.Black, 1.0f);
                pen.CustomEndCap = new AdjustableArrowCap(6, 6, true);
                pict.Graphics.DrawLine(pen, start_x, start_y, s.GetCenter().X, s.GetCenter().Y);
            }
        }

    }
}
