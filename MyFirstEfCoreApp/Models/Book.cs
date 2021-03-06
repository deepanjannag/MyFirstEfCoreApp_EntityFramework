using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstEfCoreApp.Models
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }

        #region Foreign
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        #endregion
    }
}
