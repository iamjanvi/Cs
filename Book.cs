using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unit3
{
    class Book
    {
        int _book_id;
        String _title;
        Single _price;

        public void getdata(int bookID)
        {
            _book_id = bookID;
        }
        public void getdata(int bookId,String title)
        {
            _book_id = bookId;
            _title = title;

        }

        public void getdata(int bookID,String title,Single price)
        {
            _book_id = bookID;
            _title = title;
            _price = price;
        }

    }
}
