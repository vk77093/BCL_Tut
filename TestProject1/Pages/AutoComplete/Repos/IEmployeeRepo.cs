using TestProject1.Pages.AutoComplete.Model;

namespace TestProject1.Pages.AutoComplete.Repos
{
    public interface IEmployeeRepo
    {
        List<Employee> GetEmployees();
        Task<IEnumerable<Employee>> SearchListEmployee(string empName);
    }
}