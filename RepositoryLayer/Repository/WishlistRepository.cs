using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repository
{
    public class WishlistRepository
    {
        private readonly IConfiguration _config;
        private readonly string _connectionString;
        private readonly MySqlConnection _con = new();

        public WishlistRepository(IConfiguration configuration)
        {
            this._config = configuration;
            this._connectionString = _config.GetConnectionString("BookStoreDB");
            this._con.ConnectionString = this._connectionString;
        }
    }
}
