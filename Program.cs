namespace ST10470533_POE1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create an object of the ASCII class
            ASCII prt = new ASCII();

            // Call the Heading() method to print the chatbot title/design
            prt.Heading();

            // Create an object of the Sound class (optional here since method is static)
            Audio snd = new Audio();

            // Call the PlayGreet() method to play a welcome audio sound
            Audio.PlayGreet();


            // Create an object of the BasicResponses class
            Response br = new Response();

            // Call the Response() method to start the chatbot conversation loop
            br.BasicResponse();
        }
    }
}
