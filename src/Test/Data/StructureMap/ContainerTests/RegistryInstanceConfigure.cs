﻿// Patterns: 1
// Matches: Foo.cs
// NotMatches: Bar.cs 

using StructureMap.Configuration.DSL;
using TestApplication.Types;

namespace TestApplication.StructureMap.ContainerTests
{
    public class RegistryInstanceConfigure
    {
        public RegistryInstanceConfigure()
        {
            var registry = new Registry();
            registry.For<IFoo>().Use<Foo>();
        }
    }
}