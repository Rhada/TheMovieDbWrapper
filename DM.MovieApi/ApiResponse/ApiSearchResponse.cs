using System.Collections.Generic;
using System.Runtime.Serialization;

namespace DM.MovieApi.ApiResponse
{
    /// <summary>
    /// Standard response from an API call returning a more than one result, i.e., a Search Result.
    /// Single item based results are returned with an <see cref="ApiQueryResponse{T}"/>.
    /// </summary>
    [DataContract]
    public class ApiSearchResponse<T> : ApiResponseBase
    {
        /// <summary>
        /// The list of results from the search.
        /// </summary>
        [DataMember( Name = "results" )]
        public IReadOnlyList<T> Results { get; private set; }

        /// <summary>
        /// The current page number of the search result.
        /// </summary>
        [DataMember( Name = "page" )]
        public int PageNumber { get; private set; }

        /// <summary>
        /// The total number of pages found from the search result.
        /// </summary>
        [DataMember( Name = "total_pages" )]
        public int TotalPages { get; private set; }

        /// <summary>
        /// The total number of results from the search.
        /// </summary>
        [DataMember( Name = "total_results" )]
        public int TotalResults { get; private set; }

        public override string ToString()
        {
            return string.Format( "Page {0} of {1} ({2} total results)", PageNumber, TotalPages, TotalResults );
        }
    }
}