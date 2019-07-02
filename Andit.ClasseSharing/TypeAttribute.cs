using System;
using System.Collections.Generic;
using System.Text;

namespace Andit.ClasseSharing
{
    [AttributeUsage(
    AttributeTargets.Field |
    AttributeTargets.Property,
    AllowMultiple = false)]


    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string text)
        {
            Type = text;
        }

        public string Type { get; }
    }
}
