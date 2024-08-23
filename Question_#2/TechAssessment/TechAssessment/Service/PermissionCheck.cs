using TechAssessment.Enum;
using TechAssessment.Service.Interface;

namespace TechAssessment.Service
{
  public class PermissionCheck : IPermissionCheck
  {
    public bool Verify(string userSetting, UserProfileType userType)
    {
      if (string.IsNullOrEmpty(userSetting))
      {
        return false;
      }

      char result = userSetting[(int)userType - 1];
      return (result == '1') ? true : false;
    }
  }
}