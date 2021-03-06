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



#include "Category.h"

#include <string>
#include <sstream>
#include <boost/property_tree/ptree.hpp>
#include <boost/property_tree/json_parser.hpp>

using boost::property_tree::ptree;
using boost::property_tree::read_json;
using boost::property_tree::write_json;

namespace org {
namespace openapitools {
namespace server {
namespace model {

Category::Category()
{
    m_DomainId = 0;
    m_CatId = 0;
    m_Name = "";
    m_Parent = 0;
    m_HighestRank = 0;
    m_ProductCount = 0;
    
}

Category::~Category()
{
}

std::string Category::toJsonString()
{
	std::stringstream ss;
	ptree pt;
	pt.put("DomainId", m_DomainId);
	pt.put("CatId", m_CatId);
	pt.put("Name", m_Name);
	pt.put("Parent", m_Parent);
	pt.put("HighestRank", m_HighestRank);
	pt.put("ProductCount", m_ProductCount);
	write_json(ss, pt, false);
	return ss.str();
}

void Category::fromJsonString(std::string const& jsonString)
{
	std::stringstream ss(jsonString);
	ptree pt;
	read_json(ss,pt);
	m_DomainId = pt.get("DomainId", 0);
	m_CatId = pt.get("CatId", 0);
	m_Name = pt.get("Name", "");
	m_Parent = pt.get("Parent", 0);
	m_HighestRank = pt.get("HighestRank", 0);
	m_ProductCount = pt.get("ProductCount", 0);
}

int32_t Category::getDomainId() const
{
    return m_DomainId;
}
void Category::setDomainId(int32_t value)
{
    m_DomainId = value;
}
int32_t Category::getCatId() const
{
    return m_CatId;
}
void Category::setCatId(int32_t value)
{
    m_CatId = value;
}
std::string Category::getName() const
{
    return m_Name;
}
void Category::setName(std::string value)
{
    m_Name = value;
}
std::vector<int32_t> Category::getChildren() const
{
    return m_Children;
}
void Category::setChildren(std::vector<int32_t> value)
{
    m_Children = value;
}
int32_t Category::getParent() const
{
    return m_Parent;
}
void Category::setParent(int32_t value)
{
    m_Parent = value;
}
int32_t Category::getHighestRank() const
{
    return m_HighestRank;
}
void Category::setHighestRank(int32_t value)
{
    m_HighestRank = value;
}
int32_t Category::getProductCount() const
{
    return m_ProductCount;
}
void Category::setProductCount(int32_t value)
{
    m_ProductCount = value;
}

}
}
}
}

