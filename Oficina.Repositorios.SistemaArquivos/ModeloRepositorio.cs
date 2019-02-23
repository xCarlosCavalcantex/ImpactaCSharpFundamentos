using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class ModeloRepositorio
    {
        private XDocument arquivoXml = XDocument.Load(ConfigurationManager.AppSettings["caminhoArquivoModelo"]);

        public List<Modelo> SelecionarPorMarca(int marcaId)
        {
            var modelos = new List<Modelo>();

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (elemento.Element("marcaId").Value == marcaId.ToString())
                {
                    var modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;

                    var marca = new MarcaRepositorio();

                    modelo.Marca = marca.Selecionar(marcaId);

                    modelos.Add(modelo);
                }

            }

            return modelos;
        }

        public Modelo Selecionar(int id)
        {
            Modelo modelo = null;

            foreach (var elemento in arquivoXml.Descendants("modelo"))
            {
                if (elemento.Element("id").Value == id.ToString())
                {
                    modelo = new Modelo();
                    modelo.Id = Convert.ToInt32(elemento.Element("id").Value);
                    modelo.Nome = elemento.Element("nome").Value;

                    var marca = new MarcaRepositorio();

                    modelo.Marca = marca.Selecionar(Convert.ToInt32(elemento.Element("marcaId").Value));

                    break;
                }

            }

            return modelo;
        }

    }
    }
