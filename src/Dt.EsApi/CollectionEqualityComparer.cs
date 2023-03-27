using System.Collections.Generic;
using System.Linq;

namespace Dt.EsApi
{
    public sealed class CollectionEqualityComparer<T> : IEqualityComparer<IReadOnlyCollection<T>>
    {
        public static CollectionEqualityComparer<T> Default { get; } = new CollectionEqualityComparer<T>();

        /// <inheritdoc />
        public bool Equals(IReadOnlyCollection<T>? x, IReadOnlyCollection<T>? y)
        {
            if (x is null && y is null)
            {
                return true;
            }

            if (x is not null && y is not null)
            {
                return x.Count == y.Count && x.SequenceEqual(y);
            }

            return false;
        }

        private CollectionEqualityComparer() { }

        /// <inheritdoc />
        public int GetHashCode(IReadOnlyCollection<T>? obj)
        {
            return obj?.Aggregate(-659746988, (current, item) => current * -1521134295 + (item?.GetHashCode() ?? 0)) ?? 0;
        }
    }
}
