﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CatelContainerInfo.cs" company="Catel & Agent Mulder development teams">
//   Copyright (c) 2008 - 2012 Catel & Agent Mulder development teams. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.ComponentModel.Composition.Primitives;

namespace AgentMulder.Containers.Catel
{
    using System;
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;
    using System.Reflection;

    using ReSharper.Domain.Containers;

    [Export(typeof(IContainerInfo))]
    public class CatelContainerInfo : ContainerInfoBase
    {
        public override string ContainerDisplayName
        {
            get { return "Catel"; }
        }

        protected override ComposablePartCatalog GetComponentCatalog()
        {
            return new AssemblyCatalog(Assembly.GetExecutingAssembly());
        }
    }
}