namespace ModelView
{
    internal static class Program
    {
        /// <summary>
        ///  Основная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
