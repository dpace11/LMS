using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.DataModel
{
    public class Book
    {
        public int BookId { get; set; }
        public string  BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublicationName { get; set; }
        public int Price { get; set; }
        public string PurchaseDate { get; set; }
        public int Quantity { get; set; }
        public string BookLocation { get; set; }
        public int RemainingQuantity { get; set; }
    }
}
