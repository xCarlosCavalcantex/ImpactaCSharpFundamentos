using Microsoft.VisualStudio.TestTools.UnitTesting;
using Oficina.Dominio;
using Oficina.Repositorios.SistemaArquivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos.Tests
{
    [TestClass()]
    public class VeiculoRepositorioTests
    {
        [TestMethod()]
        public void InserirTest()
        {
            var veiculo = new VeiculoPasseio();

            veiculo.Placa ="kct-1234";
            veiculo.Cor = new CorRepositorio().Selecionar(1);
            veiculo.Ano = 2014;
            veiculo.Cambio = Cambio.Manual;
            veiculo.Carroceria = Carroceria.Hatch;
            veiculo.Combustivel = Combustivel.Gasolina;
            veiculo.Modelo = new ModeloRepositorio().Selecionar(1);
            veiculo.Observacao = "Herbie 53";

         new VeiculoRepositorio().Inserir(veiculo);

            Assert.AreEqual(veiculo.Placa, "KCT-1234");

        }
    }
}