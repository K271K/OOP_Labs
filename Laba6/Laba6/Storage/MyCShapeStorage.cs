using Laba6.Factory;
using Laba6.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Storage
{
    internal class MyCShapeList : MyList<CShape>
    {
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
        public override CShape remove(int index)
        {
            if (index < 0 || index - Size > -1)
            {
                return default;
            }
            else if (index == 0 || Head == null)
            {
                return pop_front();
            }
            else
            {
                Node<CShape> previous = Head;
                for (int i = 0; i < index - 1; i++)
                {
                    previous = previous.pNext;
                }
                Node<CShape> ToDeleteNode = previous.pNext;
                CShape ToDeleteData = ToDeleteNode.Data;
                previous.pNext = ToDeleteNode.pNext;
                if (previous.pNext == null)
                    Tail = previous;
                ToDeleteNode = null;
                Size--;
                ToDeleteData.observer.Clear();
                ToDeleteData.observable.Clear();
                return ToDeleteData;
            }
        }
        public override void clear()
        {
            while (Size != 0)
            {
                CShape temp = pop_front();
                temp.observable.Clear();
                temp.observer.Clear();
                temp = default;
            }
        }
    }

}
