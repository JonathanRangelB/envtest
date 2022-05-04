using System;

namespace envtest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var temp = Environment.GetEnvironmentVariable("NOMBRE");
            if (temp != null)
                Console.WriteLine("mi nombre es: {0}", Convert.FromBase64String(temp));
            else Console.WriteLine("no encontrada");
        }
    }
}
