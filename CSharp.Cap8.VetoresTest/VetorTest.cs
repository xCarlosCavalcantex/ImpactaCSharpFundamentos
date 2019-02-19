using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharp.Cap8.VetoresTest
{
    [TestClass]
    public class VetorTest
    {
        [TestMethod]
        public void InicializacaoTest()
        {
            var inteiros = new int[5];

            inteiros[0] = 34;
            inteiros[1] = 21;
            inteiros[4] = 42;

            var decimais = new decimal[] { 8, 3.7m, 2.9m, 7.89m };

            decimal[] outroDecimais = { 2.1m, 2.36m, 10 };

            foreach (var @decimal in decimais)
            {
                Console.WriteLine(@decimal);
            }

            for (int i = 0 ; i  <decimais.Length; i ++)
            {
                Console.WriteLine(decimais[i]);
            }
        }

        [TestMethod]
        public void RedimensionamentoTeste()
        {
            var decimais = new decimal[] { 0.5m, 1, 0.8m };

            Array.Resize(ref decimais, 5);

            decimais[3] = 1.59m;
        }

        [TestMethod]
        public void OrdenacaoTest()
        {
            var decimais = new decimal[] { 15.63m, 0.5m, 0.8m };

            Array.Sort(decimais);

            Assert.AreEqual(decimais[0], 0.5m);
        }

        [TestMethod]
        public void ParamsTest()
        {
            var decimais = new decimal[] { 15.63m, 0.5m, 0.8m };

            Console.WriteLine(MediaVetor(decimais));

        }

        private decimal Media(decimal valor1, decimal valor2)
        {
            return (valor1 + valor2)/2;
            
        }

        private decimal MediaVetor(decimal[] valores)
        {
            var soma= 0m;

            //foreach (decimal valor in valores)
            //{
            //    soma += valor;
            //}

            for (int i = 0; i < valores.Length; i++)
            {
                soma += valores[i];
            }
            return soma / valores.Length;
            
        }

      
    }
}
