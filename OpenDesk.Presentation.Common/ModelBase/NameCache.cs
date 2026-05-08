using System;
using System.Collections.Generic;
using Microsoft.Practices.Prism.Events;
using OpenDesk.Infrastructure.Data;
using OpenDesk.Persistance.Data;
using OpenDesk.Presentation.Services.Common;

namespace OpenDesk.Presentation.Common.ModelBase
{
    public static class NameCache
    {
        private static readonly Dictionary<Type, Dictionary<int, string>> Names =
            new Dictionary<Type, Dictionary<int, string>>();

        public static string GetName<T>(int entityId) where T : class,IEntityClass
        {
            if (!Names.ContainsKey(typeof(T)))
                Names.Add(typeof(T), new Dictionary<int, string>());
            if (!Names[typeof(T)].ContainsKey(entityId))
            {
                var entity = Dao.Single<T>(x => x.Id == entityId);
                if (entity == null) return "";
                Names[typeof(T)].Add(entityId, entity.Name);
            }
            return Names[typeof(T)][entityId];
        }

        static NameCache()
        {
            EventServiceFactory.EventService.GetEvent<GenericEvent<EventAggregator>>().Subscribe(
                x =>
                {
                    if (x.Topic == EventTopicNames.ResetCache)
                    {
                        Names.Clear();
                    }
                });
        }
    }
}
