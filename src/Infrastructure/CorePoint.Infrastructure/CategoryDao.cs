namespace CorePoint.Infrastructure
{
    public class CategoryDao
    {
        private readonly IDbConnectionFactory _context;

        public CategoryDao(IDbConnectionFactory context)
        {
            _context = context; ;
        }
        //public bool Create(CategoryArgs args)
        //{
        //    using var connection = _context.Connection;
        //    connection.ExecuteAsync()
        //}
    }
}
