namespace pay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기");
            double nmb1 = Convert.ToDouble(Console.ReadLine());

            string z = Console.ReadLine();

            double nmb3 = Convert.ToDouble(Console.ReadLine());

            double x = 0;

            if (z == "+")
            {
                x = nmb1 + nmb3;
            }
            else if (z == "-")
            {
                x = nmb1 - nmb3;
            }
            else if(z == "*")
            {
                x = nmb1 * nmb3;
            }
            else if (z == "/")
            {
                x = nmb1 / nmb3;
            }
            else
            {
                Console.WriteLine("잘못된 연산자");
            }
            
            Console.WriteLine(x);
            
        }
    }
}
