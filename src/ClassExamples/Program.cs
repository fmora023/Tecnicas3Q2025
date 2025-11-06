using ClassExampleController;
using ClassExampleController.Abstractions;
using ClassExampleModels;

namespace ClassExamples
{
    internal static class Program
    {
        // Recuerden actualizar esta ruta al clonar el repositorio
        private const string CostumersFilePath = @"S:\Personal\UPI\Tecnicas de Programacion\Code\Repo3Q2025\users.csv";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var userController = LoadControllerService();
            Application.Run(new LoginView(userController));
        }

        private static LoginController LoadControllerService()
        {
            var userHandler = new UserHandler(new FileHandler<Customer>());
            var couldLoadUsers = userHandler.LoadUsers(CostumersFilePath);
            if (!couldLoadUsers)
            {
                MessageBox.Show("Could not load users from data source. The application will close.");
                Environment.Exit(1);
            }
            var userController = new LoginController(userHandler);
            return userController;
        }
    }
}