using System;

using Helpers;

using Quartz;

namespace EditorsTeamTV.Scheduling
{
    /// <summary>
    /// Job for switching the windows.
    /// </summary>
    public class WindowSwitcherJob : IJob
    {
        /// <summary>
        /// The sites manager instance
        /// </summary>
        private readonly SitesManager sitesManager;

        /// <summary>
        /// Initializes a new instance of the <see cref="WindowSwitcherJob"/> class.
        /// </summary>
        public WindowSwitcherJob()
        {
            sitesManager = SitesManager.Instance;
        }

        /// <summary>
        /// Sets the next window to the foreground and refreshes the previous one.
        /// </summary>
        /// <param name="context">Job execution context.</param>
        public void Execute(IJobExecutionContext context)
        {
                var index = this.GetNextHandleIndex();
                Utils.WriteConsoleLog(string.Format("Current window handle index: {0}", index));

                if (index >= 0)
                {
                    var handle = sitesManager.Handles[index];

                    Utils.ForceForegroundWindow(new IntPtr(handle));

                    Utils.WriteConsoleLog("Refreshing the previous window");
                    sitesManager.Sites[this.GetPreviousIndex()].Browser.Refresh();
                }
        }

        /// <summary>
        /// Gets the next window handle index.
        /// </summary>
        /// <returns>Index of the next window handle.</returns>
        public int GetNextHandleIndex()
        {
            var current = sitesManager.CurrentHandleIndex;
            var max = sitesManager.Handles.Count - 1;

            if (max < 0)
            {
                return max;
            }

            if (current == max)
            {
                sitesManager.CurrentHandleIndex = 0;
                return sitesManager.CurrentHandleIndex;
            }

            sitesManager.CurrentHandleIndex++;

            return sitesManager.CurrentHandleIndex;
        }

        /// <summary>
        /// Gets previous window handle index.
        /// </summary>
        /// <returns>Index of the previous window handle.</returns>
        public int GetPreviousIndex()
        {
            var current = sitesManager.CurrentHandleIndex;
            var max = sitesManager.Handles.Count - 1;

            if (current != 0)
            {
                return current - 1;
            }

            return max;
        }
    }
}
