using Microsoft.AspNetCore.Components;

namespace TestProject1.Pages.VirualizeCompTest
{
    public partial class VirtualComp
    {
        public string textShow = "Hello Vijay I am from partil class text";
        
        [Inject]
        public IEmployeeService employeeService { get; set; }
        public List<Employee> Employees { get; set; }

        protected override void OnInitialized()
        {
            Employees = employeeService.GetEmployees();
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }
    public class EmployeeService: IEmployeeService
    {
        public List<Employee> emps=new List<Employee>();

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
    }
    public interface IEmployeeService
    {
        List<Employee> GetEmployees();
    }

}
