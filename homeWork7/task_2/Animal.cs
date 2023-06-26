using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAnimal
{
     class Animal
    {

        public string Name { get; set; }  // Имя может быть и у парасенка (пример фильм парасенок бэйб))
        protected double Satiety { get; set; }
        public int Age { get; set; }

        public  virtual void Feed(FoodType foodType, int count)
        {
            Satiety += count;
            Console.WriteLine("Om-nom-nom");
        }

    }

  
}
