

namespace WebApiData.CoreModel
{
    public abstract class Request<TEntity>
         where TEntity : class
    {
        /// <summary>
        /// Filtering model class.
        /// </summary>
        public TEntity Model { get; set; }
    }
}
