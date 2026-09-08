using System.Runtime.InteropServices.Swift;

namespace Session_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            object y = x;
            object s = "string";
            object z = new Program();
            //IDataStore store = new SqlDataStore(connectionString);
            int numberOfNumbers = 20;

            IDataStore src = new DatabaseDataStore();
            src.save("excretory function", 5);
            //Console.WriteLine(src.FilePath);
            //src.FilePath = "Hello.txt";
            //Console.WriteLine(src.FilePath);
        }
    }


}
