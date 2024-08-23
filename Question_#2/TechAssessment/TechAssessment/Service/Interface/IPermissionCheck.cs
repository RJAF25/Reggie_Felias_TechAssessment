using TechAssessment.Enum;

namespace TechAssessment.Service.Interface
{
  public interface IPermissionCheck
  {
    bool Verify(string userSetting, UserProfileType userType);
  }
}