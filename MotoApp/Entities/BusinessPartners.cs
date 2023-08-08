namespace MotoApp.Entities
{
    public class BusinessPartners : EntityBase

    {
        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, First name: {Name}";
    }
}
