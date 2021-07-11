using LucasTecnologiaServices.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LucasTecnologiaServices.Modules.Core.Models
{
    public class City : EntityBase
    {

        public City() { } 
        
        public City(long id)
        {
            Id = id;
        }
        
        [StringLength(20)]
        public string Name { get; set; }

        public StateOrProvince StateOrProvince { get; set; }
        public string StateOrProvinceId { get; set; }

    }
}