using System;

namespace Understanding_Factory_Pattern
{
   public class InvoiceWithoutHeader:IInvoice
    {
       public void Print()
       {
           Console.WriteLine("Invoice without Header.");
       }
    }
}
