using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
    public class QuoteModel
    {
        public string quote { get; set; }
        public string author { get; set; }
    }
    public class QuotesModel
    {
        public List<QuoteModel> quotes { get; set; }
    }
}
