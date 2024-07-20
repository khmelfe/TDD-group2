using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD
{
    public static class GlobalBookList
    {
        private static Book_list bookList = new Book_list();

        public static Book_list BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }
    }
}
