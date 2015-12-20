﻿using Chloe.ViewModels.Contracts;
using System.Collections.Generic;
using System.Net.Http;

namespace Chloe.ViewModels
{
    public class PageViewModel: IPageViewModel
    {
        public PageViewModel()
        {
            this.Components = new HashSet<IComponent>();
        }

        public string Title { get; set; }

        public ICollection<IComponent> Components { get; set; }

        public virtual void Initialize()
        {
            foreach(var component in this.Components)
            {
                component.Initialize();
            }
        }
    }
}