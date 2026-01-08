namespace Parp1;

public class BUG
{
    public string Navn { get; set; }
    public bool Kanfly {get; set;}
    public bool Kanbite {get; set;}
    public bool Erfarlig {get; set;}
    public string Beskrivelse {get; set;}


    public void Visinfo()
    {
        Console.WriteLine($"Navn: {Navn}");
        Console.WriteLine($"Kanfly: {Kanfly}");
        Console.WriteLine($"Kanbite: {Kanbite}");
        Console.WriteLine($"Erfarlig: {Erfarlig}");
        Console.WriteLine($"Beskrivelse {Beskrivelse}");

        if(Erfarlig)
        { 
            Console.WriteLine("be careful its farlig");
        }
        else
        {
            Console.WriteLine("be careful its not farlig");
        }

        Console.WriteLine("**********************");
    }

    public void BugList()
    {
        // foreach(var bug in bugs)
    }

}