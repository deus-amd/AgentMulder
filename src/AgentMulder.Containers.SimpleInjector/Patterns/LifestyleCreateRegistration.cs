﻿using System.ComponentModel.Composition;
using AgentMulder.ReSharper.Domain.Patterns;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch;
using JetBrains.ReSharper.Psi.Services.CSharp.StructuralSearch.Placeholders;
using JetBrains.ReSharper.Psi.Services.StructuralSearch;

namespace AgentMulder.Containers.SimpleInjector.Patterns
{
    [Export("ComponentRegistration", typeof(IRegistrationPattern))]
    public class LifestyleCreateRegistration : RegisterWithService
    {
        // Lifestyle instance takes the Container as the parameter (or the last parameter in the non-generic version)
        // bug: for some reason, ReSharper cannot match this, so I omit the expression type...
        // bug: the search dialog CAN match it with the type, so I have no idea.
        // bug: the only thing that is evident, is that R# can't resolve the 'lifestyle' variable type
        private static readonly IStructuralSearchPattern pattern =
            new CSharpStructuralSearchPattern("$lifestyle$.CreateRegistration($arguments$)",
                new ExpressionPlaceholder("lifestyle", "global::SimpleInjector.Lifestyle", false),
                new ArgumentPlaceholder("arguments", -1, -1));

        public LifestyleCreateRegistration()
            : base(pattern)
        {
        }
    }
}