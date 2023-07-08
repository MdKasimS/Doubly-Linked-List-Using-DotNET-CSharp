using DSA;

internal class Program
{
    public static DoublyLinkedList list = new DoublyLinkedList();

    private static void ContinueTest()
    {
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("This is Singly Linked List Implementation\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        Console.Clear();
        int choice;
        string[] MenuItems = { "Append Data", "Prepend Data", "Insert Data", "Display Data", "Update Data", "Delete Element", "Rotate Forward", "Rotate Backward", "Exit" };
        int data;

        do
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < MenuItems.Length; ++i)
            {
                Console.WriteLine($"{i + 1} {MenuItems[i]}");
            }
            Console.Write("Enter Your Choice : ");
            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[0]}]---");

                    Console.Write("Enter Data : ");
                    int.TryParse(Console.ReadLine(), out data);
                    list.AppendList(data);

                    Console.Clear();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[1]}]---");

                    Console.Write("Enter New Head Data : ");
                    int.TryParse(Console.ReadLine(), out data);
                    list.PrependList(data);

                    Console.Clear();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[2]}]---");

                    Console.Write("Enter Data : ");
                    int.TryParse(Console.ReadLine(), out data);

                    Console.Write("Enter Position Where To Insert : ");
                    int.TryParse(Console.ReadLine(), out choice);
                    list.InsertInList(data, choice);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[3]}]---");

                    list.DisplayList();

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[4]}]---");

                    Console.Write("Enter Position To Update : ");
                    int.TryParse(Console.ReadLine(), out data);

                    Console.WriteLine("Enter The New Data : ");
                    int.TryParse(Console.ReadLine(), out choice);

                    list.UpdateNode(choice, data);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[5]}]---");

                    Console.Write("Enter Position Where To Delete : ");
                    int.TryParse(Console.ReadLine(), out data);
                    list.DeletListNode(data);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 7:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[6]}]---");

                    Console.Write("Enter Number Of Position To Rotate By : ");
                    int.TryParse(Console.ReadLine(), out data);
                    list.RotateForward(data);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine($"---[{MenuItems[7]}]---");
                    Console.Write("Enter Number Of Position To Rotate By : ");
                    int.TryParse(Console.ReadLine(), out data);

                    list.RotateBackward(data);

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 9:
                    Console.Clear();
                    Console.WriteLine("Application Exited...");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case 79: //It is hidden and only used for testing purpose. You can write your custom tests here. Take help ContinueTest() method see cler and neat output on console.
                    Console.Clear();
                    Console.WriteLine("Running Tests.....");

                    int test = 10;
                    while (test > 0)
                    {
                        list.AppendList(45);
                        list.AppendList(46);
                        list.AppendList(47);
                        list.DisplayList();
                        ContinueTest();

                        list.RotateBackward(1);
                        list.DisplayList();
                        ContinueTest();

                        list.RotateBackward(1);
                        list.DisplayList();
                        ContinueTest();

                        list.RotateBackward(1);
                        list.DisplayList();
                        ContinueTest();

                        list.RotateBackward(1);
                        list.DisplayList();
                        ContinueTest();

                        list.RotateForward(1);
                        list.DisplayList();
                        ContinueTest();
                        list.RotateForward(1);
                        list.DisplayList();
                        ContinueTest();
                        list.RotateForward(1);
                        list.DisplayList();
                        ContinueTest();
                        list.RotateForward(1);
                        list.DisplayList();
                        ContinueTest();

                        test = 0;

                    }
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Please Enter Valid Choice");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        } while (choice != 9);
    }
}