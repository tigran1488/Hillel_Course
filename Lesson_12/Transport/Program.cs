namespace Transport
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport auto1 = new Auto("BMW",220,4);
            Transport bicycle2 = new Bicycle("Mountain bicycle","winner",30);

            auto1.PrintDetails();
            bicycle2.PrintDetails();
            auto1.Move();
            bicycle2.Move();



        }
    }
}