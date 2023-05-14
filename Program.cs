class Homework2
{
    static void Main(string[] args)
    {
        bool loop = true;
        while (loop)
        {
            Console.WriteLine("input dna");
            string halfDNASequence = Console.ReadLine();
            if (IsValidSequence(halfDNASequence) == true)
            {
                Console.WriteLine("Current half DNA sequence :{0} ", halfDNASequence);
                bool loopyesno = true;
                while (loopyesno)
                {
                    Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                    string yesorno = Console.ReadLine();
                    switch (yesorno)
                    {
                        case "Y":
                            Console.WriteLine("Replicated half DNA sequence :{0}", ReplicateSeqeunce(halfDNASequence));
                            loopyesno = false;
                            break;
                        case "N":
                            loopyesno = false;
                            break;
                        default:
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }
                bool checklastbool = true;
                while (checklastbool)
                {
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    string checklast = Console.ReadLine();
                    switch (checklast)
                    {
                        case "Y":
                            checklastbool = false;
                            break;
                        case "N":
                            checklastbool = false;
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
                Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                string checklast = Console.ReadLine();
                bool checklastbool = true;
                while (checklastbool)
                {
                    switch (checklast)
                    {
                        case "Y":
                            checklastbool = false;
                            break;
                        case "N":
                            checklastbool = false;
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Please input Y or N.");
                            break;
                    }
                }
            }


        }
    }
    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }
    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }



}