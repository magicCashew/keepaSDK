/* 
 * Keepa API
 *
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICategoryApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns Amazon category information from Keepa API.
        /// </summary>
        /// <remarks>
        /// Retrieve category objects using their node ids and (optional) their parent tree.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>List&lt;Category&gt;</returns>
        List<Category> Category (string key, int domain, int category, int parents);

        /// <summary>
        /// Returns Amazon category information from Keepa API.
        /// </summary>
        /// <remarks>
        /// Retrieve category objects using their node ids and (optional) their parent tree.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>ApiResponse of List&lt;Category&gt;</returns>
        ApiResponse<List<Category>> CategoryWithHttpInfo (string key, int domain, int category, int parents);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICategoryApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Returns Amazon category information from Keepa API.
        /// </summary>
        /// <remarks>
        /// Retrieve category objects using their node ids and (optional) their parent tree.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>Task of List&lt;Category&gt;</returns>
        System.Threading.Tasks.Task<List<Category>> CategoryAsync (string key, int domain, int category, int parents);

        /// <summary>
        /// Returns Amazon category information from Keepa API.
        /// </summary>
        /// <remarks>
        /// Retrieve category objects using their node ids and (optional) their parent tree.
        /// </remarks>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>Task of ApiResponse (List&lt;Category&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Category>>> CategoryAsyncWithHttpInfo (string key, int domain, int category, int parents);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICategoryApi : ICategoryApiSync, ICategoryApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CategoryApi : ICategoryApi
    {
        private Org.OpenAPITools.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoryApi() : this((string) null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoryApi(String basePath)
        {
            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                new Org.OpenAPITools.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CategoryApi(Org.OpenAPITools.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Org.OpenAPITools.Client.Configuration.MergeConfigurations(
                Org.OpenAPITools.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Org.OpenAPITools.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PetApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CategoryApi(Org.OpenAPITools.Client.ISynchronousClient client,Org.OpenAPITools.Client.IAsynchronousClient asyncClient, Org.OpenAPITools.Client.IReadableConfiguration configuration)
        {
            if(client == null) throw new ArgumentNullException("client");
            if(asyncClient == null) throw new ArgumentNullException("asyncClient");
            if(configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Org.OpenAPITools.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Org.OpenAPITools.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Org.OpenAPITools.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Org.OpenAPITools.Client.IReadableConfiguration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Org.OpenAPITools.Client.ExceptionFactory ExceptionFactory
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
        /// Returns Amazon category information from Keepa API. Retrieve category objects using their node ids and (optional) their parent tree.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>List&lt;Category&gt;</returns>
        public List<Category> Category (string key, int domain, int category, int parents)
        {
             Org.OpenAPITools.Client.ApiResponse<List<Category>> localVarResponse = CategoryWithHttpInfo(key, domain, category, parents);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns Amazon category information from Keepa API. Retrieve category objects using their node ids and (optional) their parent tree.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>ApiResponse of List&lt;Category&gt;</returns>
        public Org.OpenAPITools.Client.ApiResponse< List<Category> > CategoryWithHttpInfo (string key, int domain, int category, int parents)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'key' when calling CategoryApi->Category");

            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'domain' when calling CategoryApi->Category");

            // verify the required parameter 'category' is set
            if (category == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'category' when calling CategoryApi->Category");

            // verify the required parameter 'parents' is set
            if (parents == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'parents' when calling CategoryApi->Category");

            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };

            var localVarConentType = Org.OpenAPITools.Client.ClientUtils.SelectHeaderContentType(@contentTypes);
            if (localVarConentType != null) requestOptions.HeaderParameters.Add("Content-Type", localVarConentType);

            var localVarAccept = Org.OpenAPITools.Client.ClientUtils.SelectHeaderAccept(@accepts);
            if (localVarAccept != null) requestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (key != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "key", key))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (domain != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "domain", domain))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (category != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "category", category))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (parents != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "parents", parents))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = this.Client.Get< List<Category> >("/category", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Category", response);
                if (exception != null) throw exception;
            }

            return response;
        }

        /// <summary>
        /// Returns Amazon category information from Keepa API. Retrieve category objects using their node ids and (optional) their parent tree.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>Task of List&lt;Category&gt;</returns>
        public async System.Threading.Tasks.Task<List<Category>> CategoryAsync (string key, int domain, int category, int parents)
        {
             Org.OpenAPITools.Client.ApiResponse<List<Category>> localVarResponse = await CategoryAsyncWithHttpInfo(key, domain, category, parents);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Returns Amazon category information from Keepa API. Retrieve category objects using their node ids and (optional) their parent tree.
        /// </summary>
        /// <exception cref="Org.OpenAPITools.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="key">Your private API key.</param>
        /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
        /// <param name="category">The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.</param>
        /// <param name="parents">Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)</param>
        /// <returns>Task of ApiResponse (List&lt;Category&gt;)</returns>
        public async System.Threading.Tasks.Task<Org.OpenAPITools.Client.ApiResponse<List<Category>>> CategoryAsyncWithHttpInfo (string key, int domain, int category, int parents)
        {
            // verify the required parameter 'key' is set
            if (key == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'key' when calling CategoryApi->Category");

            // verify the required parameter 'domain' is set
            if (domain == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'domain' when calling CategoryApi->Category");

            // verify the required parameter 'category' is set
            if (category == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'category' when calling CategoryApi->Category");

            // verify the required parameter 'parents' is set
            if (parents == null)
                throw new Org.OpenAPITools.Client.ApiException(400, "Missing required parameter 'parents' when calling CategoryApi->Category");


            Org.OpenAPITools.Client.RequestOptions requestOptions = new Org.OpenAPITools.Client.RequestOptions();

            String[] @contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] @accepts = new String[] {
                "application/json"
            };
            
            foreach (var contentType in @contentTypes)
                requestOptions.HeaderParameters.Add("Content-Type", contentType);
            
            foreach (var accept in @accepts)
                requestOptions.HeaderParameters.Add("Accept", accept);
            
            if (key != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "key", key))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (domain != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "domain", domain))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (category != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "category", category))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }
            if (parents != null)
            {
                foreach (var kvp in Org.OpenAPITools.Client.ClientUtils.ParameterToMultiMap("", "parents", parents))
                {
                    foreach (var value in kvp.Value)
                    {
                        requestOptions.QueryParameters.Add(kvp.Key, value);
                    }
                }
            }


            // make the HTTP request

            var response = await this.AsynchronousClient.GetAsync<List<Category>>("/category", requestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Category", response);
                if (exception != null) throw exception;
            }

            return response;
        }

    }
}
