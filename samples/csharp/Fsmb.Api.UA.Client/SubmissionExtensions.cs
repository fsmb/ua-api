/*
 * Copyright © Federation of State Medical Boards
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated 
 * documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
 * rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 * persons to whom the Software is furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
 * COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, 
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */
using System;
using Fsmb.Api.Ua.Client.Models;

namespace Fsmb.Api.Ua.Client
{
    /// <summary>Provides extension methods for <see cref="Submission"/>.</summary>
    public static class SubmissionExtensions
    {
        /// <summary>Determines if the PDC report is available.</summary>
        /// <param name="submission">Submission</param>
        /// <returns>true if the pdc report is available.</returns>
        public static bool IsPdcReportAvailable ( this Submission submission ) => submission.Pdc != null && String.Equals(submission.PdcReportStatus, "Available", StringComparison.OrdinalIgnoreCase);

        /// <summary>Determines if the PDC report is pending.</summary>
        /// <param name="submission">Submission</param>
        /// <returns>true if the PDC report is still pending.</returns>
        public static bool IsPdcReportPending ( this Submission submission ) => String.Equals(submission.PdcReportStatus, "Pending", StringComparison.OrdinalIgnoreCase);
    }
}
