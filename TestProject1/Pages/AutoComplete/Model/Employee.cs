namespace TestProject1.Pages.AutoComplete.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Country { get; set; }
        public string NameWithCountrry => $"{this.Name} , {this.Country}";
    }
}
