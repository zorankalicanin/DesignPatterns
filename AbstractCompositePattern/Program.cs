using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractCompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var root = new Composite("root");
            root.AddChild(new Leaf("Leaf 1"));
            root.AddChild(new Leaf("Leaf 2"));

            var comp = new Composite("Composite C");
            comp.AddChild(new Leaf("Leaf C.1"));
            comp.AddChild(new Leaf("Leaf C.2"));

            root.AddChild(comp);
            root.AddChild(new Leaf("Leaf 3"));

            var leaf = new Leaf("Leaf 4");
            root.AddChild(leaf);
            root.RemoveChild(leaf);

            root.Display(1);
            Console.ReadLine();
        }
    }
}
