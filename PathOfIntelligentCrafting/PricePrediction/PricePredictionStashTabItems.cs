using APIHandler;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricePrediction
{
    public class PricePredictionStashTabItems
    {
        public PricePredictionStashTabItems()
        {
            GetNewSetItems();
        }

        private void GetNewSetItems()
        {
            string jsonString = APIStashTab.GetStashTab();
            var welcome = Root.FromJson(jsonString);
        }
    }
}
