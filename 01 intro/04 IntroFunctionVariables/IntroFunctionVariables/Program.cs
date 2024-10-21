
namespace IntroChangeVariableValues
{
    internal class Program
    {
        private string myFavoriteCity;
        private int myFavoriteNumber;
        private bool displayNumber;
        private string characterName;
        private DateTime currentTime;


        static void Main(string[] args)
        {
            Program program = new Program();
            program.ShowIntroMessage("Welcome to my program",2);
        }

        private void ShowIntroMessage(
            string introMessage, //1) verzin hier een naam voor deze string variable
            int enterAmountToExit)
        {
            Console.WriteLine(introMessage);//gebruik hier je verzonnen naam van 1) 

            //2) zet hieronder enterAmountToExit op de ???
            Console.WriteLine("druk nu "+ enterAmountToExit + " keer op enter om te stoppen");
       
            for(int i = 0;i < enterAmountToExit; i++)
            {
                Console.ReadLine();
                Console.WriteLine("dat was keer "+ (i+1));
            }
        }

    }
}
