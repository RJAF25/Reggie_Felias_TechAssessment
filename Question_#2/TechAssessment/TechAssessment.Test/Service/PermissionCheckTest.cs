using TechAssessment.Enum;
using TechAssessment.Service;
using TechAssessment.Service.Interface;

namespace TechAssessment.Test.Service
{
  [TestFixture]
  public class PermissionCheckTest
  {
    private IPermissionCheck _sut = new PermissionCheck();


    [TestCase("00000000", UserProfileType.VouchersEnabled, false)]
    [TestCase("00000010,", UserProfileType.VouchersEnabled, true)]
    [TestCase("11111111,,", UserProfileType.VouchersEnabled, true)]
    public void Check(string userSetting, UserProfileType userType, bool expectedOuput)
    {
      var result = _sut.Verify(userSetting, userType);
      Assert.AreEqual(expectedOuput, result);
    }

  }
}