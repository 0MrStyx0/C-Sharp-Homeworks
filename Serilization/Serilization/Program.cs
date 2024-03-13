using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using System.Xml.Serialization;


//List<Bill> BillList = new List<Bill>()
//{
//    new Bill("Appartments",10,31,2,10),
//    new Bill("Education",100,13,2,10),
//    new Bill("Check 1",200,5,50,1),
//    new Bill("Treatment",500,20,50,3),
//    new Bill("Check2",25,7,30,0),
//    new Bill("Kommunalka",15,31,15,5)
//};

string path = "Bills.xml";
//using (FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write)) 
//{
//    XmlSerializer serializer = new XmlSerializer(typeof(List<Bill>));
//    serializer.Serialize(stream, BillList);
//}

List<Bill> billsFromFile = null;

using (FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read))
{
    XmlSerializer serializer = new XmlSerializer(typeof(List<Bill>));
    billsFromFile=(List<Bill>)serializer.Deserialize(stream);
}

foreach(var check in billsFromFile)
{
    Console.WriteLine($"Name: {check.Name}\nPayment per day:{check.paymentPerDay}\nDay count: {check.DayCount}\nForfeit for day: {check.ForfeitForDay}" +
        $"\nDelay day count: {check.DelayDayCount}\nSum: {check.Sum}\nForfeit: {check.Forfeit}\nTOTALSUM: {check.TotalSum}");
    Console.WriteLine("\n\n");
}

[Serializable]
public class Bill
{
    public string Name {  get; set; }
    public int paymentPerDay {  get; set; }
    public int DayCount { get; set;}
    public int ForfeitForDay {  get; set; }
    public int DelayDayCount {  get; set; }
    public int Sum {  get; set; }
    public int Forfeit {  get; set; }
    public int TotalSum {  get; set; }

    public Bill() { }   
    public Bill(string Name,int paymentPerDay, int DayCount, int ForfeitForDay, int DelayDayCount)
    {
        this.Name = Name;
        this.paymentPerDay = paymentPerDay;
        this.DayCount = DayCount;
        this.ForfeitForDay = ForfeitForDay;
        this.DelayDayCount = DelayDayCount;

        this.Sum = this.paymentPerDay * this.DayCount;
        this.Forfeit=this.ForfeitForDay * this.DelayDayCount;
        this.TotalSum = this.Sum * this.Forfeit;
    }
}



