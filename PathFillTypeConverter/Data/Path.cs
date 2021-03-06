﻿using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using PathFillTypeConverter.Extensions;

namespace PathFillTypeConverter.Data
{
    [Serializable]
    public class Path
    {
        [NotNull]
        public IReadOnlyList<Subpath> Subpaths { get; }

        public Path([NotNull] IEnumerable<Subpath> subpaths)
        {
            Subpaths = subpaths.ToReadOnlyList();

            if (Subpaths.Any(x => x == null))
            {
                throw new ArgumentException();
            }
        }
    }
}
