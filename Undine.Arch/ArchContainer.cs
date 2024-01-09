using Arch.Core;
using Arch.Core.Extensions;
using System;
using System.Collections.Generic;
using Undine.Core;

namespace Undine.Arch
{
    public class ArchContainer : EcsContainer
    {
        private List<ISystem> systems = new List<ISystem>();

        public ArchContainer()
        {
            this.World = World.Create();
        }

        public World World { get; }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            systems.Add(new ArchSystem<A>()
            {
                System = system,
                World = this.World
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            systems.Add(new ArchSystem<A, B>()
            {
                System = system,
                World = this.World
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            systems.Add(new ArchSystem<A, B, C>()
            {
                System = system,
                World = this.World
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            systems.Add(new ArchSystem<A, B, C, D>()
            {
                System = system,
                World = this.World
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            return new ArchEntity()
            {
                Entity = this.World.Create()
            };
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new ArchSystem<A>()
            {
                System = system,
                World = this.World
            };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new ArchSystem<A, B>()
            {
                System = system,
                World = this.World
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new ArchSystem<A, B, C>()
            {
                System = system,
                World = this.World
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new ArchSystem<A, B, C, D>()
            {
                System = system,
                World = this.World
            };
        }

        public override void Run()
        {
            foreach (var system in systems)
            {
                system.ProcessAll();
            }
        }
    }
}