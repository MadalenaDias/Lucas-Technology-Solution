namespace LucasTechnologyServices.Module.Core.Models
{
    public class Address : Entity,
    {

        
        public Address(
            string contactname,
            string phone,
            string streetOrAvenue,
            City city,
            string number,
            string complement,
            streing zipCode,
            zipCode zipCXode,
            district District dist,
            stateOrProvinces StateOrProvince
            country Country)
        {
            ContactName = contactname;
            Phone = phone;
            StreetOrAvenue = streetOrAvenue;
            City = city;
            Number = number;
            Complement = complement;
            ZipCode = zipCode;
            District = district;
            Stateorprovince = stateorprovince;
            Country = country;

        }
       
        
        public string ContactName {get; private set; }
        public string Phone { get; private set; }
        public string StreetOrAvenue { get; private set; }
        public City City { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string ZipCode { get; private set; }
        public District District { get; private set; }
        public StateOrProvince StateOrProvince { get; private set; }
        public Country Country { get; private set; }

        public override string ToString()
        {
            return $"{Street}, {Number} - {City}/{StateOrAvenue}";
        }

        
        
        
    }
}