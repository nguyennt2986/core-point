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
                parameters.Add(property.Name, property.GetValue(entity));
            }

            return parameters;
        }
    }
}
