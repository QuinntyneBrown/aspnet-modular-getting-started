using System;
using Chloe.ViewComponents.Contracts;

namespace Chloe.ViewComponents.HelloWorldComponent
{
    public class HelloWorldComponent : IHelloWorldComponent
    {
        public HelloWorldComponent()
        {
            this.Message = "Hello World";
        }
        public string Message { get; set; }
        
    }
}
