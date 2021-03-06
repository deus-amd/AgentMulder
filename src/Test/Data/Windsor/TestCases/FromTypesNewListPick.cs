// Patterns: 1
// Matches: Foo.cs,Bar.cs,Baz.cs
// NotMatches: IFoo.cs

using System;
using System.Collections.Generic;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TestApplication.Types;

namespace TestApplication.Windsor.TestCases
{
    public class FromTypesNewListPick : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                AllTypes.From(new List<Type> { typeof(Foo), typeof(Bar), typeof(Baz) }).Pick(),
                Classes.From(new List<Type> { typeof(Foo), typeof(Bar), typeof(Baz) }).Pick(),
                Castle.MicroKernel.Registration.Types.From(new List<Type> { typeof(Foo), typeof(Bar), typeof(Baz) }).Pick()
                );
        }
    }
}