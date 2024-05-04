namespace NswagDemo.Controllers
{
    public partial class SwaggerResponse
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="result"></param>
        /// <returns></returns>
        public static SwaggerResponse<TResult> Ok<TResult>(TResult result)
        {
            return Ok(new Dictionary<string, IEnumerable<string>>(), result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="headers"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static SwaggerResponse<TResult> Ok<TResult>(IReadOnlyDictionary<string, IEnumerable<string>> headers, TResult result)
        {
            var dict = new Dictionary<string, IEnumerable<string>>();
            if (headers.ContainsKey("X-Pagination"))
            {
                dict.Add("X-Pagination", headers["X-Pagination"]);
            }
            return new SwaggerResponse<TResult>(200, dict, result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="result"></param>
        /// <returns></returns>
        public static SwaggerResponse<TResult> BadRequest<TResult>(TResult result)
        {
            var dict = new Dictionary<string, IEnumerable<string>>();
            return new SwaggerResponse<TResult>(400, dict, result);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="result"></param>
        /// <returns></returns>
        public static SwaggerResponse<TResult> NotAuthenticated<TResult>(TResult result)
        {
            var dict = new Dictionary<string, IEnumerable<string>>();
            return new SwaggerResponse<TResult>(403, dict, result);
        }
    }
}
