using Laba6.Factory;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Laba6.Figures
{
    internal class CGroup: CShape 
    {
        public CGroup(int _x = 0, int _y = 0, int _size = 0, Color _color = default(Color))
        {
        }
        private List<CShape> _shape = new List<CShape>();
        public CShape getItem(int index)
        {
            return _shape[index];
        }
        public void addShape(CShape shape)
        {
            _shape.Add(shape);
            shape.DeSelect();
            size += 1;
        }
        public override bool checkHit(int ClickX, int ClickY)
        {
            foreach (CShape shape in _shape)
            {
                if (shape.checkHit(ClickX, ClickY))
                    return true;
            }
            return false;
        }
        public override void draw(PaintEventArgs e)
        {
            foreach (CShape shape in _shape) shape.draw(e);

        }
        public override bool isAvailableLocation(int w, int h, int dX, int dY)
        {
            foreach (CShape shape in _shape)
            {
                if (!shape.isAvailableLocation(w, h, dX, dY))
                    return false;
            }
            return true;
        }
        public override bool isA(string who)
        {
            return (who == "CGroup") || (base.isA(who));
        }
        public override void Select()
        {
            isSelected = true;
            foreach(CShape shape in _shape)
            {
                shape.Select();
            }
        }
        public override void DeSelect()
        {
            isSelected = false;
            foreach (CShape shape in _shape)
            {
                shape.DeSelect();
            }
        }
        public override void move(int w, int h, int dX, int dY)
        {
            if (this.isAvailableLocation(w, h, dX, dY))
                foreach (CShape shape in _shape)
                    shape.move(w,h,dX,dY);
            
        }
        public override void SizeChange(int newSize, int w, int h)
        {
            if (newSize > 0)
            {
                if (this.isAvailableLocation(w, h, 5, 5) && this.isAvailableLocation(w, h, -5, -5))
                    foreach (CShape shape in _shape)
                        shape.SizeChange(newSize, w, h);
            }
            else
            {
                foreach (CShape shape in _shape)
                {
                    shape.SizeChange(newSize, w, h);
                }
            }
        }
        public override void ColorChange(Color newColor)
        {
            foreach (CShape shape in _shape)
                shape.ColorChange(newColor);
        }
        public override void save(StreamWriter SW)
        {
            SW.WriteLine("Group" + "\n" + _shape.Count + "\n" + this.isSelected);
            foreach(CShape shape in _shape)
            {
                shape.save(SW);
            }
        }
        public override void load(StreamReader SR, CMyShapeFactory factory)
        {
            int count = int.Parse(SR.ReadLine());
            bool GroupSelectStatus = SR.ReadLine() == "True";
            for (int i = 0; i < count; i++)
            {
                CShape cShape = factory.createShape(SR.ReadLine());
                if (cShape != null)
                {
                    cShape.load(SR);
                    addShape(cShape);
                }
            }
            if (GroupSelectStatus) Select();
            SR.Close();
        }
    }
}
