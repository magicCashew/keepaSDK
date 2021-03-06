// @flow
/* eslint-disable no-use-before-define */
/**
 * Keepa API
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


import * as url from "url";
import * as portableFetch from "portable-fetch";
import { Configuration } from "./configuration";

const BASE_PATH: string = "https://virtserver.swaggerhub.com/magicCashew/keepa/1.0.0".replace(/\/+$/, "");

/**
 *
 * @export
 */
export const COLLECTION_FORMATS = {
    csv: ",",
    ssv: " ",
    tsv: "\t",
    pipes: "|",
};

/**
 *
 * @export
 */
export type FetchAPI = {
    (url: string, init?: any): Promise<Response>;
}

/**
 *
 * @export
 */
export type FetchArgs = {
    url: string;
    options: {};
}


/**
 *
 * @export
 */
export type RequestOptions = {
    headers?: {};
    query?: {};
    body?: string | FormData;
}

/**
 * * @export
 * @class RequiredError
 * @extends {Error}
 */
export class RequiredError extends Error {
    name:string = "RequiredError"
    constructor(field: string, msg?: string) {
        super(msg);
    }
}


            export type CategoryDomainIdEnum = 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13;
/**
 * 
 * @export
 */
export type Category = {
    /**
     * Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
     * @type {number}
     * @memberof Category
     */
    domainId: CategoryDomainIdEnum;
    /**
     * The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.
     * @type {number}
     * @memberof Category
     */
    catId: number;
    /**
     * The name of the category.
     * @type {string}
     * @memberof Category
     */
    name: string;
    /**
     * List of all sub categories. null or [] (empty array) if the category has no sub categories.
     * @type {Array<number>}
     * @memberof Category
     */
    children: Array<number>;
    /**
     * The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.
     * @type {number}
     * @memberof Category
     */
    parent: number;
    /**
     * The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
     * @type {number}
     * @memberof Category
     */
    highestRank: number;
    /**
     * Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
     * @type {number}
     * @memberof Category
     */
    productCount: number;
}




/**
 * CategoryApi - fetch parameter creator
 * @export
 */
