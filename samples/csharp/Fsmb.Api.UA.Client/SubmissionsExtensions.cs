﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fsmb.Api.Ua.Client
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Submissions.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.22.0 (Newtonsoft.Json v11.0.0.0)")]
    public static partial class SubmissionsExtensions
    {
            /// <summary>
            /// Gets a submission by its ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='board'>
            /// Board code
            /// </param>
            /// <param name='id'>
            /// Submission ID
            /// </param>
            public static Submission GetById(this ISubmissions operations, string board, long id)
            {
                return Task.Factory.StartNew(s => ((ISubmissions)s).GetByIdAsync(board, id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a submission by its ID
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='board'>
            /// Board code
            /// </param>
            /// <param name='id'>
            /// Submission ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Submission> GetByIdAsync(this ISubmissions operations, string board, long id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(board, id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the submissions given a set of filters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static IList<Submission> GetByRequest(this ISubmissions operations, string board, string orderBy = default(string), int? page = default(int?), int? pageSize = default(int?), string fid = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?))
            {
                return Task.Factory.StartNew(s => ((ISubmissions)s).GetByRequestAsync(board, orderBy, page, pageSize, fid, fromDate, toDate), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the submissions given a set of filters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Submission>> GetByRequestAsync(this ISubmissions operations, string board, string orderBy = default(string), int? page = default(int?), int? pageSize = default(int?), string fid = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByRequestWithHttpMessagesAsync(board, orderBy, page, pageSize, fid, fromDate, toDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a summary of the submissions given a set of filters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            public static IList<SubmissionSummary> GetSummary(this ISubmissions operations, string board, string orderBy = default(string), int? page = default(int?), int? pageSize = default(int?), string fid = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?))
            {
                return Task.Factory.StartNew(s => ((ISubmissions)s).GetSummaryAsync(board, orderBy, page, pageSize, fid, fromDate, toDate), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a summary of the submissions given a set of filters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
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
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<SubmissionSummary>> GetSummaryAsync(this ISubmissions operations, string board, string orderBy = default(string), int? page = default(int?), int? pageSize = default(int?), string fid = default(string), DateTime? fromDate = default(DateTime?), DateTime? toDate = default(DateTime?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSummaryWithHttpMessagesAsync(board, orderBy, page, pageSize, fid, fromDate, toDate, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
