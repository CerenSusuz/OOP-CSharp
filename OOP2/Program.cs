using System;
using System.Collections.Generic;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager fmanager = new PersonalFinanceCreditManager();
            ICreditManager tmanager = new TransportCreditManager();
            ICreditManager mmanager = new MortgageLoanManager();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager amanager = new ApplicationManager();
            amanager.MakeApplication(tmanager,fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>();

            amanager.MakeCreditPreliminaryInformation(credits);


        }
    }
}
