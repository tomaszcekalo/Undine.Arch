using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Undine.Arch.Tests.Components;
using Undine.Core;

namespace Undine.Arch.Tests
{
    [TestClass]
    public class EntityTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void ComponentCanBeAdded()
        {
            var container = new ArchContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
        }

        [TestMethod]
        public void ComponentCanBeRetrieved()
        {
            var container = new ArchContainer();
            var mock = Substitute.For<UnifiedSystem<AComponent>>();
            container.AddSystem(mock);
            container.Init();
            var entity = (ArchEntity)container.CreateNewEntity();
            entity.AddComponent(new AComponent());

            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }//
    }
}