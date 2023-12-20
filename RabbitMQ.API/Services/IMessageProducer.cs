namespace RabbitMQ.API.Services;

/// <summary>
/// Information of interface message producer
/// CreatedBy: ThiepTT(20/12/2023)
/// </summary>
public interface IMessageProducer
{
    /// <summary>
    /// Send message async
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="message">Type of message</param>
    /// CreatedBy: ThiepTT(20/12/2023)
    public Task SendMessageAsync<T>(T message);
}