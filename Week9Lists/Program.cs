string folderPath = @"C:\Users\Laptop\Documents\data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myshoppingList = new List<string>();
if(File.Exists(filePath))
{
    myshoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myshoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File {fileName} has been created");
    myshoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myshoppingList);
}

List<string> myShoppingList = GetItemsFromUser();
ShowItemsFromList(myShoppingList);




static List<string> GetItemsFromUser()
{
    List<string> userList = new List<string>();

    while (true)
    {
        Console.WriteLine("Add an item (add)/ Exit (exit):");
        string userChoise = Console.ReadLine();

        if (userChoise == "add")
        {
            Console.WriteLine("enter an item:");
            string userItem = Console.ReadLine();
            userList.Add(userItem);
        }
        else
        {
            Console.WriteLine("Bye!");
            break;
        }
    }
    return userList;
}



static void ShowItemsFromList(List<string> someList)
{
    Console.Clear();

    int listLength = someList.Count;
    Console.WriteLine($"You have aded {listLength} items to your shopping list.");

    int i = 1;
    foreach (string item in someList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}
