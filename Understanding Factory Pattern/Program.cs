using System;

namespace Understanding_Factory_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int invoiceType = 0;
            IInvoice invoice;
            Console.WriteLine("Enter the Invoice type.");

            invoiceType = Convert.ToInt16(Console.ReadLine());
            invoice = InvoiceFactory.GetInvoice(invoiceType);
            invoice.Print();
            Console.ReadLine();
        }
    }
}
