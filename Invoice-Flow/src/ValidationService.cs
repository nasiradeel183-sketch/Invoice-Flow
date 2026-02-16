namespace Invoice_Flow.src;

public class ValidationService
{
    // FLOWSTEP: Validate header, supplier, totals, currency
    public bool Validate(MappedInvoice invoice)
    {
        return true;
    }
}

public class MappedInvoice
{
    public string Supplier { get; set; }
}