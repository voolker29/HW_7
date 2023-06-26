using ClassAnimal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Pig:Animal
    {



        public void Feed(int count)
        {
            Satiety += count;
            Console.WriteLine("Om-nom-nom");

        }


    }
}
