namespace RabbitMQ.API.Entities.Dtos;

/// <summary>
/// Information of order dto
/// CreatedBy: ThiepTT(20/12/2023)
/// </summary>
public class OrderDto
{
    /// <summary>
    /// Name of product
    /// </summary>
    public string ProductName { get; set; } = string.Empty;

    /// <summary>
    /// Price
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public int Quantity { get; set; }
}