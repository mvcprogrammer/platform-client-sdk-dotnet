using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using PureCloudPlatform.Client.V2.Client;
using PureCloudPlatform.Client.V2.Model;

namespace PureCloudPlatform.Client.V2.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStationsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns></returns>
        void DeleteStationAssociateduser (string stationId);

        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteStationAssociateduserWithHttpInfo (string stationId);
        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Station</returns>
        Station GetStation (string stationId);

        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>ApiResponse of Station</returns>
        ApiResponse<Station> GetStationWithHttpInfo (string stationId);
        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>StationEntityListing</returns>
        StationEntityListing GetStations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);

        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>ApiResponse of StationEntityListing</returns>
        ApiResponse<StationEntityListing> GetStationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteStationAssociateduserAsync (string stationId);

        /// <summary>
        /// Unassigns the user assigned to this station
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStationAssociateduserAsyncWithHttpInfo (string stationId);
        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of Station</returns>
        System.Threading.Tasks.Task<Station> GetStationAsync (string stationId);

        /// <summary>
        /// Get station.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of ApiResponse (Station)</returns>
        System.Threading.Tasks.Task<ApiResponse<Station>> GetStationAsyncWithHttpInfo (string stationId);
        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>Task of StationEntityListing</returns>
        System.Threading.Tasks.Task<StationEntityListing> GetStationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);

        /// <summary>
        /// Get the list of available stations.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>Task of ApiResponse (StationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<StationEntityListing>> GetStationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StationsApi : IStationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StationsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StationsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StationsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

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
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns></returns>
        public void DeleteStationAssociateduser (string stationId)
        {
             DeleteStationAssociateduserWithHttpInfo(stationId);
        }

        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteStationAssociateduserWithHttpInfo (string stationId)
        {
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->DeleteStationAssociateduser");

            var localVarPath = "/api/v2/stations/{stationId}/associateduser";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteStationAssociateduserAsync (string stationId)
        {
             await DeleteStationAssociateduserAsyncWithHttpInfo(stationId);

        }

        /// <summary>
        /// Unassigns the user assigned to this station 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteStationAssociateduserAsyncWithHttpInfo (string stationId)
        {
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->DeleteStationAssociateduser");

            var localVarPath = "/api/v2/stations/{stationId}/associateduser";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteStationAssociateduser: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarHeaders,
                null);
        }

        /// <summary>
        /// Get station. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Station</returns>
        public Station GetStation (string stationId)
        {
             ApiResponse<Station> localVarResponse = GetStationWithHttpInfo(stationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get station. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>ApiResponse of Station</returns>
        public ApiResponse< Station > GetStationWithHttpInfo (string stationId)
        {
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->GetStation");

            var localVarPath = "/api/v2/stations/{stationId}";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

            // authentication (PureCloud Auth) required
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetStation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Station>(localVarStatusCode,
                localVarHeaders,
                (Station) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Station)));
            
        }

        /// <summary>
        /// Get station. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of Station</returns>
        public async System.Threading.Tasks.Task<Station> GetStationAsync (string stationId)
        {
             ApiResponse<Station> localVarResponse = await GetStationAsyncWithHttpInfo(stationId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get station. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="stationId">Station ID</param>
        /// <returns>Task of ApiResponse (Station)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Station>> GetStationAsyncWithHttpInfo (string stationId)
        {
            // verify the required parameter 'stationId' is set
            if (stationId == null)
                throw new ApiException(400, "Missing required parameter 'stationId' when calling StationsApi->GetStation");

            var localVarPath = "/api/v2/stations/{stationId}";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (stationId != null) localVarPathParams.Add("stationId", Configuration.ApiClient.ParameterToString(stationId)); // path parameter

            // authentication (PureCloud Auth) required
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetStation: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStation: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Station>(localVarStatusCode,
                localVarHeaders,
                (Station) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Station)));
            
        }

        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>StationEntityListing</returns>
        public StationEntityListing GetStations (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
        {
             ApiResponse<StationEntityListing> localVarResponse = GetStationsWithHttpInfo(pageSize, pageNumber, sortBy, name, userSelectable, webRtcUserId, id, lineAppearanceId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>ApiResponse of StationEntityListing</returns>
        public ApiResponse< StationEntityListing > GetStationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
        {

            var localVarPath = "/api/v2/stations";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (userSelectable != null) localVarQueryParams.Add("userSelectable", Configuration.ApiClient.ParameterToString(userSelectable)); // query parameter
            if (webRtcUserId != null) localVarQueryParams.Add("webRtcUserId", Configuration.ApiClient.ParameterToString(webRtcUserId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (lineAppearanceId != null) localVarQueryParams.Add("lineAppearanceId", Configuration.ApiClient.ParameterToString(lineAppearanceId)); // query parameter

            // authentication (PureCloud Auth) required
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetStations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (StationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StationEntityListing)));
            
        }

        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>Task of StationEntityListing</returns>
        public async System.Threading.Tasks.Task<StationEntityListing> GetStationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
        {
             ApiResponse<StationEntityListing> localVarResponse = await GetStationsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, name, userSelectable, webRtcUserId, id, lineAppearanceId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the list of available stations. 
        /// </summary>
        /// <exception cref="PureCloudPlatform.Client.V2.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="sortBy">Sort by (optional, default to name)</param>
        /// <param name="name">Name (optional)</param>
        /// <param name="userSelectable">True for stations that the user can select otherwise false (optional)</param>
        /// <param name="webRtcUserId">Filter for the webRtc station of the webRtcUserId (optional)</param>
        /// <param name="id">Comma separated list of stationIds (optional)</param>
        /// <param name="lineAppearanceId">lineAppearanceId (optional)</param>
        /// <returns>Task of ApiResponse (StationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<StationEntityListing>> GetStationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string name = null, string userSelectable = null, string webRtcUserId = null, string id = null, string lineAppearanceId = null)
        {

            var localVarPath = "/api/v2/stations";
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

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (userSelectable != null) localVarQueryParams.Add("userSelectable", Configuration.ApiClient.ParameterToString(userSelectable)); // query parameter
            if (webRtcUserId != null) localVarQueryParams.Add("webRtcUserId", Configuration.ApiClient.ParameterToString(webRtcUserId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // query parameter
            if (lineAppearanceId != null) localVarQueryParams.Add("lineAppearanceId", Configuration.ApiClient.ParameterToString(lineAppearanceId)); // query parameter

            // authentication (PureCloud Auth) required
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

            Dictionary<string, string> localVarHeaders = localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString());

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetStations: " + localVarResponse.Content, localVarResponse.Content, localVarHeaders);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetStations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<StationEntityListing>(localVarStatusCode,
                localVarHeaders,
                (StationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(StationEntityListing)));
            
        }

    }
}
