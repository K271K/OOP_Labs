using Laba6.Figures;
using Laba6.Observer;

namespace Laba6.Storage
{
    internal class TreeHandler : IObserver, IObservable
    {
        internal TreeView treeView;
        List<IObserver> observers;
        public IObserver get_current(int index)
        {
            return observers[index];
        }
        public int get_size() { return observers.Count; }
        public IObserver this[int index]
        {
            get
            {
                return observers[index];
            }

        }
        public TreeHandler(TreeView tree){
            observers = new List<IObserver>();
            treeView = tree;
        }

        public void AddObserver(IObserver obj)
        {
            observers.Add(obj);
        }

        public void Notify()
        {
            foreach(IObserver observer in observers)
            {
                observer.OnSubjectChanged(this);
            }
        }

        public void OnSubjectChanged(IObservable obj)
        {
            treeView.Nodes.Clear();
            MyCShapeList tmp = (MyCShapeList)obj;
            foreach (CShape shape in tmp)
            {
                TreeNode new_node = new TreeNode(shape.ToString());
                if (shape.GetSelected())
                {
                    new_node.BackColor = Color.Gray;
                    new_node.Expand();
                }
                else
                {
                    new_node.Collapse();
                }
                if (shape is CGroup)
                {
                    ProcessNode(new_node, shape);
                }
                treeView.Nodes.Add(new_node);
            }
        }
        public void ProcessNode(TreeNode tr, CShape shape)
        {
            if (shape is CGroup)
            {
                List<CShape> tmp = (shape as CGroup)._shape;
                foreach (CShape s in tmp)
                {
                    TreeNode new_node = new TreeNode(s.ToString());
                    if (s.GetSelected())
                    {
                        new_node.BackColor= Color.Gray;
                        new_node.Expand();
                    }
                    else
                    {
                        new_node.Collapse();
                    }
                    ProcessNode(new_node, s);
                    tr.Nodes.Add(new_node);
                }
            }
        }
    }
}
