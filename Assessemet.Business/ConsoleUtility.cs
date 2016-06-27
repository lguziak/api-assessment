using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assessemet.Business.Abstractions;

namespace Assessemet.Business
{
    public class ConsoleUtility : ConsoleRequirement
    {
        public ConsoleUtility(MediaType type)
        {
            
        }   

         public override bool WriteToConsole(string message)
         {
             bool operationstatus = false;
             try
             {
                 Console.Write(message);
                 operationstatus = true;
                 return operationstatus;
             }
             catch (Exception ex)
             {
                 operationstatus = false;
                 return operationstatus;
             }
           
         }
    }
}
