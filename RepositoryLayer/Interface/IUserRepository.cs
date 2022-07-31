using CommonLayer;

namespace RepositoryLayer.Interface
{
    public interface IUserRepository
    {
        string ForgotPassword(string email);
        UserModel GetUserByEmail(string email);
        UserModel GetUserById(int id);
        ResponseModel<UserModel> Login(LoginModel userData);
        ResponseModel<ResetPasswordModel> ResetPassword(ResetPasswordModel userData);
        ResponseModel<RegisterModel> Signup(RegisterModel userData);
    }
}