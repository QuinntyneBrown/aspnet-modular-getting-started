using Chloe.ViewModels.Contracts;
using System.Collections.Generic;

namespace Chloe.ViewModels
{
    public class Page
    {
        public Page()
        {
            this.Components = new HashSet<dynamic>();
        }

        public string Title { get; set; }

        public ICollection<dynamic> Components { get; set; }
    }
}
