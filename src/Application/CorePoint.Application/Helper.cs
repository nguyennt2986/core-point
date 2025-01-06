using CorePoint.Domain.Extension;
using Dapper;
using System.Reflection;

namespace CorePoint.Application
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
    }
}
