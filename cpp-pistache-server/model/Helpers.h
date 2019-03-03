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
/*
 * Helpers.h
 *
 * This is the helper class for models and primitives
 */

#ifndef Helpers_H_
#define Helpers_H_

#include <ctime>
#include <string>
#include <sstream>
#include <vector>
#include <map>

namespace org {
namespace openapitools {
namespace server {
namespace helpers {

    std::string toStringValue(const std::string &value);
    std::string toStringValue(const int32_t &value);
    std::string toStringValue(const int64_t &value);
    std::string toStringValue(const bool &value);
    std::string toStringValue(const float &value);
    std::string toStringValue(const double &value);

    bool fromStringValue(const std::string &inStr, std::string &value);
    bool fromStringValue(const std::string &inStr, int32_t &value);
    bool fromStringValue(const std::string &inStr, int64_t &value);
    bool fromStringValue(const std::string &inStr, bool &value);
    bool fromStringValue(const std::string &inStr, float &value);
    bool fromStringValue(const std::string &inStr, double &value);
    template<typename T>
    bool fromStringValue(const std::vector<std::string> &inStr, std::vector<T> &value){
        try{
            for(auto & item : inStr){
                T itemValue;
                if(fromStringValue(item, itemValue)){
                    value.push_back(itemValue);
                }
            }
        }
        catch(...){
            return false;
        }
        return value.size() > 0;
    }
    template<typename T>
    bool fromStringValue(const std::string &inStr, std::vector<T> &value, char separator = ','){
        std::vector<std::string> inStrings;
        std::istringstream f(inStr);
        std::string s;
        while (std::getline(f, s, separator)) {
            inStrings.push_back(s);
        }
        return fromStringValue(inStrings, value);
    }

}
}
}
}

#endif // Helpers_H_