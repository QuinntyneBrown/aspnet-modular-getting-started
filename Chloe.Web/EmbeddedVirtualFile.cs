using System.Reflection;
using System.Web;
using System.Web.Hosting;

namespace Chloe.Web
{
    public class EmbeddedVirtualFile : VirtualFile
    {
        private readonly string virtualPath;
        private readonly Assembly assembly;

        public EmbeddedVirtualFile(string virtualPath)
            : base(virtualPath)
        {
            this.assembly = this.GetType().Assembly;
            this.virtualPath = VirtualPathUtility.ToAppRelative(virtualPath);
        }

        public override System.IO.Stream Open()
        {
            var resourceName = this.GetType().Namespace + "." + virtualPath.Replace("~/", "").Replace("/", ".");
            return assembly.GetManifestResourceStream(resourceName);

        }
    }
}
