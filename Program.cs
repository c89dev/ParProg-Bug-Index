namespace Parp1;

class Program
{
    static void Main(string[] args)
    {
        BugProgram bugProgram = new BugProgram();
        
        
        Mygg mygg = new Mygg();
        mygg.Navn = "Myggen";
        mygg.Erfarlig = true;
        
        bugProgram.bugList.Add(mygg);

        while (true)
        {
            bugProgram.MainMenu();
        }

        Console.ReadLine();
    }
    
    
}