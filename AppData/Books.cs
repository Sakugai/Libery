using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libery.AppData
{

    class Books
    {
        public Books(string title, DateTime releaseDate, int pageCount)
        {
            Title = title;
            ReleaseDate = releaseDate;
            PageCount = pageCount;
        }

        public string Title { get; set; }//Название
        public DateTime ReleaseDate { get; set; }//Дата выпуска
        public int PageCount { get; set; }//Количество страниц
    }
}
