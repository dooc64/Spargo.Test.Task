using Entities;

namespace DataContracts
{
    public interface IDataHandler
    {
        public bool AddProduct(EntityWithId entity);

        public bool AddPharmacy(EntityWithId entity);

        public bool AddStorage(EntityWithId entity);

        public bool AddСonsignment(EntityWithId entity);

        public bool DeleteConsignment(int id);

        public bool DeleteProduct(int id);

        public bool DeletePharmacy(int id);

        public bool DeleteStorage(int id);

        public Dictionary<string, int> GetProductsFromPharmacy(int pharmacyId);

        public List<Pharmacy> GetPharmacies();

        public List<Product> GetProducts();

        public List<Storage> GetStorages();

        public List<Consignment> GetConsignments();
    }
}