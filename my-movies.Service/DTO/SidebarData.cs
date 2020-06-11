using System;
using System.Collections.Generic;
using System.Text;

namespace my_movies.Service.DTO
{
    public class SidebarData
    {
        public List<SidebarModel> MostViews { get; set; }
        public List<SidebarModel> RecentlyAdded { get; set; }
        public List<SidebarModel> MostCommented { get; set; }
    }
}
