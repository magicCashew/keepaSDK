/**
 * Keepa API
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 4.0.0-beta2.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * ProductApi.h
 *
 * 
 */

#ifndef ORG_OPENAPITOOLS_CLIENT_API_ProductApi_H_
#define ORG_OPENAPITOOLS_CLIENT_API_ProductApi_H_


#include "../ApiClient.h"

#include "Category.h"
#include <cpprest/details/basic_types.h>


#include <boost/optional.hpp>

namespace org {
namespace openapitools {
namespace client {
namespace api {

using namespace org::openapitools::client::model;



class  ProductApi 
{
public:

    explicit ProductApi( std::shared_ptr<ApiClient> apiClient );

    virtual ~ProductApi();

    /// <summary>
    /// Retrieve the product for the specified ASIN and domain.
    /// </summary>
    /// <remarks>
    /// Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.
    /// </remarks>
    /// <param name="key">Your private API key.</param>
    /// <param name="domain">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</param>
    /// <param name="asin">The ASIN of the product you want to request. For batch requests a comma separated list of ASINs (up to one hundred). (optional, default to utility::conversions::to_string_t(&quot;&quot;))</param>
    /// <param name="code">The product code of the product you want to request. We currently allow UPC, EAN and ISBN-13 codes. For batch requests a comma separated list of codes (up to one hundred). Multiple ASINs can have the same product code, so requesting a product code can return multiple products. (optional, default to utility::conversions::to_string_t(&quot;&quot;))</param>
    pplx::task<std::vector<std::shared_ptr<Category>>> product(
        utility::string_t key,
        int32_t domain,
        boost::optional<utility::string_t> asin,
        boost::optional<utility::string_t> code
    );

protected:
    std::shared_ptr<ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* ORG_OPENAPITOOLS_CLIENT_API_ProductApi_H_ */

