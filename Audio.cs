using System;
using System.Collections.Generic;
using System.Media;
using System.Text;

namespace ST10470533_POE1
{
    internal class Audio
    {
        // This method plays an audio greeting file
        public static void PlayGreet()
        {
            try
            {
                SoundPlayer ply = new SoundPlayer("Hello Welcome to the.wav");
                ply.PlaySync();
            }
            catch (Exception e)
            {
                Console.WriteLine("Yes: {0}", e);
            }
        }
    }
}
