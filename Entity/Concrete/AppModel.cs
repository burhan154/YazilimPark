using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AppModel
    {
        [Key]
        public int id { get; set; }
        public string controller  { get; set; }
        public string action { get; set; }
        public string imgUrl { get; set; }
        public string title { get; set; }



        //public AppModel() { }
        //public static bool Add(AppModel item) { return true; }
        //public static IEnumerable<AppModel> ToList() { List<AppModel> item = new List<AppModel>(); return item; }
    }
}
