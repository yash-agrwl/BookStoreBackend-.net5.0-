using CommonLayer;

namespace BusinessLayer.Interface
{
    public interface IUserManager
    {
        ResponseModel<RegisterModel> Signup(RegisterModel userData);
        ResponseModel<UserModel> Login(LoginModel userData);
        UserModel GetUserByEmail(string email);
        UserModel GetUserById(int id);
        ResponseModel<ResetPasswordModel> ResetPassword(ResetPasswordModel userData);
        string ForgotPassword(string email);
        string GenerateToken(int userId, string emailId);
    }
}