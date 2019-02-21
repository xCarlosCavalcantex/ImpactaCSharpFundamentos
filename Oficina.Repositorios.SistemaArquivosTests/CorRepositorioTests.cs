using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oficina.Dominio;


namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class CorRepositorioTests
    {
        [TestMethod()]
        public void SelecionarTest()
        {
            var corTest = new CorRepositorio();
            
            var cores = corTest.Selecionar();

            foreach (var cor in cores)
            {
                Console.WriteLine($"{cor} - {cor.Nome}");
            }
        }
    }
}