using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBook.DTO.Dtos.BlogDtos
{
    public class BlogDetailDTO
    {
    public int blogId { get; set; }
        public string title { get; set; }
        public DateTime createdDate { get; set; }
        public string coverImageUrl { get; set; }
        public int authorId { get; set; }
        public string authorName { get; set; }
  
    }
}