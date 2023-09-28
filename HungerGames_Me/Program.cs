using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace HungerGames_Me;

class Program
{
    static void Main(string[] args)
    {


        //Titelbild


        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("***********************************************************");
        Console.WriteLine("***********************************************************");
        Console.WriteLine("***********************************************************");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("╔╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╗\n╠╬╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╬╣\n╠╣ _____ _            _   _                             ╠╣\n╠╣|_   _| |__   ___  | | | |_   _ _ __   __ _  ___ _ __ ╠╣\n╠╣  | | | '_ \\ / _ \\ | |_| | | | | '_ \\ / _` |/ _ \\ '__|╠╣\n╠╣  | | | | | |  __/ |  _  | |_| | | | | (_| |  __/ |   ╠╣\n╠╣  |_| |_| |_|\\___| |_| |_|\\__,_|_| |_|\\__, |\\___|_|   ╠╣\n╠╣  ____                             ___|___/___        ╠╣\n╠╣ / ___| __ _ _ __ ___   ___  ___  |___ \\  / _ \\       ╠╣\n╠╣| |  _ / _` | '_ ` _ \\ / _ \\/ __|   __) || | | |      ╠╣\n╠╣| |_| | (_| | | | | | |  __/\\__ \\  / __/ | |_| |      ╠╣\n╠╣ \\____|\\__,_|_| |_| |_|\\___||___/ |_____(_)___/       ╠╣\n╠╬╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╦╬╣\n╚╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╩╝");
        Console.WriteLine();
        Console.WriteLine("Und die Tribute für Distrikt 7 bist DU! Gegen deine Mit- \nTributen kämpfst du in einer Arena um das pure Überleben.\nEntscheide clever, finde Verbündete und überlebe.");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("*************************************************************");
        Console.WriteLine("*************************************************************");
        Console.WriteLine("*************************************************************");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        Console.WriteLine("Drücke a um zu beginnen!");

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();


        string start = Reader.ReadLine(20 * 1000);
        if (start == "a")
        {
            System.Console.Clear();

            //Szene 1

            Console.WriteLine("Du beginnst, mit allen Zusammen mitten in einem Feld. In der Mitte zwischen euch liegen Rucksäcke mit Vorräten. Was tust du?");
            Console.WriteLine("a. Wegrennen oder b. Rucksack holen - Schreibe a oder b in die Konsole um auszuwählen. \nWähle schnell, du hast nur 20 Sekunden Zeit.");
            string eingabe = Reader.ReadLine(20*1000);

            if (eingabe == "a")
            {
                Console.WriteLine("Du rennst ohne Vorräte in den Wald. Hier verhungerst du erbärmlich, da du keine Überlebensskills hast.");

            }
            else
            {
                Console.WriteLine("Du rennst in die Mitte und ergatterst einen Rucksack. Mit deinem Schatz flüchtest du schnell in den Wald, während du von hinten mit Pfeilen beschossen wirst");

                Console.WriteLine("Im Wald angekommen musst du dich entscheiden.Suchst du a. eine Frischwasserquelle oder b. einen Unterschlupf? \nWähle schnell, du hast nur 20 Sekunden Zeit.");
                string eingabe2 = Reader.ReadLine(20 * 1000);

                if (eingabe2 == "a")
                {
                    Console.WriteLine("Du suchst den Fluss, der euch versprochen wurde.Nach kurzer Suche findest du diesen auch und nimmst die Flasche, die du in deinem Rucksack hast hervor und füllst sie auf.");
                    Console.WriteLine("Nachdem du am Fluss deine Flaschen gefüllt hast, brauchst du ein Camp. Wo schlägst du auf? a. Höhle b. Baum. \nWähle schnell, du hast nur 20 Sekunden Zeit.");
                    string eingabe3 = Reader.ReadLine(20 * 1000);

                    if (eingabe3 == "a")

                    {
                        Console.WriteLine("Du suchst eine Höhle, doch da wohnt bereits ein Bär drin. Das aggressive Ding frisst dich auf, du hattest nie eine Chance.");


                    }
                    else
                    {
                        Console.WriteLine("Du kletterst auf einen Baum und bindest dich dort fest. Hier bist du vorerst sicher.");
                        Console.WriteLine("Doch ein Bündnis deiner Gegner campiert direkt unter dir. Was tust du? a. Abwarten und Hoffen oder b. Angreifen. \nWähle schnell, du hast nur 20 Sekunden Zeit.");
                    }

                }

                else
                {
                    Console.WriteLine("Du suchst Unterschlupf, den du auch findest. Doch leider bist du nicht allein. Distrikt 1 ist bereits da und greifen dich brutal an. Leider überlebst du deine Wunden nicht. Du hast 1 Runde überlebt");
                }

                string eingabe4 = Reader.ReadLine(20 * 1000);


                if (eingabe4 == "b")
                {
                    Console.WriteLine("Du schmiedest einen Plan und greifst sie an, während sie schlafen. Du hast glück und besiegst sie.");
                    Console.WriteLine("Du hast nun genug Waffen und Vorräte. Welche Waffe benutzt du per sofort? 1 Pfeil und Bogen, 2 Kurzschwert, 3 Dolch, 4 zweihändiges Langschwert, 5 Speer. \nWähle schnell, du hast nur 20 Sekunden Zeit.");

                    int waffen = Convert.ToInt32(Console.ReadLine());
                    switch (waffen)
                    {
                        case 1:
                            Console.WriteLine("Du wählst Pfeil und Bogen. Eine super Waffe für Distanz.");
                            break;

                        case 2:
                            Console.WriteLine("Du wählst ein Kurzschwert. Diese leichte Waffe wird dir sicher nützlich sein.");
                            break;

                        case 3:
                            Console.WriteLine("Du wählst einen Dolch. Eine super Waffe um sich anzuschleichen und für Nahkampf.");
                            break;

                        case 4:
                            Console.WriteLine("Du wählst ein zweihändiges Langschwert. Diese heftige Waffe ist äusserst schwer und bracuht viel Muskeln um sie zu schwingen. Doch dir ist es ein leichtes.");
                            break;

                        case 5:
                            Console.WriteLine("Du wählst einen Speer. Diese Waffe wird deine Feinde sicherlich auf Distanz halten.");
                            break;

                        default:
                            Console.WriteLine("Error 5018! Du musst einen Wert zwischen 1 und 5 wählen... Stupido.");
                            break;

                    }
                    Console.WriteLine("Du hast nun eine Waffe. Greifst du a die verbliebenen Gegner an oder b baust du dir ein Camp auf? Wähle schnell, du hast nnur 20 Sekunden Zeit.");

                }

                else
                {
                    Console.WriteLine("Du wartest. Doch es bleibt immer jemand bei ihrem Camp. Du verhugerst auf dem Baum.");
                }


                string eingabe5 = Reader.ReadLine(20 * 1000);
                ;
                if (eingabe5 == "b")
                {
                    Console.WriteLine("Du baust ein Camp. Die Spielemacher finden dich zu langweilig und schicken eine Horde fleischfressender Affen in dein Camp. Die Horde zerfleischt dich.");
                }

                else
                {
                    Console.WriteLine("Du gehst in die Offensive und nimmst nur das nötigste mit. Das ist Clever, denn die Spielemacher schicken eine Horde fleischfressender Affen in deine Richtung, denen du so ausweichst.");
                    Console.WriteLine("Während du vor der Affenhorde flüchtest triffst du verschiedene Gegner. Du hast die Option dich zu verbünden. Wen suchst du aus? Wähle schell, du hast nur 20 Sekunden Zeit.");
                    Console.WriteLine("1 Das junge Mädchen, das offensichtliche Überlebensskills hat");
                    Console.WriteLine("2 Die brutalaussehende Frau, die sicherlich im Kampf nützlich wäre");
                    Console.WriteLine("3 Den Jungen, der allen immer erzählt hat vor den Spielen wie gut er kochen kann");

                    int verbuendete = Convert.ToInt32(Console.ReadLine());
                    string verbuendeteGut = "falsch";
                    string kind = "falsch";
                    switch (verbuendete)
                    {
                        case 1:
                            Console.WriteLine("Du wählst das Kind mit den Überlebensskills");
                            verbuendeteGut = "richtig";
                            kind = "richtig";
                            break;

                        case 2:
                            Console.WriteLine("Du wählst die brutale Frau");
                            break;

                        case 3:
                            Console.WriteLine("Du wählst den Koch");
                            verbuendeteGut = "richtig";
                            break;

                        default:
                            Console.WriteLine("Error 5018! Du musst einen Wert zwischen 1 und 3wählen... Stupido.");
                            break;
                    }

                    if (verbuendeteGut == "richtig")
                    {
                        Console.WriteLine("Du hast die sichere Wahl getroffen. Dein(e) Verbündete(r) wird dir sicher helfen können");
                    }

                    else

                    {
                        Console.WriteLine("Die brutale Frau ist hinterhältig. Sie ermordet dich während du schläfst.");

                    }

                    if (kind == "richtig")
                    {
                        Console.WriteLine("Du und das Kind bestreiten jetzt die Spiele gemeinsam. Leider trefft ihr auf eine feindliche Gruppe und sie stirbt. Du bist sehr traurig.");
                    }

                    else

                    {
                        Console.WriteLine("Du und der Koch bestreiten die Spiele nun gemeinsam. Ihr kämpft und esst Seite an Seite. Doch langsam gehen die Spiele zu Ende. a Ihr bleibt zusammen und riskiert \ngegeneinander zu kämpfen oder b ihr geht getrennte Wege. Wähle schnell, du hast nur 20 Sekunden Zeit.");
                    }
                    string eingabe6 = Reader.ReadLine(20 * 1000);

                    if (eingabe6 == "a")
                    {
                        Console.WriteLine("Ihr bleibt zusammen. Bis zum Schluss. Und leider wird das eurer bitteres Ende. Der Koch und Du ihr seid die letzen die Überlebt haben und müsst nun in einem 1 gegen 1 antreten. Es ist ein erbitterter Kampf zwischen Freunden, den du leider verlierst.");
                    }
                    else
                    {
                        Console.WriteLine("Ihr entscheidet euch getrennte Wege zu gehen. Am Abend hörst du einen Kanonenschuss und hast ein übles Gefühl im Bauch. Du bist dir sicher, dieser Schuss galt ihm.");
                        Console.WriteLine("Am nächsten Morgen kommt eine Durchsage der Spielemacher: 'Es sind nur noch zwei Tribute übrig. Kommt in die Mitte des Feldes und bringt es zu Ende. Kommst du a dem Befehl nach oder b versteckst du dich? Wähle schnell, du hast nur 20 Sekunden Zeit.");
                    }


                    string eingabe10 = Reader.ReadLine(20 * 1000);

                    if (eingabe10 == "a")
                    {
                        Console.WriteLine("Du gehst tapfer zurück zum Feld wo alles begann. Hier wird auch alles Enden. Tapfer kämpfst du und… Du siegst!!");
                    }

                    else if (eingabe10 == "b")
                    {
                        Console.WriteLine("Du versteckst dich! Die Spielemacher sind wütendend und geben deinem letzen Gegner Waffen und Mittel dich zu besiegen. Er überrumpelt dich im Schlaf. Du verlierst.");
                    }
                    else
                    {
                        Console.WriteLine("Du hast keine der beiden Optionen gewählt. Rebellion gegen das System erkannt. Prepare to be eliminated.");
                    }

                }

            }

        }
        else
        {
            Console.WriteLine("Du hast die falsche Taste gedrückt, nämlich " + start + "! Bitte starte das Spiel erneut!");
        }

        Console.ReadLine();

        // 911 help me

    }

    class Reader
    {
        private static Thread inputThread;
        private static AutoResetEvent getInput, gotInput;
        private static string input;



        static Reader()
        {
            getInput = new AutoResetEvent(false);
            gotInput = new AutoResetEvent(false);
            inputThread = new Thread(reader);
            inputThread.IsBackground = true;
            inputThread.Start();
        }

        private static void reader()
        {
            while (true)
            {
                getInput.WaitOne();
                input = Console.ReadLine();
                gotInput.Set();
            }
        }


        public static string ReadLine(int timeOutMillisecs = Timeout.Infinite)
        {
            getInput.Set();
            bool success = gotInput.WaitOne(timeOutMillisecs);

            if (success)
            { 

                return input;
            }
            else
            {
                throw new TimeoutException("User did not provide input within the timelimit.");
            }
        }
    }
}

    


