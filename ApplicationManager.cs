using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class ApplicationManager
    {
        //Method Injection
        public void MakeApplication(ICreditManager creditmanager, ILoggerService loggerService)
        {
            creditmanager.Calculate();
            loggerService.Log();
        }
        public void MakeCreditPreliminaryInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
