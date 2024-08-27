using TechAssessment.DAO;
using TechAssessment.Service.Interface;

namespace TechAssessment.Service
{
  public class TextFileReader : ITextFileReader
  {
    public List<Users> GetUsers(string filePath)
    {
      List<Users> users = new();

      using StreamReader reader = new(filePath);
      string? line;
      while ((line = reader.ReadLine()) != null)
      {
        string[] values = line.Split(';');
        users.Add(new Users { ID = values[0].Trim(), Settings = values[1].Trim() });
      }
      return users;
    }
  }
}
