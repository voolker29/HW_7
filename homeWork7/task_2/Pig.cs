using ClassAnimal;

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
