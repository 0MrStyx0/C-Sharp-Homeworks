using BasicHomeWork.Checker;
using BasicHomeWork.Tasks;



while (true)
{
    Console.WriteLine("Choose task\n1.Task 1\n2.Task 2\n" +
        "3.Task 3\n4.Task 4\n5.Task 5\n6.Task 6\n7.Task 7\n8.Exit");
    Console.Write("--> ");
    var choice = Console.ReadLine();
    if (!Checker.checkMenuOrPercent(choice))
    {
        Checker.PrintError();
    }
    else
    {
        switch (Convert.ToInt32(choice))
        {
            case 1:
                Console.Clear();
                Tasks.Task1();
                break;

            case 2:
                Console.Clear();
                Tasks.Task2();
                break;

            case 3:
                Console.Clear();
                Tasks.Task3();
                break;

            case 4:
                Console.Clear();
                Tasks.Task4();
                break;

            case 5:
                Console.Clear();
                Tasks.Task5();
                break;

            case 6:
                Console.Clear();
                Tasks.Task6();
                break;

            case 7:
                Console.Clear();
                Tasks.Task7();
                break;

            case 8:
                Console.Clear();
                return;
            default:
                Checker.PrintError();
                break;
        }
    }
}