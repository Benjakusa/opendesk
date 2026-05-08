using System.Collections.Generic;

namespace OpenDesk.Infrastructure.Data
{
    public interface IEntityCreator<out TModel>
    {
        IEnumerable<TModel> CreateItems(IEnumerable<string> data);
    }
}