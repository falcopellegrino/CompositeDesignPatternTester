using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.StructuralCode
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    class Composite : Component
    {
        private List<Component> _children = new List<Component>();

        // Constructor
        public Composite(string name)
            : base(name)
        {
        }

        public override void Add(Component c)
        {
            _children.Add(c);
        }

        public override void Remove(Component c)
        {
            _children.Remove(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
            foreach(Component c in _children)
            {
                c.Display(depth + 2);
            }
        }
    }
}
