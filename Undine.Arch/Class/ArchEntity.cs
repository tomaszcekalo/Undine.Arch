using Arch.Core;
using Arch.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core.Class;

namespace Undine.Arch.Class
{
    public class ArchEntity : IUnifiedEntity
    {
        public Entity Entity;

        public void AddComponent<A>(in A component) where A : class
        {
            Entity.Add(component);
        }

        public ref A GetComponent<A>() where A : class
        {
            ref var result = ref Entity.Get<A>();
            return ref result;
        }
    }
}