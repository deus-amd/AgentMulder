﻿using StructureMap;
using TestApplication.Types;

namespace TestApplication.StructureMap.ScanTests
{
    public class ScanAssemblyTypeofTAssembly
    {
        public ScanAssemblyTypeofTAssembly()
        {
            var container = new Container(x => x.Scan(scanner =>
            {
                scanner.Assembly(typeof(IFoo).Assembly);
                scanner.WithDefaultConventions();
            }));

        } 
    }
}