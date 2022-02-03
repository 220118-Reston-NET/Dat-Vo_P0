namespace ProjectUI
{
    public class ItemListMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Please Select A Location");
            Console.WriteLine("[0] Back");
            Console.WriteLine("[1] View Item List");
            Console.WriteLine("[2] Add Item");
            Console.WriteLine("[3] Remove Item");
        }

        public string UserChoice()
        {
            int UserInput = Int32.Parse(Console.ReadLine());

            if (UserInput == 0)
            {
                Console.Clear();
                return "go back";
            }
            else if (UserInput == 1)
            {
                Console.Clear();
                return "view item list";
            }
            else if (UserInput == 2)
            {
                Console.Clear();
                return "add item";
            }
            else if (UserInput == 3)
            {
                Console.Clear();
                return "remove item";
            }
            else
            {
                return "InvalidInput";
            }
        }
    }
}