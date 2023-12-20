namespace RabbitMQ.API.Entities.Models;

/// <summary>
/// Information of order
/// CreatedBy: ThiepTT(20/12/2023)
/// </summary>
public class Order
{
    /// <summary>
    /// Id of order
    /// </summary>
    public int Id { get; set; }

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