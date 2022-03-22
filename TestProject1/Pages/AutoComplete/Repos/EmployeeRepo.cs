using TestProject1.Pages.AutoComplete.Model;

namespace TestProject1.Pages.AutoComplete.Repos
{
    public class EmployeeRepo : IEmployeeRepo
    {
        public List<Employee> emps = new List<Employee>();


        public List<Employee> GetEmployees()
        {
            emps.Add(new Employee() { Id = 101, Name = "vijay", Country = "India" });
            emps.Add(new Employee() { Id = 102, Name = "Navdeep", Country = "Pakistan" });
            emps.Add(new Employee() { Id = 103, Name = "SakibUl Hasan", Country = "Bangladesh" });
            emps.Add(new Employee() { Id = 104, Name = "Rahul Dravid", Country = "India" });
            emps.Add(new Employee() { Id = 105, Name = "Krishna", Country = "Pakistan" });
            emps.Add(new Employee() { Id = 106, Name = "Dalip", Country = "India" });
            return emps;
        }
        public async Task<IEnumerable<Employee>> SearchListEmployee(string empName)
        {
            return await Task.FromResult(emps.Where(x => x.NameWithCountrry.ToLower().Contains(empName.ToLower())).ToList());
        }
    }
}
