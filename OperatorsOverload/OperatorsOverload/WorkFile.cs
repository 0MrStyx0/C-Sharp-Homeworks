using OperatorsOverload.ClassMagazine;
using OperatorsOverload.ClassShop;

Console.WriteLine("Task 1");

Magazine magazine1 = new Magazine("Hugo boss", 15);
Magazine magazine2 = new Magazine("Baku", 20);

if(magazine1 > magazine2)
{
    Console.WriteLine("Magazine 1 worker numbers more than magazine 2");
}
else
{
    Console.WriteLine("Magazine 2 worker numbers more than magazine 1");
}

if (magazine1 == magazine2)
{
    Console.WriteLine("Equal numbers of workers");
}
else
{
    Console.WriteLine("Not Equal numbers of workers!!!");
}

magazine1.showWorkersCount();
magazine1 += 2; 
magazine1.showWorkersCount();
magazine1 -= 3;
magazine1.showWorkersCount();

Console.WriteLine("\nTask 2");

Shop shop1 = new Shop("Bravo", 200);
Shop shop2 = new Shop("Kosmos", 100);

if (shop1 > shop2)
{
    Console.WriteLine("shop 1 worker numbers more than shop 2");
}
else
{
    Console.WriteLine("shop 2 worker numbers more than shop 1");
}

if (shop1 == shop2)
{
    Console.WriteLine("Equal numbers of square");
}
else
{
    Console.WriteLine("Not Equal numbers of square!!!");
}

shop1.showSquareCount();
shop1 += 2;
shop1.showSquareCount();
shop1 -= 3;
shop1.showSquareCount();