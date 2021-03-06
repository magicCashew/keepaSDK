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
    root.KeepaApi.ProductApi = factory(root.KeepaApi.ApiClient, root.KeepaApi.Category);
  }
}(this, function(ApiClient, Category) {
  'use strict';

  /**
   * Product service.
   * @module api/ProductApi
   * @version 1.0.0
   */

  /**
   * Constructs a new ProductApi. 
   * @alias module:api/ProductApi
   * @class
   * @param {module:ApiClient} [apiClient] Optional API client implementation to use,
   * default to {@link module:ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the product operation.
     * @callback module:api/ProductApi~productCallback
     * @param {String} error Error message, if any.
     * @param {Array.<module:model/Category>} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Retrieve the product for the specified ASIN and domain.
     * Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.
     * @param {String} key Your private API key.
     * @param {module:model/Number} domain Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
     * @param {Object} opts Optional parameters
     * @param {String} opts.asin The ASIN of the product you want to request. For batch requests a comma separated list of ASINs (up to one hundred).
     * @param {String} opts.code The product code of the product you want to request. We currently allow UPC, EAN and ISBN-13 codes. For batch requests a comma separated list of codes (up to one hundred). Multiple ASINs can have the same product code, so requesting a product code can return multiple products.
     * @param {module:api/ProductApi~productCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link Array.<module:model/Category>}
     */
    this.product = function(key, domain, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'key' is set
      if (key === undefined || key === null) {
        throw new Error("Missing the required parameter 'key' when calling product");
      }

      // verify the required parameter 'domain' is set
      if (domain === undefined || domain === null) {
        throw new Error("Missing the required parameter 'domain' when calling product");
      }


      var pathParams = {
      };
      var queryParams = {
        'key': key,
        'domain': domain,
        'asin': opts['asin'],
        'code': opts['code'],
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
        '/product', 'GET',
        pathParams, queryParams, collectionQueryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
