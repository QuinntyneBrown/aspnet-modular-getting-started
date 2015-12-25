using System;

namespace Chloe.ViewModels
{
    public class ClientDenpendencyAttribute : Attribute
    {
        public ClientDenpendencyAttribute(string fullFileName, int orderIndex = 0)
        {
            this.FullFileName = fullFileName;
            this.OrderIndex = orderIndex;
        }

        public int OrderIndex { get; set; }
        public string FullFileName { get; set; }
    }
}
