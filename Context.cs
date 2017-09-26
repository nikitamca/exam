using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OMS.Models
{
    public class Context:DbContext
    {
        public Class1 cls { get; set; }
        public Context() : base(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Admin\Desktop\Office-Management-System-master\OMS\App_Data\Database1.mdf;Integrated Security=True") { }
    }
}