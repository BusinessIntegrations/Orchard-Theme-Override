﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orchard;
using Orchard.DisplayManagement.Descriptors;

namespace Piedone.ThemeOverride.Services
{
    public interface IPlacementDeclaration
    {
        PlacementInfo Placement { get; }
        Func<ShapePlacementContext, bool> Predicate { get; }
    }


    public interface IPlacementProcessor : IDependency
    {
        IDictionary<string, IPlacementDeclaration> Process(string placementDeclaration);
    }
}
