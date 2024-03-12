using LINQ.ClassFirm;



List<Firm> firms = new List<Firm>()
{
    new Firm()
  {
    Name = "KFC",
    Type = "Food",
    DirectorName = "James",
    DirectorSurame = "Kameron",
    Address = "USA",
    WorkersCount = 500,
    date = new DateTime(1998, 10, 25)
  },

    new Firm()
  {
    Name = "Access",
    Type = "Marketing",
    DirectorName = "Aleksandr",
    DirectorSurame = "Krilov",
    Address = "Russia",
    WorkersCount = 150,
    date = new DateTime(2006, 5, 12)
  },

    new Firm()
  {
    Name = "RallyFood",
    Type = "Food",
    DirectorName = "James",
    DirectorSurame = "Oswald",
    Address = "France",
    WorkersCount = 500,
    date = new DateTime(2023, 1, 30)
  },

    new Firm()
  {
    Name = "Microsoft Corporation",
    Type = "IT",
    DirectorName = "Bill",
    DirectorSurame = "Gates",
    Address = "USA",
    WorkersCount = 221000,
    date = new DateTime(1975, 4, 4)
  },

    new Firm()
  {
    Name = "Blue product",
    Type = "Chemistry",
    DirectorName = "Walter",
    DirectorSurame = "White",
    Address = "USA",
    WorkersCount = 2,
    date = new DateTime(2013, 11, 5)
  },

    new Firm()
  {
    Name = "Militech",
    Type = "Military",
    DirectorName = "Obri",
    DirectorSurame = "Wild",
    Address = "Night City",
    WorkersCount = 300,
    date = new DateTime(2023, 12, 3)
  },

    new Firm()
  {
    Name = "Arasaka",
    Type = "Bank",
    DirectorName = "Saburo",
    DirectorSurame = "Arasaka",
    Address = "Japan",
    WorkersCount = 100,
    date = new DateTime(1945, 9, 1)
  },

    new Firm()
  {
    Name = "BioTech",
    Type = "Technology",
    DirectorName = "Logan",
    DirectorSurame = "Paulwood",
    Address = "London",
    WorkersCount = 50,
    date = new DateTime(2019, 7, 10)
  },

    new Firm()
  {
    Name = "Pizza Hut",
    Type = "Food",
    DirectorName = "Karlos",
    DirectorSurame = "Espozito",
    Address = "Italy",
    WorkersCount = 90,
    date = new DateTime(2000, 12, 5)
  },

    new Firm()
  {
    Name = "MaxusWhite",
    Type = "Marketing",
    DirectorName = "Olly",
    DirectorSurame = "Black",
    Address = "London",
    WorkersCount = 45,
    date = new DateTime(2023, 11, 5)
   },

    new Firm()
  {
    Name = "Food Express",
    Type = "Food",
    DirectorName = "Genry",
    DirectorSurame = "Show",
    Address = "Germny",
    WorkersCount = 30,
    date = new DateTime(2022, 12, 5)
  },
};

Console.WriteLine("INFO:\n");
var Info = from el in firms
           select new
           {
               name = el.Name,
               type = el.Type,
               directorName = el.DirectorName,
               directorSurname = el.DirectorSurame,
               address = el.Address,
               createDate = el.date,
               workersCount = el.WorkersCount
           };


foreach (var firm in Info)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("NAME HASE Food: \n");
var Food = from el in firms
           where el.Name.StartsWith("Food") || el.Name.EndsWith("Food")
           select new
           {
               name = el.Name,
               type = el.Type,
               directorName = el.DirectorName,
               directorSurname = el.DirectorSurame,
               address = el.Address,
               createDate = el.date,
               workersCount = el.WorkersCount
           };

foreach (var firm in Food)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("MARKETING FIRMS: \n");
var Marketing = from el in firms
                where el.Type == "Marketing"
           select new
           {
               name = el.Name,
               type = el.Type,
               directorName = el.DirectorName,
               directorSurname = el.DirectorSurame,
               address = el.Address,
               createDate = el.date,
               workersCount = el.WorkersCount
           };
foreach (var firm in Marketing)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("MARKETING and IT FIRMS: \n");
var MarketingOrIT = from el in firms
                where el.Type == "Marketing" || el.Type == "IT"
                select new
                {
                    name = el.Name,
                    type = el.Type,
                    directorName = el.DirectorName,
                    directorSurname = el.DirectorSurame,
                    address = el.Address,
                    createDate = el.date,
                    workersCount = el.WorkersCount
                };
foreach (var firm in MarketingOrIT)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("WORKERS COUNT MORE THAN 100: \n");
var MoreThan100 = from el in firms
                  where el.WorkersCount > 100
                    select new
                    {
                        name = el.Name,
                        type = el.Type,
                        directorName = el.DirectorName,
                        directorSurname = el.DirectorSurame,
                        address = el.Address,
                        createDate = el.date,
                        workersCount = el.WorkersCount
                    };
foreach (var firm in MoreThan100)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("WORKERS COUNT BETWEEN 100 AND 300: \n");
var Between100And300 = from el in firms
                       where el.WorkersCount >= 100 && el.WorkersCount <= 300
                  select new
                  {
                      name = el.Name,
                      type = el.Type,
                      directorName = el.DirectorName,
                      directorSurname = el.DirectorSurame,
                      address = el.Address,
                      createDate = el.date,
                      workersCount = el.WorkersCount
                  };
foreach (var firm in Between100And300)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("LONDON FIRMS: \n");
var London = from el in firms
             where el.Address == "London"
                       select new
                       {
                           name = el.Name,
                           type = el.Type,
                           directorName = el.DirectorName,
                           directorSurname = el.DirectorSurame,
                           address = el.Address,
                           createDate = el.date,
                           workersCount = el.WorkersCount
                       };
foreach (var firm in London)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("DIRECTOR SURNAME IS White: \n");
var White = from el in firms
             where el.DirectorSurame == "White"
            select new
             {
                 name = el.Name,
                 type = el.Type,
                 directorName = el.DirectorName,
                 directorSurname = el.DirectorSurame,
                 address = el.Address,
                 createDate = el.date,
                 workersCount = el.WorkersCount
             };
foreach (var firm in White)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("DIRECTOR SURNAME IS Black and Firm name has White: \n");
var WhiteAndBlack = from el in firms
                    where el.DirectorSurame == "Black" && (el.Name.StartsWith("White") || el.Name.EndsWith("White"))
                    select new
            {
                name = el.Name,
                type = el.Type,
                directorName = el.DirectorName,
                directorSurname = el.DirectorSurame,
                address = el.Address,
                createDate = el.date,
                workersCount = el.WorkersCount
            };
foreach (var firm in WhiteAndBlack)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}

Console.WriteLine("Create date more than 2 years: \n");
var moreThan2Years = from el in firms
                     where (DateTime.Now - el.date).Days > (365 * 2)
            select new
            {
                name = el.Name,
                type = el.Type,
                directorName = el.DirectorName,
                directorSurname = el.DirectorSurame,
                address = el.Address,
                createDate = el.date,
                workersCount = el.WorkersCount
            };
foreach (var firm in moreThan2Years)
{
    Console.WriteLine($"Name: {firm.name}\nType: {firm.type}\n" +
        $"Director: {firm.directorName} {firm.directorSurname}\n" +
        $"Address: {firm.address}\nWorkers Count: {firm.workersCount}\nDate: {firm.createDate.ToShortDateString()}");
    Console.WriteLine("\n\n");
}