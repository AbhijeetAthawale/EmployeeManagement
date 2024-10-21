namespace Employee_Management.Models.Entity
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public String Designation { get; set; }
        public DateTime Joining_Date{ get; set; }
        public string Phone { get; set; }

    }
}
