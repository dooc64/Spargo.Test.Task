using BL;
using Contracts;
using DAO;
using DataContracts;

namespace Common
{
    public sealed class DependencyResolver
    {
        private static DependencyResolver _resolver;

        private string _connectionString = "Data Source=MK;Initial Catalog=Spargo.Maksim.Kulebyakin.Test.Task;Integrated Security=True";

        public IQueryHandler QueryHandler { get;}

        private IDataHandler DataHandler { get;}

        public DependencyResolver()
        {
            DataHandler = new SqlDbHandler(_connectionString);

            QueryHandler = new QueryHandler(DataHandler);
        }

        public static DependencyResolver GetInstance()
        {
            if (_resolver == null)
            {
                _resolver = new DependencyResolver();
            }
            return _resolver;
        }
    }
}