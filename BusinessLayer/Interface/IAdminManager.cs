using CommonLayer;

namespace BusinessLayer.Interface
{
    public interface IAdminManager
    {
        string GenerateToken(int adminId, string emailId);
        AdminInfoModel GetAdminByEmail(string email);
        ResponseModel<AdminInfoModel> Login(LoginModel adminData);
    }
}