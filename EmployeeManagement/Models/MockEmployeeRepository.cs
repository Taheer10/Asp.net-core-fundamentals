namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "John", Department="IT", Email="John@gmail.com"},
                new Employee() { Id = 2, Name = "Chris", Department="IT", Email="Chris@gmail.com"},
                new Employee() { Id = 3, Name = "Park", Department="IT", Email="Park@gmail.com"},

            };
        }
        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }
    }
}
