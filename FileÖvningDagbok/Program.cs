public class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int userInput = 0;
            int inläggCounter = 1;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("========== DAGBOKEN ==========");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1. Nytt inlägg \n2. Läs inlägg \n3. Radera inlägg \n4. Avsluta dagboken\n");

                userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        string nyttInlägg = Console.ReadLine();

                        if(nyttInlägg != null && nyttInlägg.Trim() != "")
                        {
                            File.AppendAllText("Dagbok.txt", "\n" + inläggCounter + ". " + nyttInlägg);

                            inläggCounter++;

                            Console.WriteLine("\nSparat!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nDu måste skriva något för att kunna lägga in det som ett inlägg!\n");
                        }
                        break;
                    case 2:
                        if (File.Exists("Dagbok.txt") == true)
                        {
                            string fil = File.ReadAllText("Dagbok.txt");
                            Console.WriteLine(fil + "\n");
                        }
                        else
                        {
                            Console.WriteLine("\nDet finns inga inlägg att visa!\n");
                        }
                        break;
                    case 3:
                        if (File.Exists("Dagbok.txt") == true)
                        {
                            File.Delete("Dagbok.txt");
                            Console.WriteLine("\nDagboken blev raderat!\n");
                        }
                        else
                        {
                            Console.WriteLine("\nDet finns inget dagbok att radera.\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\nVälj menuepunkt 1-4\n");
                        break;
                }

            } while (userInput != 4);
        }
        catch (Exception)
        {
            Console.WriteLine("Välj menuepunkt 1-4");
        }


    }

}