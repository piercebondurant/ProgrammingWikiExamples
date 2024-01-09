using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingWikiExamples.DesignPatterns.Singleton
{
    public class Singleton
    {
        //singleton class example
    }
}
public class MySingleton
{
    private static MySingleton instance = new MySingleton();
    private MySingleton() { }
    public static MySingleton Instance
    {
        get { return instance; }
    }
    public void DoSTuff()
    {
        Console.WriteLine("singleton called");
        Console.ReadKey();
    }
}
