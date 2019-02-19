using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Cap5.Repeticao.Test
{
    [TestClass]
    public class RepeticaoTest
    {
        [TestMethod]
        public void ForAninhadoTest()
        {
            for (int i = 0; i <= 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }
                Console.WriteLine(new string('-', 50));
            }
        }

        [TestMethod]
        public void EstruturaForTeste()
        {
            var i = 1;

            for (Console.WriteLine("Iniciou"); i <= 0; Console.WriteLine(i))
            {
                i++; 
            }

            //for (1. Inicialização; 2. Condição ;4. Pós Execução)
            //{
            //3. Execução 
            //}
        }

        [TestMethod]
        public void ForApenasCondicaoTeste()
        {
            var i = 1;

            for (; i <=3;)
            {
                Console.WriteLine(i++);
            }
        }

        [TestMethod]
        public void ContinueTest()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i<=5)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
        }

        [TestMethod]
        public void BreakTest()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i > 5)
                {
                    break;
                }

                Console.WriteLine(i);
            }
        }
    }

}