export const CategoryApiFetchParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * Retrieve category objects using their node ids and (optional) their parent tree.
         * @summary Returns Amazon category information from Keepa API.
         * @throws {RequiredError}
         */
        category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, options: RequestOptions): FetchArgs {
            // verify required parameter 'key' is not null or undefined
            if (key === null || key === undefined) {
                throw new RequiredError('key','Required parameter key was null or undefined when calling category.');
            }
            // verify required parameter 'domain' is not null or undefined
            if (domain === null || domain === undefined) {
                throw new RequiredError('domain','Required parameter domain was null or undefined when calling category.');
            }
            // verify required parameter 'category' is not null or undefined
            if (category === null || category === undefined) {
                throw new RequiredError('category','Required parameter category was null or undefined when calling category.');
            }
            // verify required parameter 'parents' is not null or undefined
            if (parents === null || parents === undefined) {
                throw new RequiredError('parents','Required parameter parents was null or undefined when calling category.');
            }
            const localVarPath = `/category`;
            const localVarUrlObj = url.parse(localVarPath, true);
            const localVarRequestOptions: RequestOptions = Object.assign({}, { method: 'GET' }, options);
            const localVarHeaderParameter = {};
            const localVarQueryParameter = {};

            if (key !== undefined) {
                localVarQueryParameter['key'] = ((key:any):string);
            }

            if (domain !== undefined) {
                localVarQueryParameter['domain'] = ((domain:any):string);
            }

            if (category !== undefined) {
                localVarQueryParameter['category'] = ((category:any):string);
            }

            if (parents !== undefined) {
                localVarQueryParameter['parents'] = ((parents:any):string);
            }

            localVarUrlObj.query = Object.assign({}, localVarUrlObj.query, localVarQueryParameter, options.query);
            // fix override query string Detail: https://stackoverflow.com/a/7517673/1077943
            delete localVarUrlObj.search;
            localVarRequestOptions.headers = Object.assign({}, localVarHeaderParameter, options.headers);

            return {
                url: url.format(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

export type CategoryApiType = { 
    category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, options?: RequestOptions): Promise<Array<Category>>,
}

/**
 * CategoryApi - factory function to inject configuration 
 * @export
 */
export const CategoryApi = function(configuration?: Configuration, fetch: FetchAPI = portableFetch): CategoryApiType {
    const basePath: string = (configuration && configuration.basePath) || BASE_PATH;
    return {
        /**
         * Retrieve category objects using their node ids and (optional) their parent tree.
         * @summary Returns Amazon category information from Keepa API.
         * @throws {RequiredError}
         */
        category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, options?: RequestOptions = {}): Promise<Array<Category>> {
            const localVarFetchArgs = CategoryApiFetchParamCreator(configuration).category(key, domain, category, parents, options);
            return fetch(basePath + localVarFetchArgs.url, localVarFetchArgs.options).then((response) => {
                if (response.status >= 200 && response.status < 300) {
                    return response.json();
                } else {
                    throw response;
                }
            });
        },
    }
};

/**
 * ProductApi - fetch parameter creator
 * @export
 */
export const ProductApiFetchParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.
         * @summary Retrieve the product for the specified ASIN and domain.
         * @throws {RequiredError}
         */
        product(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, asin?: string, code?: string, options: RequestOptions): FetchArgs {
            // verify required parameter 'key' is not null or undefined
            if (key === null || key === undefined) {
                throw new RequiredError('key','Required parameter key was null or undefined when calling product.');
            }
            // verify required parameter 'domain' is not null or undefined
            if (domain === null || domain === undefined) {
                throw new RequiredError('domain','Required parameter domain was null or undefined when calling product.');
            }
            const localVarPath = `/product`;
            const localVarUrlObj = url.parse(localVarPath, true);
            const localVarRequestOptions: RequestOptions = Object.assign({}, { method: 'GET' }, options);
            const localVarHeaderParameter = {};
            const localVarQueryParameter = {};

            if (key !== undefined) {
                localVarQueryParameter['key'] = ((key:any):string);
            }

            if (domain !== undefined) {
                localVarQueryParameter['domain'] = ((domain:any):string);
            }

            if (asin !== undefined) {
                localVarQueryParameter['asin'] = ((asin:any):string);
            }

            if (code !== undefined) {
                localVarQueryParameter['code'] = ((code:any):string);
            }

            localVarUrlObj.query = Object.assign({}, localVarUrlObj.query, localVarQueryParameter, options.query);
            // fix override query string Detail: https://stackoverflow.com/a/7517673/1077943
            delete localVarUrlObj.search;
            localVarRequestOptions.headers = Object.assign({}, localVarHeaderParameter, options.headers);

            return {
                url: url.format(localVarUrlObj),
                options: localVarRequestOptions,
            };
        },
    }
};

export type ProductApiType = { 
    product(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, asin?: string, code?: string, options?: RequestOptions): Promise<Array<Category>>,
}

/**
 * ProductApi - factory function to inject configuration 
 * @export
 */
export const ProductApi = function(configuration?: Configuration, fetch: FetchAPI = portableFetch): ProductApiType {
    const basePath: string = (configuration && configuration.basePath) || BASE_PATH;
    return {
        /**
         * Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.
         * @summary Retrieve the product for the specified ASIN and domain.
         * @throws {RequiredError}
         */
        product(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, asin?: string, code?: string, options?: RequestOptions = {}): Promise<Array<Category>> {
            const localVarFetchArgs = ProductApiFetchParamCreator(configuration).product(key, domain, asin, code, options);
            return fetch(basePath + localVarFetchArgs.url, localVarFetchArgs.options).then((response) => {
                if (response.status >= 200 && response.status < 300) {
                    return response.json();
                } else {
                    throw response;
                }
            });
        },
    }
};

export type ApiTypes = { 
    CategoryApi: CategoryApiType,

    ProductApi: ProductApiType,
 }
