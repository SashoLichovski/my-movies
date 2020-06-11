using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.DTO
{
    public class SidebarModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Views { get; set; }
        public string DateCreated { get; set; }
        public int NoOfComments { get; set; }
    }
}
