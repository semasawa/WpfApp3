using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp3.AppData
{
    public class AppConnect
    {
        public static user07EntitiesEntities model;

        public static user07EntitiesEntities GetContext()
        {
            if (model == null)
            {
                model = new user07EntitiesEntities();
            }
            return model;
        }
    }
}
