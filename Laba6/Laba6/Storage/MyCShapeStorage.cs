using Laba6.Factory;
using Laba6.Figures;
using Laba6.Observer;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Storage
{
    internal class MyCShapeList : MyList<CShape>, IObserver, IObservable
    {
        List<IObserver> observers;
        public MyCShapeList() : base()
        {
            observers = new List<IObserver>();
        }
        public void loadShapes(string filename, CMyShapeFactory factory)
        {
            StreamReader SR = new StreamReader(filename);
            int count = int.Parse(SR.ReadLine());
            for (int i = 0; i < count; i++)
            {
                CShape cShape = factory.createShape(SR.ReadLine());
                if (cShape != null)
                {
                    cShape.load(SR, factory);
                    push_back(cShape);
                }
            }
            SR.Close();
        }

        public override void push_back(CShape data)
        {
            base.push_back(data);
            Notify();
        }
        public override CShape pop_front()
        {
            CShape returnData = base.pop_front();
            Notify();
            return returnData;
        }
        public override CShape remove(int index)
        {
            CShape returnData = base.remove(index);
            Notify();
            return returnData;
        }
        public override void clear()
        {
            base.clear();
            Notify();
        }

        void IObserver.OnSubjectChanged(IObservable obj)
        {
            DeselectAll();
            TreeHandler tmp = (TreeHandler)obj;
            int j = 0;
            for (int i = 0; i < tmp.get_size(); i++, j++) { 
                if (tmp.treeView.Nodes[j].BackColor == Color.Gray)
                {
                    (tmp[i] as CShape).Select();
                }
            }
            Notify();
            
        }
        public void DeselectAll()
        {
            Node<CShape> current = Head;
            while (current != null)
            {
                current.Data.DeSelect();
                current = current.pNext;
            }
        }

        public void Notify()
        {
            foreach (IObserver obj in observers)
            {
                obj.OnSubjectChanged(this);
            }
        }

        public void AddObserver(IObserver obj)
        {
            observers.Add(obj);
        }
    }

}
