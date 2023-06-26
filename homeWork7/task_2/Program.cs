using System.Data.Common;
using task_2;

var cat = new Cat() ;
cat.Name = "Breakfest" ;
cat.Age = 1 ;
cat.SayHelloToCat();
cat.Feed(FoodType.CatFood,15);


var pig = new Pig() ; 
pig.Age = 1 ;
pig.Feed(15);


public enum FoodType
{
    PigFood,
    CatFood,
    Other
}
