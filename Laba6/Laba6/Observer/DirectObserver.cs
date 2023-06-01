using Laba6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Observer
{
    internal class DirectObserver
    {
        public List<CShape> parents { get; }
        public DirectObserver()
        {
            parents = new List<CShape>();
        }
        public void AddParent(CShape shape)
        {
            parents.Add(shape);
        }
        public void RemoveParent(CShape shape)
        {
            parents.Remove(shape);
        }
        public bool IsParent(CShape shape)
        {
            return parents.Contains(shape);
        }
        public void Clear()
        {
            parents.Clear();
        }
        public void Changed(PaintEventArgs e)
        {
            foreach (CShape shape in parents)
            {
                shape.observable.ShowLines(shape.GetCenter().X, shape.GetCenter().Y, e);
            }
        }

    }
}
