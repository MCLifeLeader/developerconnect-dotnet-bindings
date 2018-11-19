/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/

/* 
 * Loan Pipeline
 *
 * Retrieve loan GUIDs and attributes of loans that match a criteria
 *
 * OpenAPI spec version: 1.4.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Elli.Api.Loans.Pipeline.Client;
using Elli.Api.Loans.Pipeline.Model;

namespace Elli.Api.Loans.Pipeline.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILoanPipelineApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PipelineFieldDefsContract</returns>
        PipelineFieldDefsContract GetFieldDefinitions ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PipelineFieldDefsContract</returns>
        ApiResponse<PipelineFieldDefsContract> GetFieldDefinitionsWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>List&lt;LoanPipelineItemContract&gt;</returns>
        List<LoanPipelineItemContract> PipelineRequest (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>ApiResponse of List&lt;LoanPipelineItemContract&gt;</returns>
        ApiResponse<List<LoanPipelineItemContract>> PipelineRequestWithHttpInfo (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PipelineFieldDefsContract</returns>
        System.Threading.Tasks.Task<PipelineFieldDefsContract> GetFieldDefinitionsAsync ();

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PipelineFieldDefsContract)</returns>
        System.Threading.Tasks.Task<ApiResponse<PipelineFieldDefsContract>> GetFieldDefinitionsAsyncWithHttpInfo ();
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>Task of List&lt;LoanPipelineItemContract&gt;</returns>
        System.Threading.Tasks.Task<List<LoanPipelineItemContract>> PipelineRequestAsync (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LoanPipelineItemContract&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<LoanPipelineItemContract>>> PipelineRequestAsyncWithHttpInfo (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LoanPipelineApi : ILoanPipelineApi
    {
        private Elli.Api.Loans.Pipeline.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPipelineApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LoanPipelineApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Elli.Api.Loans.Pipeline.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoanPipelineApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LoanPipelineApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Elli.Api.Loans.Pipeline.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Elli.Api.Loans.Pipeline.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>PipelineFieldDefsContract</returns>
        public PipelineFieldDefsContract GetFieldDefinitions ()
        {
             ApiResponse<PipelineFieldDefsContract> localVarResponse = GetFieldDefinitionsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of PipelineFieldDefsContract</returns>
        public ApiResponse< PipelineFieldDefsContract > GetFieldDefinitionsWithHttpInfo ()
        {

            var localVarPath = "/encompass/v1/loanPipeline/fieldDefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFieldDefinitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PipelineFieldDefsContract>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PipelineFieldDefsContract) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PipelineFieldDefsContract)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of PipelineFieldDefsContract</returns>
        public async System.Threading.Tasks.Task<PipelineFieldDefsContract> GetFieldDefinitionsAsync ()
        {
             ApiResponse<PipelineFieldDefsContract> localVarResponse = await GetFieldDefinitionsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (PipelineFieldDefsContract)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PipelineFieldDefsContract>> GetFieldDefinitionsAsyncWithHttpInfo ()
        {

            var localVarPath = "/encompass/v1/loanPipeline/fieldDefinitions";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);


            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFieldDefinitions", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PipelineFieldDefsContract>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PipelineFieldDefsContract) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PipelineFieldDefsContract)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>List&lt;LoanPipelineItemContract&gt;</returns>
        public List<LoanPipelineItemContract> PipelineRequest (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null)
        {
             ApiResponse<List<LoanPipelineItemContract>> localVarResponse = PipelineRequestWithHttpInfo(limit, cursorType, cursor, start, contract, ignoreInvalidFields);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>ApiResponse of List&lt;LoanPipelineItemContract&gt;</returns>
        public ApiResponse< List<LoanPipelineItemContract> > PipelineRequestWithHttpInfo (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null)
        {

            var localVarPath = "/encompass/v1/loanPipeline/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (cursorType != null) localVarQueryParams.Add("cursorType", Configuration.ApiClient.ParameterToString(cursorType)); // query parameter
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (ignoreInvalidFields != null) localVarQueryParams.Add("ignoreInvalidFields", Configuration.ApiClient.ParameterToString(ignoreInvalidFields)); // query parameter
            if (contract != null && contract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contract; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PipelineRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LoanPipelineItemContract>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LoanPipelineItemContract>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LoanPipelineItemContract>)));
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>Task of List&lt;LoanPipelineItemContract&gt;</returns>
        public async System.Threading.Tasks.Task<List<LoanPipelineItemContract>> PipelineRequestAsync (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null)
        {
             ApiResponse<List<LoanPipelineItemContract>> localVarResponse = await PipelineRequestAsyncWithHttpInfo(limit, cursorType, cursor, start, contract, ignoreInvalidFields);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="Elli.Api.Loans.Pipeline.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="limit"> (optional)</param>
        /// <param name="cursorType"> (optional)</param>
        /// <param name="cursor"> (optional)</param>
        /// <param name="start"> (optional)</param>
        /// <param name="contract"> (optional)</param>
        /// <param name="ignoreInvalidFields">Indicates whether to ignore invalid fields requested from response. Accepted values - true and false, default is false. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;LoanPipelineItemContract&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<LoanPipelineItemContract>>> PipelineRequestAsyncWithHttpInfo (string limit = null, string cursorType = null, string cursor = null, string start = null, LoanPipelineViewContract contract = null, string ignoreInvalidFields = null)
        {

            var localVarPath = "/encompass/v1/loanPipeline/";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (limit != null) localVarQueryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            if (cursorType != null) localVarQueryParams.Add("cursorType", Configuration.ApiClient.ParameterToString(cursorType)); // query parameter
            if (cursor != null) localVarQueryParams.Add("cursor", Configuration.ApiClient.ParameterToString(cursor)); // query parameter
            if (start != null) localVarQueryParams.Add("start", Configuration.ApiClient.ParameterToString(start)); // query parameter
            if (ignoreInvalidFields != null) localVarQueryParams.Add("ignoreInvalidFields", Configuration.ApiClient.ParameterToString(ignoreInvalidFields)); // query parameter
            if (contract != null && contract.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(contract); // http body (model) parameter
            }
            else
            {
                localVarPostBody = contract; // byte array
            }

            // authentication (bearerAuth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PipelineRequest", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<LoanPipelineItemContract>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<LoanPipelineItemContract>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<LoanPipelineItemContract>)));
        }

    }
}
