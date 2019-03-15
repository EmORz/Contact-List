namespace Data
{
    public class Employee
    {
        public string Department { get; set; }

        public string professionalLeve { get; set; }

        public string service { get; set; }

        public string roomNumber { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string email { get; set; }

        public string phoneNumber { get; set; }


        public override string ToString()
        {
            return Department+" => "+professionalLeve+" "+service+" "+roomNumber+" "+FirstName+" "+MiddleName+" "+LastName+" || "+email+" "+phoneNumber;
        }
        
    }
}