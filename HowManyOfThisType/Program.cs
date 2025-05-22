using System;

namespace HowManyOfThisType
{
    public class Program
    {
        private static void Main(string[] args)
        {
            object[] test = new object[3];
            test[0] = 2;
            test[1] = "aaa";
            test[2] = 100;

            Console.WriteLine(Checker.HowManyOfType<int>(test));

<<<<<<< HEAD
            Console.WriteLine("Merci d’utiliser ce programme!");
=======
            Console.WriteLine("Obrigado por ter usado este programa!");
>>>>>>> 6ea507c (Mensagem de agradecimendo adicionada.)

        }
    }
}
