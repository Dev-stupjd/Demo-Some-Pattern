using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace DemoSomeDesignPattern
{
    public class Lion : IAnimal
    {
        public void AboutMe() => WriteLine("This is Lion.");
    }
    public class Tiger : IAnimal
    {
        public void AboutMe() => WriteLine("This is Tiger.");
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal CreateAnimal();
    }

    public class LionFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Lion();
    }

    public class TigerFactory : AnimalFactory
    {
        public override IAnimal CreateAnimal() => new Tiger();
    }
}
