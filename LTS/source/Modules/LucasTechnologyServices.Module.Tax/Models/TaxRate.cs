

namespace LucasTechnologyServices.Module.Tax.Models
{
    public class TaxRate : EntityBase
    {
        public long TaxClassId { get; set; }
        public taxClass TaxClass { get; set; }
        [StringLength(450)]
        public string CountrId { get; set; }
        public Country Country { get; set; }
        public long? StateOrProvinceId { get; set; }
        public StateOrProvince StateOrProvince { get; set; }
        public decimal Rate { get; set; }
        
        [StringLength(450)]
        public string ZipCode { get; set; }



    }
}