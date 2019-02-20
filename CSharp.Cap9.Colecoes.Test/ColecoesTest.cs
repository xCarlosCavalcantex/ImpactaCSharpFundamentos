using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Cap9.Colecoes.Test
{
    [TestClass]
    public class ColecoesTest
    {
        private int i;

        [TestMethod]
        public void ListTeste()
        {
            var inteiros = new List<int>();

            inteiros.Add(128);
            inteiros.Add(1);
            inteiros.Add(2);
            inteiros.Add(-96);
            inteiros.Add(0);
            inteiros.Add(3);

            List<int> maisInteiros = new List<int>() { 2, 3, 5, 90};
            maisInteiros[0] = -56;

            inteiros.AddRange(maisInteiros);

            inteiros.Insert(0,-2);

            inteiros.Remove(2);
            inteiros.RemoveAt(0);
            inteiros.RemoveAll(e => e == 2);

            inteiros.Sort();

            var primeiro = inteiros[0];
            var ultimo = inteiros[inteiros.Count - 1];
            ultimo = inteiros.Last();
            primeiro = inteiros.First();

            for (i = 0; i<inteiros.Count; i++)
            {
                Console.WriteLine($"{i}: {inteiros[i]}");
            }
            //i = 0;
            Console.WriteLine("---------------------------------------------");
            foreach (var inteiro in inteiros)
            {
                Console.WriteLine($"{inteiros.IndexOf(inteiro)}: {inteiro}");
              //  i++;
            }
        }

        [TestMethod]
        public void DictionaryTest()
        {
            var feriados = new Dictionary<DateTime, string>();

            feriados.Add(new DateTime(2019,12,25),"Natal");
            feriados.Add(Convert.ToDateTime("01/01/2020"), "Ano Novo");
            feriados.Add(Convert.ToDateTime("25/01/2020"), "Aniversário de São Paulo");

            var natal = feriados[new DateTime(2019, 12, 25)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToShortDateString()}: {feriado.Value}");
            }

            Console.WriteLine(feriados.ContainsKey(new DateTime(2019, 12, 25)));
            Console.WriteLine(feriados.ContainsValue("Natal"));
            Console.WriteLine(feriados.ContainsKey(new DateTime(2019,01,01)));

        }

        [TestMethod]
        public void StackTest()
        {
            var pilha =new Stack<int>();
            pilha.Push(2);
            pilha.Push(5);
            pilha.Push(1);

            Assert.AreEqual(pilha.Pop(), 1); //Pop para remover
            Assert.AreEqual(pilha.Peek(), 5); //Peek espia o ultimo

            Console.WriteLine($"A pilha está vazia? {pilha.Count == 0}");
        }

        [TestMethod]
        public void QueueTest()
        {
            var fila = new Queue<int>();

            fila.Enqueue(6);
            fila.Enqueue(0);
            fila.Enqueue(2);

            Assert.AreEqual(fila.Dequeue(), 6);
            Assert.AreEqual(fila.Peek(), 0);
        }
    }
}
