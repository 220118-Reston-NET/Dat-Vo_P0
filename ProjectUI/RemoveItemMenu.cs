using ProjectModel;
using ProjectBL;
namespace ProjectUI
{

    public class RemoveItemMenu : IMenu
    {
        private IProjectBLitem _projectBL;
        public RemoveItemMenu(IProjectBLitem p_projectBL)
        {
            _projectBL = p_projectBL;
        }
        public void Display()
        {
            Console.WriteLine("[0] Go back");
            Console.WriteLine("[1] Delete by ID");
            Console.WriteLine("=====Item List=====");
            Console.WriteLine("ID ||Name         || Price   || Category               || Description");
            List<ItemModel> listOfItem = _projectBL.GetAllItem();
            foreach(var item in listOfItem)
            {
                Console.WriteLine(Data.ManageSpacePrice(item.ItemID) + Data.ManageSpaceName(item.ItemName) + Data.ManageSpacePrice(item.ItemPrice) + "    " + Data.ManageSpaceName(item.ItemCategory) + "          " +item.ItemDescription);
            }
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "0":
                    Console.Clear();
                    return "Item List";
                case "1":
                    //Console.Clear();
                    Console.WriteLine("Enter the ID to delete item");
                    int userInput2 = Int32.Parse(Console.ReadLine());
                    Log.Information("AWAITING ITEM ID INPUT TO DELETE ITEM");
                    ItemModel item = new ItemModel();
                    List<ItemModel> listOfItem = _projectBL.GetAllItem();
                    //item = listOfItem[userInput2];
                    foreach(var i in listOfItem)
                    {
                        if (i.ItemID == userInput2)
                        {
                            item = i;
                        }
                    }
                    if (item.ItemID == 0)
                    {
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        Log.Information("INVALID INPUT DETECTED, REROUTING TO REMOVE ITEM MENU");
                        return "remove item";
                    }
                    else
                    {
                        _projectBL.RemoveItem(item);
                        Console.Clear();
                        Log.Information("SUCCESSFULLY REMOVED ITEM");
                        Console.WriteLine("Item Removed!");
                        return "Item List";
                    } 
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    Log.Information("INVALID INPUT DETECTED, REROUTING TO REMOVE AN ITEM MENU");
                    return "remove item";
            }
        }
    }


}