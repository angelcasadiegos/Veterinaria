using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace VeterinariaGUI
{
    public static class ConfigConection
    {
        public static string Conection = ConfigurationManager.ConnectionStrings["Defauld"].ConnectionString;
    }
}
