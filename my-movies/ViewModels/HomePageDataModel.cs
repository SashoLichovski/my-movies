using my_movies.Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_movies.ViewModels
{
    public class HomePageDataModel
    {
        public List<HomePageModel> Movies { get; set; }
        public SidebarData SidebarData { get; set; }
    }
}
