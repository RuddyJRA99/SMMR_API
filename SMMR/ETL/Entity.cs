using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SMMR.ETL
{
    public class Entity<T> where T : class 
    {
        public bool isValid()
        {
            List<PropertyInfo> properties = typeof(T).GetProperties().ToList<PropertyInfo>();
            //List<object> values =  properties.FirstOrDefault();
            foreach (var property in properties)
            {
                if (property.GetValue(this) == null) return false;
            }
            return true;
        }
    }
}
