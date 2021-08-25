namespace Faktura.Domain.Constants
{
    public enum CampaignType
    {
        DebtCollection = 1,
        Reminders = 5,
        Invoice = 6,
        InternationalDebtCollection = 7
    }

    public enum DiscountType
    {
        Percent,
        Cash
    }

    public enum EntityType
    {
        Invoice,
        Objection,
        Enforcement,
        Lawsuit,
        Payout,
        Debtor,
        BankAccountEntry,
        InvoiceStartup,
        Bill
    }

    public enum LegalEntityType
    {
        Private,
        Company
    }

    public enum InvoiceCloseCode
    {
        Paid,
        PulledBack,
        Objection,
        GivenUp,
        Merged,
        ComplianceFail
    }

    public enum InvoiceSearchMode
    {
        Active,
        Inactive,
        Finished
    }

    public enum InvoiceState
    {
        New,
        Dunning,
        DebtCollection = 2, 
        Objection = 4,
        Installment = 6,
        Done = 7, 
        PendingCreation = 9,
        Paused,
        Court, 
        PendingData, 
        PendingCampaign,
        DataInvalid, 
        Invoice, 
        PendingAcceptance, 
        InternationalDebtCollection, 
        PendingDataWaiting, 
        PendingInternalCreation = 22
    }
}