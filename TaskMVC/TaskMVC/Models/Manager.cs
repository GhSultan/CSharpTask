namespace TaskMVC.Models
{
    public class Manager
    {
        public int ManagerId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public ICollection<Department> Departments { get; set; }
    }

}
