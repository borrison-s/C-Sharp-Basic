namespace TaskTwo
{
    public class Dog
    {
        public string Name { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }

        public Dog()
        {
         
        }

        public Dog(string name, string breed, string color)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name value");
                name = "Default name";
            }
            else
            {
                Name = name;
            }

            if (string.IsNullOrEmpty(breed))
            {
                Console.WriteLine("Invalid breed value");
                Breed = "Default value";
            }
            else
            {
                Breed = breed;
            }
            
            if (string.IsNullOrEmpty(color))
            {
                Console.WriteLine("Invalid breed value");
                Color = "Default value";
            }
            else
            {
                Color = color;
            }
        }
        public string Eat()
        {
            return "The dog is now eating.";
        }

        public string Play()
        {
            return "The dog is now playing.";
        }

        public string ChaseTail()
        {
            return "The dog is now chasing its tail.";
        }
    }
}
