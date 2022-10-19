 namespace MultiThread
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EmployeeDetail model = new EmployeeDetail();

            model.EmployeeName = "Dwyane";
            model.PhoneNumber = 1234567890;
            model.Address = "Mumbai";
            model.Department = "HR";
            model.Gender = 'M';
            model.BasicPay = 22000;
            model.Deduction = 1500;
            model.TaxablePay = 200;
            model.Tax = 300;
            model.NetPay = 2500;
            model.City = "MP";
            model.Country = "India";
                            
            model.EmployeeName = "Johnson";
            model.PhoneNumber = 1234567890;
            model.Address = "Mumbai";
            model.Department = "HR";
            model.Gender = 'M';
            model.BasicPay = 22000;
            model.Deduction = 1500;
            model.TaxablePay = 200;
            model.Tax = 300;
            model.NetPay = 2500;
            model.City = "Mumbai";
            model.Country = "India";

            model.EmployeeName = "parley";
            model.PhoneNumber = 1234567890;
            model.Address = "Mumbai";
            model.Department = "HR";
            model.Gender = 'M';
            model.BasicPay = 22000;
            model.Deduction = 1500;
            model.TaxablePay = 200;
            model.Tax = 300;
            model.NetPay = 2500;
            model.City = "UP";
            model.Country = "India";

            EmployeeOperations repo = new EmployeeOperations();
           // repo.GetAllEmployee();
            // DateTime startDate = DateTime.Now;
            repo.AddEmployee(model);
            //DateTime endDate = DateTime.Now;
          //  Console.WriteLine("Duration with thread" + (startDate - endDate));
        }
    }
}