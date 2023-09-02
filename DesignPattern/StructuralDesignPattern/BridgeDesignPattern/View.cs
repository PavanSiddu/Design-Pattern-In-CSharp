using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.StructuralDesignPattern.BridgeDesignPattern
{
    public abstract class View
    {
        protected IResource resource;
        protected View(IResource resource)
        {
            this.resource = resource;
        }
        public abstract void Show();
    }

    public class LongView : View
    {
        public LongView(IResource resource) : base(resource)
        {
        }
        public override void Show()
        {
            resource.Snippet();
        }
    }
}
