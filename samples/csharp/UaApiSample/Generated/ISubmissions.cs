﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Apis.Ua.Clients
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Submissions operations.
    /// </summary>
    public partial interface ISubmissions
    {
        /// <summary>
        /// Gets a submission by its ID
        /// </summary>
        /// <param name='board'>
        /// Board code
        /// </param>
        /// <param name='id'>
        /// Submission ID
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<Submission>> GetByIdWithHttpMessagesAsync(string board, long id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the submissions given a set of filters
        /// </summary>
        /// <param name='board'>
        /// Board code
        /// </param>
        /// <param name='orderBy'>
        /// </param>
        /// <param name='page'>
        /// </param>
        /// <param name='pageSize'>
        /// </param>
        /// <param name='fid'>
        /// FID to filter (optional if FromDate is set)
        /// </param>
        /// <param name='fromDate'>
        /// Start date to filter by (optional if Fid is set)
        /// </param>
        /// <param name='toDate'>
        /// End date to filter by (must be &gt;= FromDate)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<Submission>>> GetByRequestWithHttpMessagesAsync(string board, string orderBy = default(string), int? page = default(int?), int? pageSize = default(int?), string fid = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get a summary of the submissions given a set of filters
        /// </summary>
        /// <param name='board'>
        /// Board code
        /// </param>
        /// <param name='orderBy'>
        /// </param>
        /// <param name='page'>
        /// </param>
        /// <param name='pageSize'>
        /// </param>
        /// <param name='fid'>
        /// FID to filter (optional if FromDate is set)
        /// </param>
        /// <param name='fromDate'>
        /// Start date to filter by (optional if Fid is set)
        /// </param>
        /// <param name='toDate'>
        /// End date to filter by (must be &gt;= FromDate)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<IList<SubmissionSummary>>> GetSummaryWithHttpMessagesAsync(string board, string orderBy = default(string), int? page = default(int?), int? pageSize = default(int?), string fid = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
