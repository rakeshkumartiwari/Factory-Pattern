using System;

namespace Understanding_Factory_Pattern
{
  public  class InvoiceWithHeader:IInvoice
  {
      public void Print()
      {
          Console.WriteLine("Invoice with Header.");
      }
  }
}
