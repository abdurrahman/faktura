namespace Faktura.Domain.Models
{
    public struct ErrorObjectModel
    {
        public short Status { get; set; }

        public string Code { get; set; }

        public string Title { get; set; }
    }
}