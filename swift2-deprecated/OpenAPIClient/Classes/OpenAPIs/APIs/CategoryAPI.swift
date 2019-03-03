//
// CategoryAPI.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Alamofire



public class CategoryAPI: APIBase {
    /**
     * enum for parameter domain
     */
    public enum Domain_category: String { 
        case Number1 = "1"
        case Number2 = "2"
        case Number3 = "3"
        case Number4 = "4"
        case Number5 = "5"
        case Number6 = "6"
        case Number7 = "7"
        case Number8 = "8"
        case Number9 = "9"
        case Number10 = "10"
        case Number11 = "11"
        case Number12 = "12"
        case Number13 = "13"
    }

    /**
     * enum for parameter parents
     */
    public enum Parents_category: String { 
        case Number0 = "0"
        case Number1 = "1"
    }

    /**
     Returns Amazon category information from Keepa API.
     
     - parameter key: (query) Your private API key. 
     - parameter domain: (query) Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au) 
     - parameter category: (query) The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories. 
     - parameter parents: (query) Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.) 
     - parameter completion: completion handler to receive the data and the error objects
     */
    public class func category(key key: String, domain: Domain_category, category: Int32, parents: Parents_category, completion: ((data: [Category]?, error: ErrorType?) -> Void)) {
        categoryWithRequestBuilder(key: key, domain: domain, category: category, parents: parents).execute { (response, error) -> Void in
            completion(data: response?.body, error: error);
        }
    }


    /**
     Returns Amazon category information from Keepa API.
     - GET /category
     - Retrieve category objects using their node ids and (optional) their parent tree.     - examples: [{contentType=application/json, example={
  "catId" : 281052,
  "parent" : 502394,
  "children" : [ 3109924011, 7242008011, 3017941, 2476680011, 330405011, 2476681011, 3109925011 ],
  "highestRank" : 6549,
  "name" : "Digital Cameras",
  "productCount" : 1522,
  "domainId" : 1
}, statusCode=200}]
     - parameter key: (query) Your private API key. 
     - parameter domain: (query) Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au) 
     - parameter category: (query) The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories. 
     - parameter parents: (query) Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.) 

     - returns: RequestBuilder<[Category]> 
     */
    public class func categoryWithRequestBuilder(key key: String, domain: Domain_category, category: Int32, parents: Parents_category) -> RequestBuilder<[Category]> {
        let path = "/category"
        let URLString = OpenAPIClientAPI.basePath + path

        let nillableParameters: [String:AnyObject?] = [
            "key": key,
            "domain": domain.encodeToJSON().rawValue,
            "category": category.encodeToJSON(),
            "parents": parents.encodeToJSON().rawValue
        ]
 
        let parameters = APIHelper.rejectNil(nillableParameters)
 
        let convertedParameters = APIHelper.convertBoolToString(parameters)
 
        let requestBuilder: RequestBuilder<[Category]>.Type = OpenAPIClientAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: URLString, parameters: convertedParameters, isBody: false)
    }

}
