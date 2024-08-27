using TechAssessment.DAO;

namespace TechAssessment.Service.Interface
{
  public interface ITextFileWriter
  {
    public void WriteUsers(List<Users> userList, string filePath);
  }
}