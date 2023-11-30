using Arch.Core;
using Arch.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;
using Undine.Core.Struct;

namespace Undine.Arch.Struct
{
    public class ArchEntity : IUnifiedEntity
    {
        public Entity Entity;

        public void AddComponent<A>(in A component) where A : struct
        {
            Entity.Add(component);
        }

        public ref A GetComponent<A>() where A : struct
        {
            ref var result = ref Entity.Get<A>();
            return ref result;
        }
    }
}