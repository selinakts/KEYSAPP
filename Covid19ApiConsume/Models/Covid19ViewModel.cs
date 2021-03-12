using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covid19ApiConsume.Models
{
    public class Covid19ViewModel
    {

        public GlobalViewModel Global { get; set; }
        public IEnumerable<CountryViewModel> Countries { get; set; }
        public DateTime Date { get; set; }

        
    }
}