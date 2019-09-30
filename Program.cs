using System;

namespace Classy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        private class Animal
        {
            public string _height { get; set; }
            public int _name { get; set; }

            public Animal(string height, int name)
            {
                _height = height;
                _name = name;
            }

            public void Run()
            {
                Console.WriteLine("Tigers run really fast");
            }

            public void Speak(string words)
            {
                Console.WriteLine("Lions are big {0}", _name);
                Console.WriteLine(words);
                Console.ReadKey();
            }

            public void Think(float now1, float now2)
            {
                var outcome = (now1 * now2) / 5;
                Console.WriteLine("The outcome is: {0}", outcome);
                Console.ReadKey();
            }
        }

        private class Dog : Animal
        {
            public string _Breed { get; set; }
            public string _name { get; set; }
            public int _stamina { get; set; }

            public Dog(string name, int stamina, string Breed) : base(name, stamina)
            {
                _name = name;
                _stamina = stamina;
                _Breed = Breed;
            }

            public void run()
            {
                Console.WriteLine("dogs can be big is: {0}", _Breed);
                Console.ReadKey();
            }

            private class Cat : Animal
            {
                public int _SixToed { get; set; }
                public string _name { get; set; }

                public Cat(string name, int SixToed) : base(name, SixToed)
                {
                    _name = name;
                    _SixToed = SixToed;
                }

                public void noo()
                {
                    foreach (int x in _name)

                        if (x == 12)
                        {
                            Console.WriteLine("What happen");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Idk");
                            Console.ReadKey();
                        }
                    Console.WriteLine("Cats are quiet kinda: {0}", _name);
                    Console.ReadKey();
                }
            }
        }
    }
}