namespace Animal_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.MakeSound();
            dog.Move();
            Animal bird = new Bird();
            bird.MakeSound();
            bird.Move();
           
          
        }
    }
}