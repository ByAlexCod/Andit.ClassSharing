using System;
using System.Linq;
using System.Reflection;

namespace Andit.ClasseSharing
{
    public class SharingFactory
    {
        public string[] GetProperties(object t)
        {
            PropertyInfo[] props = t.GetType().GetProperties();
            return props.Select(e => e.Name).ToArray();
        }

        public string GetPropertyNameByType(object t, string type)
        {
            PropertyInfo[] props = t.GetType().GetProperties();
            return props.Where(e => e.GetCustomAttribute<TypeAttribute>().Type == type).FirstOrDefault().Name;
        }

        public object GetValueByType(object t, string type)
        {
            PropertyInfo[] props = t.GetType().GetProperties();
            
           return props.Where(e => e.GetCustomAttribute<TypeAttribute>().Type == type).FirstOrDefault().GetValue(t);
        }
    }
}
