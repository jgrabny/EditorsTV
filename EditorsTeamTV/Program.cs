using System;

using EditorsTeamTV.Scheduling;

using Helpers;

namespace EditorsTeamTV
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            try
            {
                Utils.WriteConsoleLog("Starting websites");

                new BashQuotesGenerator.Generator().Run();
                var sitesManager = SitesManager.Instance;

                new TimerService().StartTimer();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
