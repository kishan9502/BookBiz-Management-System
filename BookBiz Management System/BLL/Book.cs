using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBiz_Management_System.BLL
{
    public class Book
    {
        public int ISBN { get; set; }
        public string title { get; set; }
        public int AuthorId { get; set; }
        public int YearPublished { get; set; }
        public int QOH { get; set; }
        public int UnitPrice { get; set; }
        public int categoryId { get; set; }
        public int publisherId { get; set; }


    }
}
