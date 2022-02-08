using ProjectModel;
namespace ProjectDL
{
    public interface IRepository
    {
        //Employee methods
        EmployeeModel AddEmployee(EmployeeModel Employee);

        List<EmployeeModel> GetAllEmployee();
        
        EmployeeModel RemoveEmployee(EmployeeModel Employee);

        //Item methods

        ItemModel AddItem(ItemModel Item);

        List<ItemModel> GetAllItem();
        
        ItemModel RemoveItem(ItemModel Item);

        //Customer methods

        CustomerModel AddCustomer(CustomerModel Customer);

        List<CustomerModel> GetAllCustomer();
        
        CustomerModel RemoveCustomer(CustomerModel Customer);

        //StoreFront stuff
        StoreFrontModel AddStoreFront(StoreFrontModel Customer);

        List<StoreFrontModel> GetAllStoreFront();
        
        StoreFrontModel RemoveStoreFront(StoreFrontModel Customer);


    }
}
