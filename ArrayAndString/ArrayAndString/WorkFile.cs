using ArrayAndString.Tasks;

while (true)
{
    try
    {
        Console.WriteLine("Choose task");
        Console.WriteLine("1.Task 1\n2.Task 2\n3.Task 3\n4.Task 4" +
            "\n5.Task 5\n6.Task 6\n7.Task 7\n8.Exit");
        Console.Write("--> ");
        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Tasks.Task1();
                break;

            case 2:
                Tasks.Task2();
                break;

            case 3:
                Tasks.Task3();
                break;

            case 4:
                Tasks.Task4();
                break;

            case 5:
                Tasks.Task5();
                break;

            case 6:
                Tasks.Task6();
                break;

            case 7:
                Tasks.Task7();
                break;

            case 8:
                Console.Clear();
                return;

            default:
                throw new Exception("ERROR! DESCRIPTION: Wrong menu choice!");
        }
    }
    catch (OverflowException)
    {
        Console.WriteLine("ERROR! DESCRIPTION: Value is too larg for INT!");
        Thread.Sleep(2000);
        Console.Clear();
    }
    catch (FormatException)
    {
        Console.WriteLine("ERROR! DESCRIPTION: No letters or empty value! Only numbers in INT format!");
        Thread.Sleep(2000);
        Console.Clear();
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
        Thread.Sleep(2000);
        Console.Clear();
    }
}