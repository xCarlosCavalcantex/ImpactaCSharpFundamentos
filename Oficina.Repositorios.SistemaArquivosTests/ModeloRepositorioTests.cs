using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class ModeloRepositorioTests
    {
        ModeloRepositorio modelo = new ModeloRepositorio();

        [TestMethod()]
        public void RetornarIdNomeMarca()
        {
            
            var modelos = modelo.SelecionarPorMarca(1);


            foreach (var model in modelos)
            {
                Console.WriteLine($"ID: { model.Id}\nModelo: {model.Nome} ({model.Marca.Nome})");
            }
        }

        [TestMethod()]
        public void SelecionarTest()
        {
           var modelos =  modelo.Selecionar(1);

            Assert.IsTrue(modelos.Id == 1);
            Assert.IsTrue(modelos.Nome == "Fusca");
            Assert.IsTrue(modelos.Marca.Nome == "VW");

            modelos = modelo.Selecionar(8);
            Assert.IsTrue(modelos == null);

        }
    }
}