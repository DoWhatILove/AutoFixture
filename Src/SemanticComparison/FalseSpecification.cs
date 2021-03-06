﻿using System;

namespace Ploeh.SemanticComparison
{
    /// <summary>
    /// A <see cref="ISpecification&lt;T&gt;"/> that is always <see langword="false"/>.
    /// </summary>
    public class FalseSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// Determines whether a candidate is satisfied by the Specification.
        /// </summary>
        /// <param name="candidate">The candidate.</param>
        /// <returns><see langword="false" /></returns>
        public bool IsSatisfiedBy(T candidate)
        {
            return false;
        }
    }
}
