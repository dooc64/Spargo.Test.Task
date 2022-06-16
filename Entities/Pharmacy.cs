namespace Entities
{
    public class Pharmacy : EntityWithId
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public Pharmacy()
        {

        }

        public Pharmacy(string name, string address, string phone)
        {
            Name = name;

            Address = address;

            Phone = phone;
        }
    }
}