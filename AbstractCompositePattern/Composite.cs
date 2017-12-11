using System;
using System.Collections.Generic;

namespace AbstractCompositePattern
{
    class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public Composite(string name)
            : base(name)
        {
        }

        public void AddChild(Component component)
        {
            _children.Add(component);
        }

        public void RemoveChild(Component component)
        {
            _children.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);

            foreach (Component component in _children)
            {
                component.Display(depth + 2);
            }
        }
        public override void Operation()
        {
            string message = string.Format("Composite with {0} child(ren).", _children.Count);
            Console.WriteLine(message);
        }
    }
}
