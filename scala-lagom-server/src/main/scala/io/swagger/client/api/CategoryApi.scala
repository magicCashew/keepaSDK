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

package io.swagger.client.api

import akka.{Done, NotUsed}
import com.lightbend.lagom.scaladsl.api.transport.Method
import com.lightbend.lagom.scaladsl.api.{Service, ServiceCall}
import play.api.libs.json._
import com.lightbend.lagom.scaladsl.api.deser.PathParamSerializer

import io.swagger.client.model.Category

trait CategoryApi extends Service {


  final override def descriptor = {
    import Service._
    named("CategoryApi").withCalls(
      restCall(Method.GET, "/category?key&domain&category&parents", category _)
    ).withAutoAcl(true)
  }

      
  /**
    * Returns Amazon category information from Keepa API.
    * Retrieve category objects using their node ids and (optional) their parent tree.
    *  
    * @param key Your private API key.  
    * @param domain Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)  
    * @param category The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.  
    * @param parents Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.) 
    * @return Seq[Category]
    */
  def category(key:String          ,domain: Option[CategoryApiDomainEnum.CategoryApiDomainEnum]category:Int          ,parents: Option[CategoryApiParentsEnum.CategoryApiParentsEnum]): ServiceCall[NotUsed ,Seq[Category]]
  

        object CategoryApiDomainEnum extends Enumeration {
        val   1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 = Value     
        type CategoryApiDomainEnum = Value
        implicit val format: Format[Value] = Format(Reads.enumNameReads(this), Writes.enumNameWrites[CategoryApiDomainEnum.type])
        implicit val pathParamSerializer: PathParamSerializer[CategoryApiDomainEnum] = PathParamSerializer.required("CategoryApiDomainEnum")(withName)(_.toString)
        }
        object CategoryApiParentsEnum extends Enumeration {
        val   0, 1 = Value     
        type CategoryApiParentsEnum = Value
        implicit val format: Format[Value] = Format(Reads.enumNameReads(this), Writes.enumNameWrites[CategoryApiParentsEnum.type])
        implicit val pathParamSerializer: PathParamSerializer[CategoryApiParentsEnum] = PathParamSerializer.required("CategoryApiParentsEnum")(withName)(_.toString)
        }
  }

