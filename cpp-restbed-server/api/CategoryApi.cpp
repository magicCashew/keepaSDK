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


#include <corvusoft/restbed/byte.hpp>
#include <corvusoft/restbed/string.hpp>
#include <corvusoft/restbed/settings.hpp>
#include <corvusoft/restbed/request.hpp>

#include "CategoryApi.h"

namespace org {
namespace openapitools {
namespace server {
namespace api {

using namespace org::openapitools::server::model;

CategoryApi::CategoryApi() {
	std::shared_ptr<CategoryApiCategoryResource> spCategoryApiCategoryResource = std::make_shared<CategoryApiCategoryResource>();
	this->publish(spCategoryApiCategoryResource);
	
}

CategoryApi::~CategoryApi() {}

void CategoryApi::startService(int const& port) {
	std::shared_ptr<restbed::Settings> settings = std::make_shared<restbed::Settings>();
	settings->set_port(port);
	settings->set_root("/magicCashew/keepa/1.0.0");
	
	this->start(settings);
}

void CategoryApi::stopService() {
	this->stop();
}

CategoryApiCategoryResource::CategoryApiCategoryResource()
{
	this->set_path("/category/");
	this->set_method_handler("GET",
		std::bind(&CategoryApiCategoryResource::GET_method_handler, this,
			std::placeholders::_1));
}

CategoryApiCategoryResource::~CategoryApiCategoryResource()
{
}

void CategoryApiCategoryResource::GET_method_handler(const std::shared_ptr<restbed::Session> session) {

	const auto request = session->get_request();
			
			
			// Getting the query params
			const std::string key = request->get_query_parameter("key", "");
			const int32_t domain = request->get_query_parameter("domain", 0);
			const int32_t category = request->get_query_parameter("category", 0);
			const int32_t parents = request->get_query_parameter("parents", 0);

			
			// Change the value of this variable to the appropriate response before sending the response
			int status_code = 200;
			
			/**
			 * Process the received information here
			 */
			
			if (status_code == 200) {
				session->close(200, "search results matching criteria", { {"Connection", "close"} });
				return;
			}
			if (status_code == 400) {
				session->close(400, "bad input parameter", { {"Connection", "close"} });
				return;
			}

}




}
}
}
}

