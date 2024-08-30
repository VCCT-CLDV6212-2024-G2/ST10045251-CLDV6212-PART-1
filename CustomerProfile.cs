using Azure;
using Azure.Data.Tables;

// Define the CustomerProfile class
public class CustomerProfile : ITableEntity
{
    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }

    public CustomerProfile() { }

}

