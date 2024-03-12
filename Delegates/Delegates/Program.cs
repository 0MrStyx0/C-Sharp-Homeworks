Console.WriteLine("Task 1");
int[] arr = new int[100];

Task1 task1 = Randomizer;
task1 += EvenNumbers;
task1 += OddNumbers;
task1 += PrimeNumbers;

task1(arr);
void Randomizer(int[] arr)
{
    Random random = new Random();

    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = random.Next(-100, 100);
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine("\n\n");
}

void EvenNumbers(int[] arr)
{
    Console.Write("Even numbers: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            Console.Write(arr[i] + " ");
        }
    }
    Console.WriteLine("\n\n");
}

void OddNumbers(int[] arr)
{
    Console.Write("Odd numbers: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 != 0)
        {
            Console.Write(arr[i] + " ");
        }
    }
    Console.WriteLine("\n\n");
}

void PrimeNumbers(int[] arr)
{
    Console.Write("Prime numbers: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (isPrime(arr[i]))
        {
            Console.Write(arr[i] + " ");
        }
    }
}

bool isPrime(int num)
{
    int a = 2;
    if (num == 0) return false;
    else if (num == 1) return false;
    else if (num < 0) num *= -1;

    while (a != num)
    {
        if (num % a == 0) return false;
        a++;
    }

    return true;
}

Console.WriteLine("\n\nTask 2");

DateTime time = DateTime.Now;

Action<DateTime> DelTime = TimeNow;
DelTime(time);

Func<DateTime, string> DelDate = DateNow;
Console.WriteLine(DelDate(time));


Predicate<string> delDayWeek = isWeekDayNow;
Console.WriteLine(delDayWeek("Tuesday"));

Func<int, int, int> TriangleSquare = SquareTriangle;
Console.WriteLine("Triangle Square: " + TriangleSquare(10, 5));

Action<int, int> rectangleSquare = RectangleSquare;
rectangleSquare(3, 4);
 
void TimeNow(DateTime time)
{
    Console.WriteLine(time.ToShortTimeString());
}

string DateNow(DateTime time)
{
    return time.ToShortDateString();
}

bool isWeekDayNow(string day)
{
    if (day == DateTime.Now.DayOfWeek.ToString())
    {
        return true;
    }
    else return false;
}

int SquareTriangle(int length,int heght)
{
    return (length * heght) / 2;
}

void RectangleSquare(int length,int width)
{
    Console.WriteLine("Rectang leSquare: " + length * width);
}  

delegate void Task1(int[] arr);