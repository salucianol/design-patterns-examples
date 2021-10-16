using DesignPatterns.Implementations.BehavioralPatterns.Strategy;
using DesignPatterns.Implementations.BehavioralPatterns.Mediator;
using DesignPatterns.Implementations.BehavioralPatterns.Observer;
using DesignPatterns.Implementations.CreationalPatterns.FactoryMethod;
using DesignPatterns.Implementations.StructuralPatterns.Decorator;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Console {
    public class Program {
        public static void Main(string[] args) {
            /*****************************
             * Singleton Pattern Example *
             *****************************/
            //DatabaseConnector databaseConnector = DatabaseConnector.GetDatabaseConnector();
            //System.Console.WriteLine(databaseConnector.Connect());

            /**************************
             * Factory Method Example *
             **************************/
            //LoggingFactory logging = null;
            //string loggingOption = args.Length > 0 ? args[0].Replace("-", "") : "file";
            //switch (loggingOption) {
            //    case "file":
            //        logging = new FileLoggingFactory();
            //        break;
            //    case "database":
            //        logging = new DatabaseLoggingFactory();
            //        break;
            //}
            //logging.LogMessage("4. This is a test...");
            //logging.LogError("4. This is a test error...", new System.Exception("4. This is a test exception..."));

            /****************************
             * Mediator Pattern Example *
             ****************************/
            //IEnrolStudentMediator enrolStudentMediator = new EnrolStudentMediator();

            //Student student = new Student {
            //    Id = Guid.NewGuid().ToString(),
            //    Fullname = "Samuel Alejandro Luciano Lassis",
            //    Email = "samuel.luciano@intec.edu.do"
            //};

            //enrolStudentMediator.Handle(student);

            /*****************************
             * Decorator Pattern Example *
             *****************************/
            ILoggingService loggingService = new LoggingService();
            List<LogError> logErrors = (List<LogError>)loggingService.GetErrors();
            List<LogMessage> logMessages = (List<LogMessage>)loggingService.GetMessages();

            loggingService = new CacheLoggingService(loggingService, new MemoryCache(new MemoryCacheOptions()));
            logErrors = (List<LogError>)loggingService.GetErrors();
            logMessages = (List<LogMessage>)loggingService.GetMessages();

            logErrors = (List<LogError>)loggingService.GetErrors();
            logMessages = (List<LogMessage>)loggingService.GetMessages();

            /****************************
             * Observer Pattern Example *
             ****************************/
            //OrderPublisher orderPublisher = new OrderPublisher();
            //IOrderSubscriber paymentGatewayOrderSubscriber = new PaymentGatewayOrderSubscriber();
            //IOrderSubscriber stockLocationOrderSubscriber = new StockLocationOrderSubscriber();
            //orderPublisher.Subscribe(paymentGatewayOrderSubscriber);
            //orderPublisher.Subscribe(stockLocationOrderSubscriber);

            //orderPublisher.AddOrder(new Order {
            //    Id = Guid.NewGuid().ToString(),
            //    Number = 1024785896,
            //    ReceivedDate = DateTime.Now.AddDays(-10)
            //});
            //orderPublisher.AddOrder(new Order {
            //    Id = Guid.NewGuid().ToString(),
            //    Number = 1024855896,
            //    ReceivedDate = DateTime.Now.AddDays(-5)
            //});
            //orderPublisher.AddOrder(new Order {
            //    Id = Guid.NewGuid().ToString(),
            //    Number = 1124785896,
            //    ReceivedDate = DateTime.Now.AddDays(-1)
            //});

            //orderPublisher.Unsubscribe(stockLocationOrderSubscriber);

            //orderPublisher.AddOrder(new Order {
            //    Id = Guid.NewGuid().ToString(),
            //    Number = 1125785896,
            //    ReceivedDate = DateTime.Now
            //});

            /****************************
             * Strategy Pattern Example *
             ****************************/
            //Bill z50Bill = new Bill {
            //    Rnc = "10145",
            //    Nombre = "KOALA CREATIVE SOFTWARE SRL",
            //    ComprobanteFiscal = "Z500001",
            //    Descuento = 10.52M,
            //    Itbis = 5.36M,
            //    Subtotal = 51.23M,
            //    Total = 46.07M
            //},
            //z51Bill = new Bill {
            //    Rnc = "10145",
            //    Nombre = "KOALA CREATIVE SOFTWARE SRL",
            //    ComprobanteFiscal = "Z510001",
            //    Itbis = 5.36M,
            //    Subtotal = 51.23M,
            //    Total = 56.59M
            //};

            //IBillingValidationStrategy billingValidationStrategy
            //    = new BillingValidationStrategy(
            //            new Z50BillingValidationStrategy()
            //        );
            //System.Console.WriteLine($"{z50Bill.ComprobanteFiscal} is valid? " +
            //                            $"{billingValidationStrategy.Validate(z50Bill)}");

            //billingValidationStrategy
            //    = new BillingValidationStrategy(
            //            new Z51BillingValidationStrategy()
            //        );
            //System.Console.WriteLine($"{z51Bill.ComprobanteFiscal} is valid? " +
            //                            $"{billingValidationStrategy.Validate(z51Bill)}");

            //IMessage message = communicationFactory.CreateMessage();
            //System.Console.WriteLine($"Message length: {message.GetLength()}");
            //IChat chat = communicationFactory.CreateChat();
            //System.Console.WriteLine($"Message added? {chat.AddMessage(message)}");
            //System.Console.WriteLine($"Message added? {chat.AddMessage(message)}");

            //communicationFactory = new VideoFactory(@"c:\prueba\video.mp4", 578472);
            //message = communicationFactory.CreateMessage();
            //System.Console.WriteLine($"Video duration: {message.GetLength()}");
            //chat = communicationFactory.CreateChat();
            //System.Console.WriteLine($"Video message added? {chat.AddMessage(message)}");
            //System.Console.WriteLine($"Video message added? {chat.AddMessage(message)}");
            //System.Console.WriteLine($"Video message added? {chat.AddMessage(message)}");

            // Iterator Pattern
            //ClientCollection clientCollection = new ClientCollection();
            //clientCollection.Add(new Client {
            //    Firstname = "Samuel",
            //    Lastname = "Luciano"
            //});
            //clientCollection.Add(new Client {
            //    Firstname = "Samuel",
            //    Lastname = "Mendoza"
            //});
            //clientCollection.Add(new Client {
            //    Firstname = "Teresa",
            //    Lastname = "Ramirez"
            //});
            //clientCollection.Add(new Client {
            //    Firstname = "Amarilis",
            //    Lastname = "Feliz"
            //});
            //clientCollection.Add(new Client {
            //    Firstname = "Juan",
            //    Lastname = "Perez"
            //}); clientCollection.Add(new Client {
            //    Firstname = "Manuel",
            //    Lastname = "Logroño"
            //});
            //ClientIterator clientIterator = (ClientIterator)clientCollection.CreateIterator();
            //Client temporaryClient = null;
            //if (clientIterator.HasNext()) {
            //    temporaryClient = clientIterator.GetNext();
            //    System.Console.WriteLine($"{temporaryClient.Firstname} {temporaryClient.Lastname}");
            //}
            //System.Console.WriteLine($"{clientIterator.CurrentClient.Firstname} {clientIterator.CurrentClient.Lastname}");
            //while (clientIterator.HasNext()) {
            //    temporaryClient = clientIterator.GetNext();
            //    System.Console.WriteLine($"{temporaryClient.Firstname} {temporaryClient.Lastname}");
            //}
        }
    }
}
