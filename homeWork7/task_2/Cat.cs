using ClassAnimal;

namespace task_2
{
    internal class Cat:Animal
    {
        public override void Feed(FoodType foodType, int count)
        {
            if (foodType != FoodType.CatFood)
            {
                Console.WriteLine("Meow, I dont eat this!");
                return;
            }

            Satiety += count;
            Console.WriteLine("Om-nom-nom");
        }

        public void SayHelloToCat()
        {
            Console.WriteLine($"Hello, {Name}");
        }

    }
}
