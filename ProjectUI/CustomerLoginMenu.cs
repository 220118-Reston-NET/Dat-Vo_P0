using ProjectBL;
using ProjectModel;
namespace ProjectUI
{
    public class CustomerLoginMenu : IMenu
    {
        private IProjectBLCustomer _projectBL;
        public CustomerLoginMenu(IProjectBLCustomer p_projectBL)
        {
            _projectBL = p_projectBL;
        }
        public void Display()
        {
            Console.WriteLine("Enter your userID");
            Console.WriteLine("=====Customer List=====");
            Console.WriteLine("Names         ||Number        || Email                ||CustomerID");
            List<CustomerModel> listOfCustomer = _projectBL.GetAllCustomer();
            foreach(var item in listOfCustomer)
            {
                Console.WriteLine(Data.ManageSpaceName(item.name) + Data.ManageSpaceNumber(item.phonenumber)+ "    " + Data.ManageSpaceEmail(item.email) + "        " +item.customerID);
            }
        }

        public string UserChoice()
        {
            int UserInput = Int32.Parse(Console.ReadLine());
            //CustomerModel customer = new CustomerModel();
            List<CustomerModel> listOfCustomer = _projectBL.GetAllCustomer();
            foreach(var c in listOfCustomer)
            {
                if (c.customerID == UserInput)
                {
                    CurrentCustomer.SetCustomer(c);
                }
            }
            Console.Clear();
            Console.WriteLine("Hello " + CurrentCustomer.currentcustomer.name);
            return "Choose a store";
        }

    }
}