using Arch.Core;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

using Undine.Core;

namespace Undine.Arch
{
    public class ArchSystem<A> : ISystem
        where A : struct
    {
        public UnifiedSystem<A> System { get; set; }
        public World World { get; set; }

        public void ProcessAll()
        {
            var query = new QueryDescription().WithAll<A>();
            World.Query(in query, (ref A a) =>
            {
                System.ProcessSingleEntity(0, ref a);
            });
        }
    }

    public class ArchSystem<A, B> : ISystem
        where A : struct
        where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }
        public World World { get; set; }

        public void ProcessAll()
        {
            var query = new QueryDescription().WithAll<A, B>();
            World.Query(in query, (ref A a, ref B b) =>
            {
                System.ProcessSingleEntity(0, ref a, ref b);
            });
        }
    }

    public class ArchSystem<A, B, C> : ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }
        public World World { get; set; }

        public void ProcessAll()
        {
            var query = new QueryDescription().WithAll<A, B, C>();
            World.Query(in query, (ref A a, ref B b, ref C c) =>
            {
                System.ProcessSingleEntity(0, ref a, ref b, ref c);
            });
        }
    }

    public class ArchSystem<A, B, C, D> : ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }
        public World World { get; set; }

        public void ProcessAll()
        {
            var query = new QueryDescription().WithAll<A, B, C, D>();
            World.Query(in query, (ref A a, ref B b, ref C c, ref D d) =>
            {
                System.ProcessSingleEntity(0, ref a, ref b, ref c, ref d);
            });
        }
    }
}