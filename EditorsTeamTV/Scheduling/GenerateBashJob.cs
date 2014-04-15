using Helpers;

using Quartz;

namespace EditorsTeamTV.Scheduling
{
    /// <summary>
    /// Job for generating new bash quote.
    /// </summary>
    public class GenerateBashJob : IJob
    {
        /// <summary>
        /// Executes the Bash generator.
        /// </summary>
        /// <param name="context">Job execution context.</param>
        public void Execute(IJobExecutionContext context)
        {
            Utils.WriteConsoleLog("Generating new bash");

            new BashQuotesGenerator.Generator().Run();
        }
    }
}
