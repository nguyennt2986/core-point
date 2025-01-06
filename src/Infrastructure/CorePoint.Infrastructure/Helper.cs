using System.Reflection;
using CorePoint.Domain.Extension;
using Dapper;

namespace CorePoint.Infrastructure
{
    internal static class Helper
    {
        public static DynamicParameters BuildParameters<T>(T entity) where T : class
        {
            var parameters = new DynamicParameters();
            var properties = entity.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attribute = property.GetCustomAttribute<DbParameterNameAttribute>();
                var paramName = attribute?.Name ?? property.Name;
                parameters.Add(paramName, property.GetValue(entity));
            }

            return parameters;
        }

        public static DynamicParameters BuildParameters(Dictionary<string, object> param)
        {
            var parameters = new DynamicParameters();
            foreach (var item in param)
            {
                parameters.Add(item.Key, item.Value);
            }
            return parameters;
        }
    }
}
