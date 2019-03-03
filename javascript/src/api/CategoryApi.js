/**
 * Keepa API
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 4.0.0-beta2
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/Category'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/Category'));
  } else {
    // Browser globals (root is window)
    if (!root.KeepaApi) {
      root.KeepaApi = {};
    }
    root.KeepaApi.CategoryApi = factory(root.KeepaApi.ApiClient, root.KeepaApi.Category);
  }
}(this, function(ApiClient, Category) {
  'use strict';

  /**
   * Category service.
   * @module api/CategoryApi
   * @version 1.0.0
   */

  /**
   * Constructs a new CategoryApi. 
   * @alias module:api/CategoryApi
   * @class
   * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the category operation.
     * @callback module:api/CategoryApi~categoryCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/Category>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Returns Amazon category information from Keepa API.
     * Retrieve category objects using their node ids and (optional) their parent tree.
     * @param {String} key Your private API key.
     * @param {module:model/Number} domain Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
     * @param {Number} category The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.
     * @param {module:model/Number} parents Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)
     * @param {module:api/CategoryApi~categoryCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link Array.<module:model/Category>}
     */
    this.category = function(key, domain, category, parents, callback) {
      var postBody = null;

      // verify the required parameter 'key' is set
      if (key === undefined || key === null) {
        throw new Error("Missing the required parameter 'key' when calling category");
      }

      // verify the required parameter 'domain' is set
      if (domain === undefined || domain === null) {
        throw new Error("Missing the required parameter 'domain' when calling category");
      }

      // verify the required parameter 'category' is set
      if (category === undefined || category === null) {
        throw new Error("Missing the required parameter 'category' when calling category");
      }

      // verify the required parameter 'parents' is set
      if (parents === undefined || parents === null) {
        throw new Error("Missing the required parameter 'parents' when calling category");
      }


      var pathParams = {
      };
      var queryParams = {
        'key': key,
        'domain': domain,
        'category': category,
        'parents': parents,
      };
      var collectionQueryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = [];
      var contentTypes = [];
      var accepts = ['application/json'];
      var returnType = [Category];

      return this.apiClient.callApi(
        '/category', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
