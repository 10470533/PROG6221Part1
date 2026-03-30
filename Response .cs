using System;
using System.Collections.Generic;
using System.Text;

namespace ST10470533_POE1
{
    internal class Response
    {
        // This method collects user details (name) and returns it
        public string Details()
        {
            string name;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************************");
            Console.WriteLine("*      USER DETAILS                    *");
            Console.WriteLine("****************************************");
            Console.ResetColor();

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");

            return name;

        }
        //This method handles user questions and prepares answers.
        public void BasicResponse()
        {
            string user;

            //  Keyword groups
            string[][] keywords =
            {
                new string[] { "how are you", "how are you doing" },
                new string[] { "purpose", "what do you do", "what is your purpose" },
                new string[] { "phishing", "scam", "fake email" },
                new string[] { "strong password", "create password", "password strength" },
                new string[] { "public wifi", "wifi safe", "public network" },
                new string[] { "two factor", "2fa", "authentication" },
                new string[] { "https" },
                new string[] { "password stolen", "hacked" }
            };

            // Corresponding answers (same order)
            string[] answers =
            {
                "I'm a cybersecurity bot, always ready to help!",
                "My purpose is to educate users about cybersecurity.",
                "Phishing is a scam where attackers trick you into giving personal info.",
                "Use uppercase, lowercase, numbers, and symbols to create a strong password.",
                "Public WiFi is risky because hackers can intercept your data.",
                "Two-factor authentication adds an extra layer of security.",
                "HTTPS encrypts your data and makes websites more secure.",
                "If your password is stolen, change it immediately and enable 2FA."
            };

            Console.ForegroundColor = ConsoleColor.Blue;

            // Display a formatted title banner for the chatbot
            Console.WriteLine("****************************************");
            Console.WriteLine("*      CYBERSECURITY CHATBOT           *");
            Console.WriteLine("****************************************");

            Console.WriteLine("");

            Console.ResetColor();

            // Display a loading message to simulate initialization
            Console.Write("Loading");

            Thread.Sleep(300);

            Console.Write(".");

            Thread.Sleep(300);

            Console.Write(".");

            Thread.Sleep(300);

            Console.WriteLine(".");

            Thread.Sleep(500);

            // Call the Details() method to get and store the user's name
            string names = Details();

            // while loop to keep the chatbot running until the user exits
            while (true)
            {
               
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Display chatbot header
                Console.WriteLine("\n--------------------------------------------\n");
                Console.WriteLine("****************************************");
                Console.WriteLine("*     ASK A CYBERSECURITY QUESTION     *");
                Console.WriteLine("****************************************");
                Console.WriteLine("");

                // Instruction for the user on how to exit the chatbot
                Console.WriteLine("Type 'exit' to quit.");

              
                Console.Write("\nYou: ");

                
                user = Console.ReadLine().ToLower();

                // Check if the user wants to exit the chatbot
                if (user.Contains("exit"))
                {
                    Console.WriteLine("\nBot: Goodbye!");

                  
                    break;
                }

                // Get the chatbot response based on user input, keywords, and stored name
              //  string response = GetResponse(user, keywords, answers, names);

                // Display a typing/loading animation before showing the bot response
              
                Console.Write("Bot is responding");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.Write(".");
                Thread.Sleep(300);
                Console.WriteLine(".");

                
                Thread.Sleep(400);

                // Display the chatbot's response
                Console.WriteLine("Bot: " + response);

             
                Console.ResetColor();
            }
        }

        // Method that finds the correct response based on user input
        static string GetResponse(string input, string[][] keywords, string[] answers, string name)
        {
            // Loop through each group of keywords
            for (int i = 0; i < keywords.Length; i++)
            {
                // Check if any keyword in the current group exists in the user's input
                if (Array.Exists(keywords[i], word => input.Contains(word)))
                {
                    // If a match is found, return the corresponding answer
                    return name + ", " + answers[i];
                }
            }

            string rsp = name + ", I didn't quite understand that. Could you rephrase?";

            // Return the rsp response
            return rsp;
        }

    }

}
