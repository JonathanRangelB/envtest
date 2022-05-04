using System;

namespace envtest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var temp = Environment.GetEnvironmentVariable("nombre");
            if (temp != null)
                Console.WriteLine(temp);
            else Console.WriteLine("no encontrada");
        }
    }
}
