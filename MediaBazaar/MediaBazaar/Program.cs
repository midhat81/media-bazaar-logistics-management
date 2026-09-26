using MediaBazaar.Forms;

namespace MediaBazaar
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
			Authentication authenticationForm = new Authentication();
			Application.Run(authenticationForm);

			// After authentication, check if the user is authenticated
			// and open MainForm if authenticated
			if (authenticationForm.isAuthenticated)
			{
				MainForm mainForm = new MainForm(authenticationForm.employeeManager, authenticationForm.worksheetManager, authenticationForm.productManager, authenticationForm.UserRole);
				Application.Run(mainForm);
			}
		}
    }
}