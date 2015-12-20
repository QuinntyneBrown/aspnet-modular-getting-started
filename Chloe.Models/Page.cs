using System.Collections.Generic;

namespace Chloe.Models
{
    public class Page
    {
        public Page()
        {
            this.Components = new HashSet<Component>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string RouteName { get; set; }

        public ICollection<Component> Components { get; set; }

    }
}
