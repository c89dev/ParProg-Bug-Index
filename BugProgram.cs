using System.Diagnostics;
using System.Globalization;

namespace Parp1;

public class BugProgram
{
    public List<BUG> bugList;

    public BugProgram()
    {
        bugList = new List<BUG>();
    }
    public void MainMenu()
    {
        Console.WriteLine("Welcome to BugProgram");
        Console.WriteLine("1. Add new bug\n2. Show all bugs");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
            {
                NewBugEntry();
                break;
            }
            case "2":
            {
                ShowBugList();
                break;         
            }
        }
    }

    public void NewBugEntry()
    {
        BUG newEntry = new BUG();
        Console.Clear();
        Console.WriteLine("Name of bug");
        newEntry.Navn = Console.ReadLine();
        
        Console.Clear();
        Console.WriteLine("Kan den fly?\n 1. Ja \n 2. Nei");
        switch (Console.ReadLine())
        {
            case "1":
            {
                newEntry.Kanfly = true;
                break;
            }
            case "2":
            {
                newEntry.Kanfly = false;
                break;
            }
        }
        Console.Clear();
        
        
        Console.WriteLine("Kan den bite?\n 1. Ja \n 2. Nei");
        switch (Console.ReadLine())
        {
            case "1":
            {
                newEntry.Kanbite = true;
                break;
            }
            case "2":
            {
                newEntry.Kanbite = false;
                break;
            }
        }
        
        Console.Clear();
        
        Console.WriteLine("Er den farlig?\n 1. Ja \n 2. Nei");
        switch (Console.ReadLine())
        {
            case "1":
            {
                newEntry.Erfarlig = true;
                break;
            }
            case "2":
            {
                newEntry.Erfarlig = false;
                break;
            }
        }
        
        Console.Clear();

        Console.WriteLine("Kort beskrivelse:");
        newEntry.Beskrivelse = Console.ReadLine();
        Console.WriteLine("Bug lagt til.");
        Console.ReadLine();
        
        bugList.Add(newEntry);
        
        

    }

    public void ShowBugList()
    {
        Console.Clear();
        Console.WriteLine("Select bug for more info");
        foreach (var bug in bugList)
        {
            var index = bugList.IndexOf(bug);
            Console.WriteLine($"{index} - {bug.Navn}");
        }

        var selectedBugIndex = int.Parse(Console.ReadLine());
        SelectBug(selectedBugIndex);
        

    }

    public void SelectBug(int index)
    {
       Console.Clear();

       Console.WriteLine($"{bugList[index].Navn}");
       Console.WriteLine($"{bugList[index].Beskrivelse}");
       Console.ReadLine();
    }
    
    
}