using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public interface IAppRepository
    {
        void Add(AppModel model);
        void Update(AppModel model);
        void Delete(int id);
        AppModel GetById(int id);
        List<AppModel> GetAll();
    }

    public class AppRepository : IAppRepository
    {
        List<AppModel> appModels = new List<AppModel>();

        public AppRepository()
        {
            if (appModels.Count == 0)
            {
                appModels.Add(new AppModel { imgUrl = "https://media.istockphoto.com/photos/timeline-planning-checklist-or-business-plan-with-calendar-date-on-picture-id1211255735?k=20&m=1211255735&s=612x612&w=0&h=eT_yt1ZzUGw053m8ycranQWs8-kL0VDv67DrqfxNGxw=", title = "Todo App", controller = "Todo", action = "Index" });
                appModels.Add(new AppModel { imgUrl = "https://d26tpo4cm8sb6k.cloudfront.net/img/bmi-chart.gif", title = "BMI Calculator", controller = "BMI", action = "Index" });
                appModels.Add(new AppModel { imgUrl = "https://i.pinimg.com/originals/f6/b4/27/f6b4275cbe6bced3dcf7ea2688902fbf.jpg", title = "Random Quotes", controller = "Quotes", action = "Index" });
                appModels.Add(new AppModel { imgUrl = "https://www.ecmwf.int/sites/default/files/styles/news_item_main_image/public/ThinkstockPhotos-527049904-754px.jpg?itok=IUUoFSK-", title = "Weather App", controller = "Weather", action = "Index" });

            }
        }

        public void Add(AppModel model)
        {
            appModels.Add(model);
        }

        public void Delete(int id)
        {
            AppModel temp =appModels.Find(x=> x.id== id);
            appModels.Remove(temp);
        }

        public List<AppModel> GetAll()
        {
            return appModels;
        }

        public AppModel GetById(int id)
        {
            AppModel temp = appModels.Find(x => x.id == id);
            return temp;
        }

        public void Update(AppModel model)
        {
            throw new NotImplementedException();
        }
    }
}
