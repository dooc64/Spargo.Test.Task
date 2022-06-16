using Entities;

namespace Contracts
{
    public interface IQueryHandler
    {
        public bool Add(EntityWithId entity);

        public List<Pharmacy> GetPharmacies();

        public List<Storage> GetStorages();

        public List<Product> GetProducts();

        public List<Consignment> GetConsignments();

        public Dictionary<string, int> GetProductsFromPharmacy(int pharmacyId);

        public bool Remove(int id, int choice);
    }
}