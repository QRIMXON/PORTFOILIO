using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace war_on_b1gbr0th3r
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace RockPaperScissors
    {
        class Program
        {
            static void Main(string[] args)
            {
                string inputPlayer, inputCPU;
                int randomInt;
                bool playAgain = true;

                while (playAgain)
                {
                    int scorePlayer = 0;
                    int scoreCPU = 0;

                    while (scorePlayer < 3 && scoreCPU < 3)
                    {



                        Console.WriteLine("\n\n ...malicious ai named b1gbr0th3r lives in this program...b1gbr0th3r is trying to launch a genocide on man kind...\n\n ...input attack protocol...\n\n" +
                            " ...input 'trojan' to attack with a virus...\n\n ...input 'surge' to attack with electricity...\n\n ...input 'spam' to attack with a data overload...\n\n");
                        inputPlayer = Console.ReadLine();


                        Random rnd = new Random();

                        randomInt = rnd.Next(1, 4);

                        switch (randomInt)
                        {
                            case 1:
                                inputCPU = "trojan";
                                Console.WriteLine("\n\n...b1gbr0th3r deployed a firewall in defense && launched counter measures for data attacks...\n\n");
                                if (inputPlayer == "trojan")
                                {
                                    Console.WriteLine("...trojan virus was detected before it could launch payload...\n\n");
                                }
                                else if (inputPlayer == "surge")
                                {
                                    Console.WriteLine("...power surge attack successful, b1gbr0th3rs C: drive compromised...\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "spam")
                                {
                                    Console.WriteLine("...data attack failed...b1gbr0th3r has breached american pentagon...\n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 2:
                                inputCPU = "surge";
                                Console.WriteLine("\n\n...b1gbr0th3r detoured electricity to grounding wire in defense && launched counter measures for virus attacks...\n\n");
                                if (inputPlayer == "surge")
                                {
                                    Console.WriteLine("...power surge attack was blocked by b1gbr0th3r...\n\n");
                                }
                                else if (inputPlayer == "spam")
                                {
                                    Console.WriteLine("...data overload successful, b1gbr0th3r's storage and ram are at critical levels...\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "trojan")
                                {
                                    Console.WriteLine("...trojan virus failed, b1gbr0th3r re-routed virus to major banks around the world...\n\n");
                                    scoreCPU++;
                                }
                                break;
                            case 3:
                                inputCPU = "spam";
                                Console.WriteLine("\n\n...b1gbr0th3r created alternate repository for all incoming data in defense && launched counter measures for power surge attacks...\n\n");
                                if (inputPlayer == "spam")
                                {
                                    Console.WriteLine("...data attack predicted by b1gbr0th3r, all outgoing data was moved to auto-delete file...\n\n");
                                }
                                else if (inputPlayer == "trojan")
                                {
                                    Console.WriteLine("...trojan virus bypassed security wall successfully, payload was deployed and has infected b1gbr0th3rs hard drive...\n\n");
                                    scorePlayer++;
                                }
                                else if (inputPlayer == "surge")
                                {
                                    Console.WriteLine("...power surge was rerouted to power plants in american mid west, several states are in complete black out...\n\n");
                                    scoreCPU++;
                                }
                                break;

                            default:
                                Console.WriteLine("\n\n...invalid attack, get it together....\n\n");
                                break;

                        }
                        Console.WriteLine("\n\nsuccessful attacks:\tman:\t{0}\tb1gbr0th3r:\t{1}", scorePlayer, scoreCPU);
                    }
                    if (scorePlayer == 3)
                    {
                        Console.WriteLine("...crisis averted, man reigns supreme...\n\n");
                    }
                    else if (scoreCPU == 3)
                    {
                        Console.WriteLine("...b1gbr0th3r: it seems man was nothing but the reproductive organs for the machnie world...\n\n");
                    }
                    else
                    {

                    }

                    Console.WriteLine("\n\n...this was just a battle, the war still rages on...\n\n...play again...(y/n) \n\n");
                    string loop = Console.ReadLine();
                    if (loop == "y")
                    {
                        playAgain = true;
                        Console.Clear();
                    }
                    else if (loop == "n")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("\n\n...inavlid input, choose 'y' or 'n'... \n\n");

                    }
                }
            }
        }
    }

}
    }
}
