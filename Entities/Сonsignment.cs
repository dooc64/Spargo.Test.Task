using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Consignment : EntityWithId
    {
        public int ProductId { get; set; }

        public int StorageId { get; set; }

        public int Quantity { get; set; }

        public Consignment()
        {

        }

        public Consignment(int productId, int storageId, int quantity)
        {
            ProductId = productId;

            StorageId = storageId;

            Quantity = quantity;
        }
    }
}
