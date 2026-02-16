namespace Invoice_Flow.src;

public class InvoiceService
{
    private readonly ValidationService _validation;
    private readonly MappingService _mapping;

    public InvoiceService()
    {
        _validation = new ValidationService();
        _mapping = new MappingService();
    }

    // FLOWSTEP: Entry point – invoice received from Rillion
    public void Process(Invoice invoice)
    {
        // FLOWSTEP: Determine invoice source (Prime or R1)
        var source = invoice.Source;

        // FLOWSTEP: Apply source-specific mapping
        var mapped = _mapping.Map(invoice);

        // FLOWSTEP: Validate invoice business rules
        var isValid = _validation.Validate(mapped);

        if (!isValid)
        {
            // FLOWSTEP: Reject invoice and log reason
            Console.WriteLine("Invoice rejected");
            return;
        }

        // FLOWSTEP: Send invoice to ERP
        SendToErp(mapped);
    }

    private void SendToErp(MappedInvoice invoice)
    {
        // FLOWSTEP: ERP API call
        Console.WriteLine("Sending invoice to ERP...");
    }
}

public class Invoice
{
    public string Source { get; set; }
}