using StacjaPaliwLogic.DataAccess;
using StacjaPaliwLogic.Models;

namespace StacjaPaliw
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
            Application.Run(new FormWelcome());

            // TODO: ogarnij se dost�p do danych, p�niej si� martw interfejsem

            //test
            IDataAccess<Offer> offerDataAccess = new OfferDataAccess();
        }
    }
}