using Microsoft.AspNetCore.Connections;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQ.API.Services;

/// <summary>
/// Information of messsage queue producer
/// CreatedBy: ThiepTT(20/12/2023)
/// </summary>
public class RabbitMQProducer : IMessageProducer
{
    /// <summary>
    /// Send message async
    /// </summary>
    /// <typeparam name="T">Type</typeparam>
    /// <param name="message">Type of message</param>
    /// CreatedBy: ThiepTT(20/12/2023)
    public Task SendMessageAsync<T>(T message)
    {
        var factory = new ConnectionFactory { HostName = "localhost" };
        var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        //channel.QueueDeclare("orders");

        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);

        channel.BasicPublish(exchange: "", routingKey: "orders", body: body);

        return Task.CompletedTask;
    }
}