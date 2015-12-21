using System.Collections.Generic;

namespace Chloe.Models
{
    public class Component
    {
        public Component()
        {
            this.Pages = new HashSet<Page>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Page> Pages { get; set; }
    }
}
