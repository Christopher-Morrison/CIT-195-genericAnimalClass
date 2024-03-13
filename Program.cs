using System;

namespace genericAnimalClass
{
    public class Animal < T >
    {
        public T data;
        public Animal(T data)
        {
            this.data = data;
            Console.WriteLine("Data passed: "+ this.data);
        }

        public T getAnimal()
        {
            return data;
        }
    }
    class Program{
        
        static void Main()
        {
           Animal <string> animalName = new Animal <string> ("Poodle");
           Animal <string> animalHabitat = new Animal<string> ("My Aunt's House");
           Animal <bool> endangered = new Animal<bool> (false);
           Animal <bool> extinct = new Animal<bool> (false);
           Animal <int> averageLifespan = new Animal<int> (13);

           animalName.getAnimal();
           animalHabitat.getAnimal();
           endangered.getAnimal();
           extinct.getAnimal();
           averageLifespan.getAnimal();
        }
    }
}
