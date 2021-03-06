# PRODUCT_API

All URIs are relative to *https://virtserver.swaggerhub.com/magicCashew/keepa/1.0.0*

Feature | HTTP request | Description
------------- | ------------- | -------------
[**product**](PRODUCT_API.md#product) | **Get** /product | Retrieve the product for the specified ASIN and domain.


# **product**
> product (key: STRING_32 ; domain: INTEGER_32 ; asin:  detachable STRING_32 ; code:  detachable STRING_32 ): detachable LIST [CATEGORY]
	

Retrieve the product for the specified ASIN and domain.

Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.


### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **STRING_32**| Your private API key. | [default to null]
 **domain** | **INTEGER_32**| Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au) | [default to null]
 **asin** | **STRING_32**| The ASIN of the product you want to request. For batch requests a comma separated list of ASINs (up to one hundred). | [optional] [default to null]
 **code** | **STRING_32**| The product code of the product you want to request. We currently allow UPC, EAN and ISBN-13 codes. For batch requests a comma separated list of codes (up to one hundred). Multiple ASINs can have the same product code, so requesting a product code can return multiple products. | [optional] [default to null]

### Return type

[**LIST [CATEGORY]**](category.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

