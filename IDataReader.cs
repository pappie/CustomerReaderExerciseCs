using System;
using System.Collections.Generic;

namespace CustomerReader
{
    interface IDataReader<T>
    {
        List<T> dataList { get; set; }
        void DisplayData();
        void LoadData(String filePath);
        int getCount();
    }
}
