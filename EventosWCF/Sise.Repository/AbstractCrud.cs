
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Sise.Repository
{
    public abstract class AbstractCrud<T>
    {
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;
        protected SqlDataReader sqlDataReader;
        protected String sqlQuery;

        protected string nombreConexcion()
        {
            return ConfigurationManager.ConnectionStrings["cndbEventos"].ToString();
        }

        public abstract bool registrar(T entity);

        public abstract bool actualizar(T entity);

        public abstract bool eliminar(T entity);

        public abstract T buscar(T entity);

        public abstract List<T> listar();

    }
}
