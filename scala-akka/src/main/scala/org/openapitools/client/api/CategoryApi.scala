/**
 * Keepa API
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */
package org.openapitools.client.api

import org.openapitools.client.model.Category
import org.openapitools.client.core._
import org.openapitools.client.core.CollectionFormats._
import org.openapitools.client.core.ApiKeyLocations._

object CategoryApi {

  /**
   * Retrieve category objects using their node ids and (optional) their parent tree.
   * 
   * Expected answers:
   *   code 200 : Seq[Category] (search results matching criteria)
   *   code 400 :  (bad input parameter)
   * 
   * @param key Your private API key.
   * @param domain Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
   * @param category The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.
   * @param parents Whether or not to include the category tree for each category. (1 = include, 0 = do not include.)
   */
  def category(key: String, domain: Int, category: Int, parents: Int): ApiRequest[Seq[Category]] =
    ApiRequest[Seq[Category]](ApiMethods.GET, "https://virtserver.swaggerhub.com/magicCashew/keepa/1.0.0", "/category", "application/json")
      .withQueryParam("key", key)
      .withQueryParam("domain", domain)
      .withQueryParam("category", category)
      .withQueryParam("parents", parents)
      .withSuccessResponse[Seq[Category]](200)
      .withErrorResponse[Unit](400)
      

}

