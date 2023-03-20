public class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        Console.WriteLine("Data " + storedData[0] + " Berisi : 13, yang didimpan pada waktu " + inputDates[0]);
        Console.WriteLine("Data " + storedData[1] + " Berisi : 02, yang didimpan pada waktu " + inputDates[1]);
        Console.WriteLine("Data " + storedData[2] + " Berisi : 21, yang didimpan pada waktu " + inputDates[2]);

    }
}
class Program
{
    static void Main(string[] args)
    {
        SimpleDataBase<int> data = new SimpleDataBase<int>();
        data.AddNewData(1);
        data.AddNewData(2);
        data.AddNewData(3);
        data.PrintAllData();
    }
}
