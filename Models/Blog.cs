using System;
namespace MigrationToDataBase.Models
{
    public class Blog
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Comment { get; set; }

        public DateTime DateTime { get; set; }

        public string Title { get; set; }

        public string Desc { get; set; }

        public string Url { get; set; }

    }
}


