using Common;
using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spargo.Maksim.Kulebyakin.Test.Task
{
    public class Display
    {
        private static IQueryHandler _queryHandler;

        public Display()
        {
            var _resolver = DependencyResolver.GetInstance();

            _queryHandler = _resolver.QueryHandler;
        }

        private void AddProduct()
        {
            Console.WriteLine("Введите наименование");
            var productName = Console.ReadLine();
            if (!string.IsNullOrEmpty(productName))
            {
                var product = new Product(productName);
                _queryHandler.Add(product);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        private void AddConsignment()
        {
            var productId = 0;
            var storageId = 0;
            var quantity = 0;

            Console.WriteLine("Введите уникальный номер склада");
            var stocks = _queryHandler.GetStorages();
            foreach (var item in stocks)
            {
                Console.WriteLine("------" + Environment.NewLine + 
                                  "Номер склада: " + item.Id + " | " + "Название: " + item.Name + " | ");
            }
            int.TryParse(Console.ReadLine(), out storageId);

            Console.WriteLine("Введите уникальный номер товара");
            var products = _queryHandler.GetProducts();
            foreach (var item in products)
            {
                Console.WriteLine("------" + Environment.NewLine + 
                                  "Номер товара: " + item.Id + " | " + "Наименование: " + item.Name + " | ");
            }
            Console.WriteLine("------");
            int.TryParse(Console.ReadLine(), out productId);
            Console.WriteLine("Введите количество");
            int.TryParse(Console.ReadLine(), out quantity);
            var consignment = new Consignment(productId, storageId, quantity);

            _queryHandler.Add(consignment);
        }

        private void AddPharmacy()
        {
            Console.WriteLine("Введите наименование");
            var pharmacyName = Console.ReadLine();
            Console.WriteLine("Введите адрес аптеки");
            var pharmacyAdderss = Console.ReadLine();
            Console.WriteLine("Введите телефон аптеки");
            var phone = Console.ReadLine();
            if (!string.IsNullOrEmpty(pharmacyName) && !string.IsNullOrEmpty(phone) && !string.IsNullOrEmpty(pharmacyAdderss))
            {
                var pharmacy = new Pharmacy(pharmacyName, pharmacyAdderss, phone);
                _queryHandler.Add(pharmacy);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        private void AddStorage()
        {
            Console.WriteLine("Введите уникальный номер аптеки");
            var pharmacies = _queryHandler.GetPharmacies();
            foreach (var item in pharmacies)
            {
                Console.WriteLine("------" + Environment.NewLine + "Номер аптеки: " +item.Id + " | " + "Название: " + item.Name + " | " + "Адрес: "+ item.Address + " | " +                      "Телефон: " + item.Phone);
            }
            Console.WriteLine("------");
            int pharmacyId;
            int.TryParse(Console.ReadLine(), out pharmacyId);
            Console.WriteLine("Введите название склада");
            var stockName = Console.ReadLine();
            if (!string.IsNullOrEmpty(stockName))
            {
                var stock = new Storage(pharmacyId, stockName);
                _queryHandler.Add(stock);
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
        }

        private void RemoveConsignment()
        {
            int consignmentId = 0;
            Console.WriteLine("Введите уникальный номер партии товара");
            var consignments = _queryHandler.GetConsignments();
            foreach (var item in consignments)
            {
                Console.WriteLine("------" + Environment.NewLine +
                                  "Номер партии: " + item.Id + " | " + "Продукт: " + item.ProductId + " | " + "Номер склада: " + item.StorageId + " | " + "Кол-во: " + item.Quantity + " | ");
            }
            Console.WriteLine("------");
            int.TryParse(Console.ReadLine(), out consignmentId);
            _queryHandler.Remove(consignmentId, 4);
        }

        private void RemoveProduct()
        {
            var productId = 0;
            Console.WriteLine("Введите уникальный номер продукта");
            var products = _queryHandler.GetProducts();
            foreach (var item in products)
            {
                Console.WriteLine("------" + Environment.NewLine +
                                  "Номер продукта: " + item.Id + " | " + "Продукт: " + item.Name + " | ");
            }
            Console.WriteLine("------");
            int.TryParse(Console.ReadLine(), out productId);
            _queryHandler.Remove(productId, 1);
        }

        private void RemovePharmacy()
        {
            int pharmacyId = 0;
            Console.WriteLine("Введите уникальный номер аптеки");
            var pharmacies = _queryHandler.GetPharmacies();
            foreach (var item in pharmacies)
            {
                Console.WriteLine("------" + Environment.NewLine +
                                  "Номер аптеки: " + item.Id + " | " + "Название: " + item.Name + " | " + "Адрес: " + item.Address + " | " + "Телефон: " + item.Phone + " | ");
            }
            Console.WriteLine("------");
            int.TryParse(Console.ReadLine(), out pharmacyId);
            _queryHandler.Remove(pharmacyId, 2);
        }

        public void Start()
        {
            Console.WriteLine("Добрый день!" + Environment.NewLine + "Выберите действие:" + Environment.NewLine + "------");
            Console.WriteLine("1. Добавить продукт.");
            Console.WriteLine("2. Добавить аптеку.");
            Console.WriteLine("3. Добавить склад для аптеки.");
            Console.WriteLine("4. Добавить партию на склад.");
            Console.WriteLine("5. Удалить продукт вместе с партией.");
            Console.WriteLine("6. Удалить аптеку.");
            Console.WriteLine("7. Удалить склад.");
            Console.WriteLine("8. Удалить партию.");
            Console.WriteLine("9. Проверить наличие товара в аптеке.");
            Console.WriteLine("0. Выход");
            Console.WriteLine("------");
            int choice = 0;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        AddPharmacy();
                        break;
                    case 3:
                        AddStorage();
                        break;
                    case 4:
                        AddConsignment();
                        break;
                    case 5:
                        RemoveProduct();
                        break;
                    case 6:
                        RemovePharmacy();
                        break;
                    case 7:
                        int storageId = 0;
                        Console.WriteLine("Введите уникальный номер склада");
                        var storages = _queryHandler.GetStorages();
                        foreach (var item in storages)
                        {
                            Console.WriteLine("------" + Environment.NewLine +
                                              "Номер склада: " + item.Id + " | " + "Название: " + item.Name + " | ");
                        }
                        int.TryParse(Console.ReadLine(), out storageId);
                        _queryHandler.Remove(storageId, 3);
                        break;
                    case 8:
                        RemoveConsignment();
                        break;
                    case 9:
                        int pharmacyId = 0;
                        Console.WriteLine("Введите уникальный номер аптеки для просмотра товара");
                        var pharmacies = _queryHandler.GetPharmacies();
                        foreach (var item in pharmacies)
                        {
                            Console.WriteLine("------" + Environment.NewLine + "Номер аптеки: " + item.Id + " | " + "Название: " + item.Name + " | " + "Адрес: " + item.Address + " | " + "Телефон: " + item.Phone);
                        }
                        Console.WriteLine("------");
                        int.TryParse(Console.ReadLine(), out pharmacyId);
                        var productsQuantity = _queryHandler.GetProductsFromPharmacy(pharmacyId);
                        foreach (var item in productsQuantity.Keys)
                        {
                            Console.WriteLine("Название: " + item + " | " + "Кол-во: " + productsQuantity[item] + " | ");
                        }
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        break;
                }
            }
        }
    }
}
