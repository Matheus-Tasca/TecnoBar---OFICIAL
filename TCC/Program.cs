namespace TCC
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new formLogin());
        }

        public static void DoubleNumber(KeyPressEventArgs e) 
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',' && e.KeyChar != 8)//8 é barra espaco
            {
                e.Handled = true; //ignora o que foi pressionado
            }
        }

        public static void IntNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)//8 é barra espaco
            {
                e.Handled = true; //ignora o que foi pressionado
            }
        }
    }
}