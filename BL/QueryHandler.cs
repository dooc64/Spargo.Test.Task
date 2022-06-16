using Contracts;
using DataContracts;
using Entities;

namespace BL
{
    public class QueryHandler : IQueryHandler
    {
        private IDataHandler _dataHandler;

        public QueryHandler(IDataHandler dataHandler)
        {
            _dataHandler = dataHandler;
        }

        public bool Add(EntityWithId entity)
        {
            if (entity.GetType() == typeof(Product))
            {
                return _dataHandler.AddProduct(entity);
            }
            else if (entity.GetType() == typeof(Pharmacy))
            {
                return _dataHandler.AddPharmacy(entity);
            }
            else if (entity.GetType() == typeof(Storage))
            {
                return _dataHandler.AddStorage(entity);
            }
            else if (entity.GetType() == typeof(Consignment))
            {
                return _dataHandler.AddСonsignment(entity);
            }
            return false;
        }

        public List<Pharmacy> GetPharmacies()
        {
            return _dataHandler.GetPharmacies();
        }

        public List<Product> GetProducts()
        {
            return _dataHandler.GetProducts();
        }

        public List<Storage> GetStorages()
        {
            return _dataHandler.GetStorages();
        }

        public List<Consignment> GetConsignments()
        {
            return _dataHandler.GetConsignments();
        }

        public Dictionary<string, int> GetProductsFromPharmacy(int pharmacyId)
        {
            return _dataHandler.GetProductsFromPharmacy(pharmacyId);

        }

        public bool Remove(int id, int choice)
        {
            switch (choice)
            {
                case 1:
                    return _dataHandler.DeleteProduct(id);
                case 2:
                    return _dataHandler.DeletePharmacy(id);
                case 3:
                    return _dataHandler.DeleteStorage(id);
                    break;
                case 4:
                    return _dataHandler.DeleteConsignment(id);
                default:
                    break;
            }
            return false;
        }
    }
}