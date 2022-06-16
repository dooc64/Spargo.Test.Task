using DataContracts;
using Entities;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SqlDbHandler : IDataHandler
    {
        private string _connectionString;

        public SqlDbHandler(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool AddProduct(EntityWithId entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var product = (Product)entity;

                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddProduct";

                command.Parameters.AddWithValue("@Name", product.Name);
                
                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool AddPharmacy(EntityWithId entity)
        {
            var pharmacy = (Pharmacy)entity;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddPharmacy";

                command.Parameters.AddWithValue("@Name", pharmacy.Name);
                command.Parameters.AddWithValue("@Address", pharmacy.Address);
                command.Parameters.AddWithValue("@Phone", pharmacy.Phone);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool AddStorage(EntityWithId entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var storage = (Storage)entity;

                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddStorage";

                command.Parameters.AddWithValue("@PharmacyId", storage.PharmacyId);
                command.Parameters.AddWithValue("@Name", storage.Name);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool AddСonsignment(EntityWithId entity)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var consignment = (Consignment)entity;

                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.AddConsignment";

                command.Parameters.AddWithValue("@ProductId", consignment.ProductId);
                command.Parameters.AddWithValue("@StorageId", consignment.StorageId);
                command.Parameters.AddWithValue("@Quantity", consignment.Quantity);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool DeleteConsignment(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.DeleteConsignment";

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool DeleteProduct(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.DeleteProduct";

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool DeletePharmacy(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.DeletePharmacy";

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public bool DeleteStorage(int id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "dbo.DeleteStorage";

                command.Parameters.AddWithValue("@Id", id);

                connection.Open();

                command.ExecuteNonQuery();

                return true;
            }
        }

        public List<Product> GetProducts()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [Id], [Name] " +
                                      "FROM[Spargo.Maksim.Kulebyakin.Test.Task].dbo.Products";

                connection.Open();
                var products = new List<Product>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    products.Add(new Product()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                    });
                }

                return products;
            }
        }

        public List<Consignment> GetConsignments()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [Id], [ProductId], [StorageId], [Quantity] " +
                                      "FROM[Spargo.Maksim.Kulebyakin.Test.Task].dbo.Consignments";

                connection.Open();
                var consignments = new List<Consignment>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    consignments.Add(new Consignment()
                    {
                        Id = (int)reader["Id"],
                        ProductId = (int)reader["ProductId"],
                        StorageId = (int)reader["StorageId"],
                        Quantity = (int)reader["Quantity"]
                    });
                }

                return consignments;
            }
        }

        public List<Pharmacy> GetPharmacies()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [Id], [Name], [Address], [Phone] " +
                                      "FROM[Spargo.Maksim.Kulebyakin.Test.Task].dbo.Pharmacys";

                connection.Open();
                var pharmacies = new List<Pharmacy>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    pharmacies.Add(new Pharmacy()
                    {
                        Id = (int)reader["Id"],
                        Name = reader["Name"] as string,
                        Address = reader["Address"] as string,
                        Phone = reader["Phone"] as string
                    });
                }

                return pharmacies;
            }
        }

        public List<Storage> GetStorages()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT [Id],[PharmacyId],[Name] " +
                                      "FROM[Spargo.Maksim.Kulebyakin.Test.Task].dbo.Storages";

                connection.Open();
                var storages = new List<Storage>();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    storages.Add(new Storage()
                    {
                        Id = (int)reader["Id"],
                        PharmacyId = (int)reader["PharmacyId"],
                        Name = reader["Name"] as string,
                    });
                }

                return storages;
            }
        }

        public Dictionary<string, int> GetProductsFromPharmacy(int pharmacyId)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetProductQuantityFromPharmacyByPharmacyId";

                command.Parameters.AddWithValue("@PharmacyId", pharmacyId);

                connection.Open();

                var reader = command.ExecuteReader();

                var productsQuantity = new Dictionary<string, int>();

                while (reader.Read())
                {
                    productsQuantity.Add(
                        reader["Name"] as string,
                        (int)reader["Quantity"]);
                }

                return productsQuantity;
            }
        }
    }
}