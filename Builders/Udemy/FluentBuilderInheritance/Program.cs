var consumerBuilder = new ConsumerInfoBuilder();

consumerBuilder.AddConsumerName("James")
               .AddOccupation("Fireman")
               .AddOccupation("Truck Driver")
               .AddOccupation("Engineer")
               .AddRecreation("KungFu")
               .AddRecreation("Hockey")
               .AddRecreation("Sky Diving");

Console.WriteLine(consumerBuilder._consumer.ConsumerInfo());