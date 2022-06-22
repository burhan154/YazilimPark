using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppYP.Models
{
    public class QuoteModel
    {
        public string quote { get; set; }
        public string author { get; set; }
    }
    public class QuotesModel
    {
        public List<QuoteModel> quotes{ get; set; }
    }
}
