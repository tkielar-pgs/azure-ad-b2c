namespace PGS.Azure.ActiveDirectory.B2C.Auth
{
    public class AzureAdOptions
    {
        public string ClientId { get; set; }
        public string Tenant { get; set; }
        public string CallbackPath { get; set; }
        public string DefaultPolicy { get; set; }
    }
}