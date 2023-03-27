using HotChocolate.Types;
using HotChocolate;

namespace hc_bugs
{
    [GraphQLName(TypeName)]
    [UnionType]    
    public interface IThingUnion
    {
        internal const string TypeName = "Thing";
    }
}
