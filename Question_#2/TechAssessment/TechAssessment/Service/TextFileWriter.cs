using TechAssessment.DAO;
using TechAssessment.Service.Interface;

namespace TechAssessment.Service
{
  public class TextFileWriter : ITextFileWriter
  {
    public void WriteUsers(List<Users> userList, string filePath)
    {
      using StreamWriter writer = new StreamWriter(filePath, false);
      foreach (Users user in userList)
      {
        writer.WriteLine($"{user.ID};{user.Settings}");
      }
    }
  }
}