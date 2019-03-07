using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SqlServer
{
    public class CorRepositorio : RepositorioBase , ICorRepositorio
    {
        public void Atualizar(Cor cor)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Inserir(Cor cor)
        {
            throw new NotImplementedException();
        }

        public List<Cor> Selecionar()
        {
            var cores = new List<Cor>();

            var conexao = new SqlConnection(StringConexao); //Conecta

            conexao.Open(); //Abre Conexão

            const string instrucao = @"
                                SELECT [Id]
                                      ,[Nome]
                                  FROM [dbo].[Cor]
                                  Order by Nome";

            var comando = new SqlCommand(instrucao, conexao); //Pega o comando

            var registro = comando.ExecuteReader(); //Ler

            while (registro.Read())
            {
                cores.Add(Mapear(registro));
            }

            conexao.Close(); //Fecha conexão

            conexao.Dispose();  //Libera memoria
            comando.Dispose();
           

            return cores;
        }

        private Cor Mapear(SqlDataReader registro)
        {
            var cor = new Cor();

            cor.Id = Convert.ToInt32(registro["Id"]);
            cor.Nome = registro["Nome"].ToString();

            return cor;
        }

        public Cor Selecionar(int id)
        {
            Cor cor = null;

            using (var conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                using (var comando = new SqlCommand("CorSelecionar", conexao))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@id",id);

                    using (var registro = comando.ExecuteReader())
                    {
                        if (registro.Read())
                        {
                            cor = Mapear(registro);
                        }
                    }
                }
            }


            return cor;
        }
    }
}
