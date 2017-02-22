namespace Understanding_Factory_Pattern
{
   public class InvoiceFactory
    {
       static public IInvoice GetInvoice(int invoiceType)
       {
           IInvoice invoice;
           if (invoiceType == 1)
           {
               return  new InvoiceWithHeader();
           }
           else if (invoiceType == 2)
           {
               return new InvoiceWithoutHeader();
           }
           else
           {
               return null;
           }
           return invoice;
       }
    }
}
