// See https://aka.ms/new-console-template for more information

using ParProgrameringUke2;

List<Studenter> student = new List<Studenter>()
{


new Studenter("Didrik","mørk og blond", 23),
new Studenter("Lisbeth","mørk brunt", 27)
};



bool runprogram = true;

while (runprogram)
{

    Console.WriteLine("velg elev du har lyst og se egenskapen til");
    Console.WriteLine($"1. Didrik");
    Console.WriteLine($"2. Lisbeth");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            student[0].introduction();
            Console.WriteLine("skriv inn tallet 1 for å gjøre en hobby");
            if(Console.ReadLine() == "1")
            {
                student[0].Hobby();
            }
            
            break;

        case "2":
            student[1].introduction();
            Console.WriteLine("skriv inn tallet 2 for å gjøre en hobby");
            if (Console.ReadLine() == "2")
            {
                student[1].Hobby2();
            }
            break;


        case "3":
            runprogram = false;
            break;

        default:
            Console.WriteLine("Wrong Choice");
            break;
    }
}


// Parprogrammering Lisbeth/Didrik


/*
 I denne oppgaven skal du prøve å programmere deg selv 🤓 Du har noen gitte egenskaper og ting du liker å gjøre.
Lag et hovedprogram der hver av deltakerene har sin klasse som kan printe ut en introduksjonstekst, og også utføre hver sine hobbyer.

Utskrift i konsollen kan feks se sånn her ut: 
Hei, jeg heter Bjarne! Jeg er 40 år gammel og jeg har svart hår
Se på meg, nå løper jeg i åkeren.
Nå sitter jeg og gamer litt farmingsimulator!

Hei, jeg heter Kurt! Jeg er 55 år gammel og jeg har brunt hår
Nå er jeg ute på fisketur.
Se, jeg kan også klatre høyt i klatreparken!
 */