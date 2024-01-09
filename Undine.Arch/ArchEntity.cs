using Arch.Core;
using Arch.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Arch
{
    public class ArchEntity : IUnifiedEntity
    {
        public Entity Entity;

        public void AddComponent<A>(in A component) where A : struct
        {
            this.Entity.Add<A>(component);
        }

        public ref A GetComponent<A>() where A : struct
        {
            ref var result = ref this.Entity.Get<A>();
            return ref result;
        }
    }
}