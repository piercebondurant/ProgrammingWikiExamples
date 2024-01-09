using System;

namespace ProgrammingWikiExamples;

class Program
{
    public static void Main()
    {
        MySingleton mySingleton = MySingleton.Instance;
        mySingleton.DoSTuff();
    }
}