using System;
using Confluent.Kafka;

namespace DotnetKafka
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "107.20.21.85:9093"
            };

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                Console.WriteLine("Enviando mensaje...");
                var result = producer.ProduceAsync("testtopic", new Message<Null, string> { Value = "Hola desde .NET" }).GetAwaiter().GetResult();
                Console.WriteLine($"Mensaje enviado: {result.Value} en partición {result.Partition} con offset {result.Offset}");
            }
        }
    }
}
