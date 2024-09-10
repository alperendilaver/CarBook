using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.DTO.Dtos.ServiceDtos
{
    public class ResultServiceDTO
    {
        public int serviceId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string iconUrl { get; set; }

    }
}
