using Entity.Concrete;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DataAccess.Concrete
{

    public interface IQuotesRepository
    {
        QuoteModel GetRandom();
        List<QuoteModel> GetAll();
    }
    public class QuotesRepository : IQuotesRepository
    {
        private QuotesModel quotes;
        private Random rand = new Random();
        public QuotesRepository()
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string json = (new WebClient()).DownloadString("https://gist.githubusercontent.com/nasrulhazim/54b659e43b1035215cd0ba1d4577ee80/raw/e3c6895ce42069f0ee7e991229064f167fe8ccdc/quotes.json");
            quotes = JsonConvert.DeserializeObject<QuotesModel>(json);
        }

        public List<QuoteModel> GetAll()
        {
            return quotes.quotes;
        }

        public QuoteModel GetRandom()
        {
            int val = rand.Next(quotes.quotes.Count - 1);
            return quotes.quotes[val];
        }
    }
}
