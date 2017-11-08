using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dog : Mammal, IEat, IMove
    {

        public override void Describe()
        {
            base.Describe();
            Console.WriteLine(string.Format("Father's Name: {0}, Mother's Name: {1}, Wight: {2}", this.Father, this.Mother, this.Weight));
        }

        public void isEating()
        {
            Console.WriteLine("I'm a dog and I'm eating");
        }

        public void isMoving()
        {
            Console.WriteLine(string.Format("I'm a dog, I have {0} legs and I'm run fast", this.Legs));
        }
    }
}
