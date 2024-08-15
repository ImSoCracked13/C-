namespace Swap\ 
{
    internal class Program
    {
        static public void Swap<T>(ref T x, ref T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            char x = 'x'; int y = 'y';
            Console.WriteLine("Before: x={0} y={0}", x, y);
            Swap<char>(ref x, ref y);
            Console.WriteLine("After: x={0} y={0}", x, y);
        }
   class Animal
    {
        public string Name { get; set: }
            public Animal(string name) 
        {
            this.Name = name;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound")
        }
    }
    class Dog : Animal
    {
        public Dog(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Meow! Meow!")
        }
    }
    class Rat : Animal
    {
        public Rat(string name) : base(name) { }
        public override void MakeSound()
        {
            Console.WriteLine("Hiss! Hiss!")
        }
    }
        static void Main1()
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Dog("Buddy");
            animals[1] = new Cat("Pal");
            animals[2] = new Rat("Lad");

            foreach (var animal in animals) 
            { 
            Console.WriteLine($"Name: {animal.Name}");
                animal.MakeSound();
                Console.WriteLine();            }
        }

    }
}
 