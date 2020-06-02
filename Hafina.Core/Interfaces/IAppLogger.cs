namespace Hafina.Core.Interfaces
{
    /// <summary>
    /// Log levels ordered from lowest to highest severity: 
    /// Trace = 0 => Debug = 1 => Information = 2 => Warning = 3 => Error = 4 => Critical = 5
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IAppLogger<T>
    {
        /// <summary>
        /// For tracking the general flow of the app. These logs typically have some long-term value.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void LogInformation(string message, params object[] args);

        /// <summary>
        /// For abnormal or unexpected events in the app flow. 
        /// These may include errors or other conditions that don't cause the app to stop but might need to be investigated
        /// Example: FileNotFoundException for file quotes.txt.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void LogWarning(string message, params object[] args);

        /// <summary>
        /// For errors and exceptions that cannot be handled. 
        /// These messages indicate a failure in the current activity or operation (such as the current HTTP request), not an app-wide failure.
        /// Example log message: Cannot insert record due to duplicate key violation.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void LogError(string message, params object[] args);

        /// <summary>
        /// For failures that require immediate attention. Examples: data loss scenarios, out of disk space.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        void LogCritical(string message, params object[] args);
    }
}
