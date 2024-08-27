using System.Text.Json;
using TechAssessment.DAO;
using TechAssessment.Service;
using TechAssessment.Service.Interface;

namespace TechAssessment.Test.Service
{
  [TestFixture]
  public class TextFileWriterTest
  {
    private ITextFileWriter _sut = new TextFileWriter();
    private ITextFileReader _textFileReader = new TextFileReader();

    [Test]
    public void Success()
    {
      List<Users> expectedResult = new()
      {
        new Users() { ID = "1", Settings = "00000000" },
        new Users() { ID = "2", Settings = "00000010" },
        new Users() { ID = "3", Settings = "11111111" }
      };

      _sut.WriteUsers(expectedResult, "DummyWriteUserList.txt");
      var result = _textFileReader.GetUsers("DummyWriteUserList.txt");

      var jsonResult = JsonSerializer.Serialize(result);
      var jsonExpected = JsonSerializer.Serialize(expectedResult);

      Assert.IsNotNull(result);
      Assert.That(jsonResult, Is.EqualTo(jsonExpected));
    }
  }
}