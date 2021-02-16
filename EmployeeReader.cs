using CustomerReader.Model;
using System;
using System.Collections.Generic;

namespace CustomerReader
{
    public abstract class EmployeeReader : IDataReader<Employee>
    {
        public List<Employee> dataList { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DisplayData()
        {
            throw new NotImplementedException();
        }

        public int GetCount()
        {
            throw new NotImplementedException();
        }

        public void LoadData(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
