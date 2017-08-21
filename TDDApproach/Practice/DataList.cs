using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class DataList
    {

        public List<DataFeed> Data { get ; private set; }

        public DataList()
        {
            Data = new List<DataFeed>();
        }

        public void CreateData(DataFeed datafeed)
        {
            Data.Add(datafeed);
           
        }

        public int  CountUser()
        {
            int count= Data.Count;
            return count;
        }

        
    }
}
