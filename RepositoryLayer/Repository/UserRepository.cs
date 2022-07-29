using CommonLayer;
using Microsoft.Extensions.Configuration;

namespace RepositoryLayer.Repository
{
    public class UserRepository
    {
        public IConfiguration Configuration { get; }

        public UserRepository(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ResponseModel<RegisterModel> Register(RegisterModel userData)
        {
        }
    }
}
