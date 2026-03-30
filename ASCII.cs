using Figgle.Fonts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ST10470533_POE1
{
    internal class ASCII
    {
        // Displays a styled heading in the console using ASCII art
           public void Heading()
        {
            string msg = "Cybersecurity Awareness Bot";
            Console.ForegroundColor= ConsoleColor.Blue;
            string ascii = FiggleFonts.Small.Render(msg);

            Console.WriteLine(ascii);
            Console.ResetColor();
        }
    }
}
