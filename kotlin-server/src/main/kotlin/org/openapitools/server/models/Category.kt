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
package org.openapitools.server.models


/**
 * 
 * @param domainId Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
 * @param catId The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.
 * @param name The name of the category.
 * @param children List of all sub categories. null or [] (empty array) if the category has no sub categories.
 * @param parent The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.
 * @param highestRank The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
 * @param productCount Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
 */
data class Category (
    /* Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au) */
    val domainId: Category.DomainId,
    /* The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories. */
    val catId: kotlin.Int,
    /* The name of the category. */
    val name: kotlin.String,
    /* List of all sub categories. null or [] (empty array) if the category has no sub categories. */
    val children: kotlin.Array<kotlin.Int>,
    /* The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category. */
    val parent: kotlin.Int,
    /* The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon. */
    val highestRank: kotlin.Int,
    /* Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon. */
    val productCount: kotlin.Int
) {

    /**
    * Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
    * Values: _1,_2,_3,_4,_5,_6,_7,_8,_9,_10,_11,_12,_13
    */
    enum class DomainId(val value: kotlin.Int){
    
        _1(1),
    
        _2(2),
    
        _3(3),
    
        _4(4),
    
        _5(5),
    
        _6(6),
    
        _7(7),
    
        _8(8),
    
        _9(9),
    
        _10(10),
    
        _11(11),
    
        _12(12),
    
        _13(13);
    
    }

}

