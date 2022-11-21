using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows;

namespace Petanee
{
    internal class Weather
    {
        
        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class root
        {
            public coord coord { get; set; }
        }
        
    }
}
