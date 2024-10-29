public class Hologram
{
    // Name of the room.
    string name = "Hologram";

    // Short introduction to the room. Only shown once?
    // Add a continue command to go to first Chapter.
    string description = """
        Du kommer in i ett kolsvart rum. Plötsligt börjar att bli blekna fram och du inser att du befinner dig på en strand på en öde ö. 
        """;

    // List of all the items at the start of a room.
    List<GameObject> chapterItems =
        new()
        {
            new Rock("Sharp rock", "en vass sten", "branch"),
            new Rock("rock", "en sten", "fruit"),
            new Branch("Branch", "en gren", "stone"),
            new GameObject("Fish", "fishes"),
        };

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "Strand",
                """
                Till höger om dig har du en livlig regnskog fylld av olika djur och växt arter och till vänster så har du
                en lagun med fint och klart vatten som man kan se rakt igenom till botten på. I vattnet simmar fiskar och
                vattendjur av olika arter. När du tittar fram ser du hur strandkanten är fylld med palmer som bär frukt av
                olika sorter. Plötsligt börjar magen att kurra och du känner dig hungrig.
                Du ser en bemannad fyr på andra sidan ön som sticker upp ovanför trädtopparna och bestämmer dig för att ta
                dig dit i hopp om att bli räddad. Men först måste du äta dig mätt, så att du orkar med alla dagens utmaningar.
                Du funderar på vad du kan äta och ser fiskarna simma i det grunda vattnet nära strandkanten i lagunen och du
                ser frukt i trädtopparna som är utom räck håll. Du funderar på hur du ska få tag på maten innan den kan ätas.
                På gränsen mellan strand och regnskog ligger det grenar och stenar på marken och kommer på att du antingen
                kan bygga ett spjut av en <gren> och en vass <sten>, som du använder för att fånga fisken eller att du letar
                rätt på en tillräckligt kraftig sten som du använder för att kasta mot frukten i trädtopparna så att frukten
                ramlar ner.
                """
            ),
            // Optional Chapters after the main one.
            new Chapter(
                "Regnskog",
                """
                Spelaren har nu påbörjat sin färd mot den bemannade fyren och behöver först passera den täta regnskogen för
                att ta sig fram. På vägen behöver spelaren leta efter föremål som kan användas till att bygga någon form av
                vindskydd över natten, så att spelaren kan få vila innan spelaren behöver fortsätta sin långa färd mot den bemannade
                fyren. Föremål som ska samlas är: lianer, grenar, palmträdsblad, och stenar. Spelaren behöver nu färdas genom
                regnskogen som är rik på olika arter av djur och insekter, med hög luftfuktighet och djur som lurar där man inte
                kan se dem, bakom fallna träd, grenar och hängande lianer, samt mycket detaljer av varierande slag och intryck.
                Från bergsväggarna rinner det vatten via vattenfall som mynnar från grundvattenkällor, med rent dricksvatten som
                samlas i trädens löv och blad som skålar man kan dricka ur. På stigarna finns det mycket man kan snubbla på som
                krokiga rötter, stenblock och dylikt. Runt omkring kan man se exotiska fåglar och apor i trädens grenar, ormar och
                färgglada grodor i omnejd. I slutet på stigen som spelaren har följt kommer spelaren fram till en bergsvägg med en
                grotta framför sig. Vid öppningen finns det grenar, stenar, lianer och fallna palmträdsblad liggandes på marken.
                Spelaren behöver nu fatta ett beslut. Ska spelaren klättra upp i ett träd för att sova bland grenarna, eller gå in
                i den mörka grottan, eller bygga sig ett vindskydd vid öppningen av grottan som man kan sova i.  
                """,
                new()
                {
                    new GameObject("chapter 2 itemName", "chapter 2 item description"),
                    new GameObject("chapter 2 itemName 2", "chapter 2 item description 2"),
                }
            ),
        };

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, story, chapterItems, new BeachMenu());
        return room;
    }
}
