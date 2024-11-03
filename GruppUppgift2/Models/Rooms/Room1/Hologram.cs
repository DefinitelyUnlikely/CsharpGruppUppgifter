public class Hologram
{
    // Name of the room.
    string name = "Hologram";

    // Short introduction to the room. Only shown once?
    // Add a continue command to go to first Chapter.
    string description =
        """
        You enter a pitch black room and feel lost, then walk forward a bit and fall backwards onto the ground. 
        When you rest your hands on the ground for support, you suddenly feel that you are holding something fine-grained, 
        it feels like sand. It suddenly gets brighter. You stand up to look around and you realize you are stranded on a deserted island.
        """;

    // List of all the items at the start of a room.
    List<GameObject> chapterItems =
        new()
        {
            new Sharpstone("sharp stone", "An arrow shaped sharpstone, suitable for creating tools. ", "stick"),
            new Stick("stick", "A straight stick, suitable for creating tools. ", "sharpstone"),
            new Spear("spear", "A deadly spear that you can use to hunt for food with.", "fish"),
            new Fish("fish", "A food source, perfect for eating. "),
        };

    List<Chapter> chapters =
        new()
        {
            // First Chapter is the main description of the room. (required)
            new Chapter(
                "The Beach",
                """
                To your right you have a lively rainforest filled with different animal and plant species
                and to your left you have a lagoon with fine and clear water, which you can see right through to the bottom.
                Fish and aquatic animals of various species swim in the water. When you look forward, you see how the shore
                is filled with palm trees bearing fruit of various kinds. Suddenly your stomach starts rumbling and you feel hungry.
                You see a manned lighthouse on the other side of the island sticking up above the treetops
                and decide to make your way there in hopes of being rescued. But first you have to eat your fill before the long journey,
                so that you can cope with all the day's challenges that await you. You think about what you can eat
                and you see the fish swimming in the shallow water near the shore of the lagoon
                and you see fruit in the treetops that are out of reach. You think about how to get the food before it can be eaten.
                On the border between the beach and the rainforest, there are <sticks> and <sharps tones> on the ground
                and you figure out that you can build a <spear> out of a <stick> and a <sharp stone>, which you then can use to catch the <fish>. 
                """
            ),
            // Optional Chapters after the main one.
            new Chapter(
                "The RainForest",
                """
                The player has now started their journey towards the manned lighthouse 
                and first needs to pass through the dense rainforest to get there.
                On the way, the player needs to look for fuel such as <firewood> or similar 
                for a bonfire that can heat them during the night,
                so that the player can rest before the they continue 
                their long journey towards the manned lighthouse again.
                The player now needs to travel through the rainforest, 
                which is rich in different species of animals and insects,
                with high humidity and animals lurking where you can't see them, 
                behind fallen trees, branches and hanging vines,
                as well as a lot of details of varying types and impressions. 
                Water flows from cracks in the mountain walls, forming waterfalls in various places, 
                with clean drinking water that, among other things, collects in the leaves of the trees,
                which have formed into bowls that you can drink from. On the paths there is a lot you can trip over, 
                such as crooked roots from the trees, boulders and the like. All around you can see exotic birds 
                and monkeys in the branches of the trees, snakes and colorful frogs in the surroundings.
                At the end of the path the player has followed, the player comes to a mountain wall with a cave in front of it.
                At the opening there are branches, stones, vines and fallen palm tree leaves lying on the ground. 
                The player now needs to make a decision.
                Should the player climb a tree to sleep among the branches, 
                or enter the dark cave, and light a fire at the opening of the cave,
                so that one can sleep in the cave and gain warmth and protection from predators. 
                The player reaches into his pocket and finds a lighter among his things. 
                The player decides to sleep in the <cave> and now needs to collect <firewood> for his bonfire. 
                """,
                new()
                {
                    new Freshwater("freshwater", "A fresh water source, perfect for drinking. "),
                    new Lighter("lighter", "A lighter that you can use to light a fire. ", "firewood"),
                    new Firewood("firewood", "Firewood that you can use to light a fire."),
                    new Bonfire("bonfire", "A <bonfire> that provides warmth and protection from predators. "),
                    new Cave("cave", "A dark cave that you can sleep in and get shelter from storms."),
                }
            ),
            // Optional Chapters after the main one.
            new Chapter(
                "The Mountains",
                """
                The player now continues the journey towards the manned lighthouse, 
                but first needs to cross the river between the mountain walls to get there.
                The mountains are rocky in nature, with ledges to rest on and can be used as roads in mountainous terrain.
                There are many sharp surfaces and boulders to use in creative ways, but also to injure yourself if you fall.
                The mountain walls have many hollows and deep caves to seek shelter in, but also parts that are dangerous
                and can lead to a fall if you are not careful. There are also many trees and vegetation on the mountains.
                The mountain walls are very steep and at the bottom there is a river. But there are also trees growing
                on the mountain walls with roots deeply anchored in the rock crevices. There are logs of fallen trees
                lying and littering a little scattered on different levels of the mountains. The river is of a narrow
                type in width, but with a strong rushing current, which makes it unsuitable for swimming. 
                The player now needs to make a decision.
                Should the player climb to the top of the mountain to use the broken suspension bridge
                between the mountain walls and risk falling from the broken bridge or should the player attempt
                to push a log between two of the rock ledges of the rock walls, allowing the player to balance over to the other side,
                or should the player bring a <vine> that the player ties to something stable on the <mountain wall> such as a tree or part
                of a mountain that you can tie the <vine> to, then try to climb and swing over to the other side of the mountain.
                The player decides to climb with a <vine> and now needs to find a <vine> for the player to pick up before the player can get to the other side. 
                """,
                new()
                {
                    new Vine("vine", "A <vine> to use for climbing with safety.", "mountainwall"),
                    new Mountainwall("mountain wall", "A part of a <mountainwall> that you can tie a vine around, to climb down with safety. "),
                }
            ),
            // Optional Chapters after the main one.
            new Chapter(
                "The Boat",
                """
                On the other side of the river there is a coast with the edge of the sea 
                and an old pier that someone has built before. 
                Next to the pier there is an old broken shed with rubble lying next to it. 
                Next to the shed is an old <boat> with a pair of <oars>, which is worn. 
                The mainland is clearly visible on the horizon at the border between sea and sky. 
                On the coast there is a manned lighthouse that shines, providing hope and guidance to incoming ships and boats. 
                The player now longs to reach the manned lighthouse and therefore begins to look for a way to transport himself 
                so that he can cross the sea to reach the lighthouse. The player decides to take a chance by transporting 
                himself across the sea with the <oars> and the worn <boat>. 
                Therefore, the player now needs to prepare the boat by retrieving the <oars> and placing them in the worn <boat>. 
                """,
                new()
                {
                    new Oars("oars", "Oars used to row the boat. ", "boat"),
                    new Boat("boat", "A worn boat used to cross the sea. "),
                    new Boatnoars("boatnoars", "A worn boat with oars used to row the boat across the sea. ", "sea"),
                }
            ),
            // Optional Chapters after the main one.
            new Chapter(
                "The Mainland",
                """
                After walking up the cliffs to the lighthouse, you are finally in front of it. 
                Now, all you have to do is pull the <doorhandle> and walk inside. 
                """,
                new()
                {
                    new Doorhandle("doorhandle", "The <doorhandle> opens the door to the lighthouse and allows the player to finish the Hologram-room. "),
                }
            ),
        };

    public Room CreateRoom()
    {
        // Story is a class containing all Chapters and keeps track of where in the story you are.
        Story story = new Story(chapters);
        Room room = new(name, description, story, chapterItems, new HologramMenu());
        return room;
    }
}

