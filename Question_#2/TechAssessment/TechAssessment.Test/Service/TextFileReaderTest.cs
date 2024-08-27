using System.Text.Json;
using TechAssessment.DAO;
using TechAssessment.Service;
using TechAssessment.Service.Interface;

namespace TechAssessment.Test.Service
{
  [TestFixture]
  public class TextFileReaderTest
  {
    private ITextFileReader _sut = new TextFileReader();

    [Test]
    public void Success()
    {
      List<Users> expectedResult = new()
      {
        new Users() { ID = "1", Settings = "00000000" },
        new Users() { ID = "2", Settings = "00000010" },
        new Users() { ID = "3", Settings = "11111111" }
      };

      var result = _sut.GetUsers("DummyUserList.txt");
      var jsonResult = JsonSerializer.Serialize(result);
      var jsonExpected = JsonSerializer.Serialize(expectedResult);

      Assert.IsNotNull(result);
      Assert.That(jsonResult, Is.EqualTo(jsonExpected));
    }
  }
}