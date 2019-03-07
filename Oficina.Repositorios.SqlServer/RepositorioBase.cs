using System.Configuration;

namespace Oficina.Repositorios.SqlServer
{
    public abstract class RepositorioBase
    {
        protected string StringConexao { get; } = ConfigurationManager.ConnectionStrings["oficinaSqlServer"].ConnectionString;
    }
}