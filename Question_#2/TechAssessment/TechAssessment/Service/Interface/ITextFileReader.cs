using TechAssessment.DAO;

namespace TechAssessment.Service.Interface
{
  public interface ITextFileReader
  {
    List<Users> GetUsers(string filePath);
  }
}