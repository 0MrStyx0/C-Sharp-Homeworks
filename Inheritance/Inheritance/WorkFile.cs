using Inheritance.ClassMusicalInstrument;
using Inheritance.ClassDevice;
using Inheritance.ClassMoney;
using Inheritance.ClassWorker;

Console.WriteLine("Task 1");
Money money1 = new Money("$");
money1.setValue(10, 50);
money1.ShowValue();

Product product1 = new Product("Milk", "$");
product1.setValue(10, 50);
product1.ShowValue();
product1.ReducePrice(5, 25);
product1.ShowValue();


Console.WriteLine("\nTask 2");
Kettle kettle = new Kettle("Russian soul");
kettle.Sound();
kettle.Show();
kettle.Desc();
Console.WriteLine();

Car car = new Car("BMV");
car.Sound();
car.Show();
car.Desc();
Console.WriteLine();

Ship ship = new Ship("Yamato");
ship.Sound();
ship.Show();
ship.Desc();
Console.WriteLine();

Microwave microwave = new Microwave("Sony");
microwave.Sound();
microwave.Show();
microwave.Desc();
Console.WriteLine();

Console.WriteLine("Task 3");

Violin violin = new Violin("Stradivarius");
violin.Sound();
violin.Show();
violin.Desc();
violin.HistoryShow();
Console.WriteLine();

Cello cello = new Cello("CelloVC");
cello.Sound();
cello.Show();
cello.Desc();
cello.HistoryShow();
Console.WriteLine();

Trombone Trombone = new Trombone("Bone");
Trombone.Sound();
Trombone.Show();
Trombone.Desc();
Trombone.HistoryShow();
Console.WriteLine();

Ukulele Ukulele = new Ukulele("Uku");
Ukulele.Sound();
Ukulele.Show();
Ukulele.Desc();
Ukulele.HistoryShow();
Console.WriteLine();

Console.WriteLine("Task 4");

President president = new President("Baku", 12);
president.Print();
Console.WriteLine();

Security Security = new Security("Gun", 5);
Security.Print();
Console.WriteLine();

Manager Manager = new Manager(3, 20);
Manager.Print();
Console.WriteLine();

Engineer Engineer = new Engineer("Yellow", 12);
Engineer.Print();
Console.WriteLine();