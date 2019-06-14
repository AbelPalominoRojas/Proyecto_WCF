
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

        protected string getConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings["cndbEventos"].ToString();
        }

        public abstract bool create(T entity);

        public abstract bool edit(T entity);

        public abstract bool remove(T entity);

        public abstract T find(T entity);

        public abstract List<T> findAll();

    }
}
