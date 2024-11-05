namespace Tut5_s20123.Adapter
{
    public class EmployeeAdapter : ITarget
    {
        private readonly BillingSystem thirdPartyBillingSystem = new();

        public void ProcessCompanySalary(string[,] employeesArray)
        {
            List<Employee> employeeList = new List<Employee>();

            for (int i = 0; i < employeesArray.GetLength(0); i++)
            {
                int id = int.Parse(employeesArray[i, 0]);
                string name = employeesArray[i, 1];
                string designation = employeesArray[i, 2];
                decimal salary = decimal.Parse(employeesArray[i, 3]);

                Employee emp = new Employee(id, name, designation, salary);
                employeeList.Add(emp);
            }

            Console.WriteLine("Adapter converted employee string array to List<Employee> and delegated to the third-party billing system.\n");
            thirdPartyBillingSystem.ProcessSalary(employeeList);
        }
    }
}