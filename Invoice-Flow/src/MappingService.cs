namespace Invoice_Flow.src;

public class MappingService
{
    // FLOWSTEP: Map invoice fields based on source system
    public MappedInvoice Map(Invoice invoice)
    {
        return new MappedInvoice
        {
            Supplier = "ABC"
        };
    }
}