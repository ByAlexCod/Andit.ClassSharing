using Andit.ClasseSharing;
using System;
using System.Collections.Generic;
using System.Text;

namespace Andit.ClassSharing.Tests
{
    public class ExampleClass
    {
        [TypeAttribute("Identifier")]
        public int UserId { get; set; }
        [TypeAttribute("Name")]
        public string UserName { get; set; }
        [TypeAttribute("Mail")]
        public string Mail { get; set; }

    }
}
