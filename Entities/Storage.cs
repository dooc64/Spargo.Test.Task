using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Storage : EntityWithId
    {
        public int PharmacyId { get; set; }

        public string Name { get; set; }

        public Storage()
        {

        }

        public Storage(int pharmacyId, string name)
        {
            PharmacyId = pharmacyId;

            Name = name;
        }
    }
}
