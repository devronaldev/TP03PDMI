using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP03PDMI.Models;

namespace TP03PDMI.Services
{
    public class AppDbRepository
    {
        public AppDbRepository() 
        {
            Packages = LoadPackages();
        }

        private static List<Package> LoadPackages()
        {
            List<Event> events1 =
            [
                new Event
                {
                    Id = 1,
                    Date = new DateTime(2024, 11, 10, 10, 30, 00),
                    Description = "Pedido criado",
                    EventStatus = DeliveryStatus.Criado,
                    Locate = "São Paulo",
                },
                new Event
                {
                    Id = 2,
                    Date = new DateTime(2024, 11, 10, 12, 30, 00),
                    Description = "Pedido coletado",
                    EventStatus = DeliveryStatus.Coletado,
                    Locate = "São Paulo"
                },
                new Event
                {
                    Id = 3,
                    Date = new DateTime(2024, 11, 10, 20, 30, 00),
                    Description = "Pedido em Transferência para a unidade de Santos",
                    EventStatus = DeliveryStatus.EmTransito,
                    Locate = "Santos"
                }
            ];

            List<Event> events2 =
            [
                new Event
                {
                    Id = 1,
                    Date = new DateTime(2024, 11, 13, 05, 00, 00),
                    Description = "Pedido criado",
                    EventStatus = DeliveryStatus.Criado,
                    Locate = "Santos",
                },
                new Event
                {
                    Id = 2,
                    Date = new DateTime(2024, 11, 13, 08, 22, 00),
                    Description = "Pedido coletado",
                    EventStatus = DeliveryStatus.Coletado,
                    Locate = "Santos"
                }
            ];

            List<Event> events3 =
            [
                new Event
                {
                    Id = 1,
                    Date = new DateTime(2024, 11, 07, 12, 26, 00),
                    Description = "Pedido criado",
                    EventStatus = DeliveryStatus.Criado,
                    Locate = "Rio de Janeiro",
                },
                new Event
                {
                    Id = 2,
                    Date = new DateTime(2024, 11, 08, 08, 58, 00),
                    Description = "Pedido coletado",
                    EventStatus = DeliveryStatus.SaiuParaEntrega,
                    Locate = "Rio de Janeiro"
                }
            ];
            List<Package> packages =
            [
                new Package
                {
                    PackageId = "SPS1234567890SPS",
                    Status = DeliveryStatus.EmTransito,
                    SentAt = events1.First().Date,
                    EstimatedDeliveryDate = events1.Last().Date.AddDays(20),
                    Locate = "Santos",
                    Events = events1
                },
                new Package
                {
                    PackageId = "SSP1234567890SSP",
                    Status = DeliveryStatus.Coletado,
                    SentAt = events2.First().Date,
                    EstimatedDeliveryDate = events1.Last().Date.AddDays(4),
                    Locate = "Santos",
                    Events = events2
                },
                new Package
                {
                    PackageId = "RJC1234567890RJC",
                    Status = DeliveryStatus.Entregue,
                    SentAt = events3.First().Date,
                    EstimatedDeliveryDate = events1.Last().Date.AddDays(3),
                    Locate = "Santos",
                    Events = events3
                }
            ];

            return packages;
        }

        public List<Package> Packages { get; set; }
    }
}
