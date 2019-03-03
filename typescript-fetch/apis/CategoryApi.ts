// tslint:disable
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


import * as runtime from '../runtime';
import {
    Category,
    CategoryFromJSON,
    CategoryToJSON,
} from '../models';

export interface CategoryRequest {
    key: string;
    domain: CategoryDomainEnum;
    category: number;
    parents: CategoryParentsEnum;
}

/**
 * no description
 */
export class CategoryApi extends runtime.BaseAPI {

    /**
     * Retrieve category objects using their node ids and (optional) their parent tree.
     * Returns Amazon category information from Keepa API.
     */
    async categoryRaw(requestParameters: CategoryRequest): Promise<runtime.ApiResponse<Array<Category>>> {
        if (requestParameters.key === null || requestParameters.key === undefined) {
            throw new runtime.RequiredError('key','Required parameter requestParameters.key was null or undefined when calling category.');
        }

        if (requestParameters.domain === null || requestParameters.domain === undefined) {
            throw new runtime.RequiredError('domain','Required parameter requestParameters.domain was null or undefined when calling category.');
        }

        if (requestParameters.category === null || requestParameters.category === undefined) {
            throw new runtime.RequiredError('category','Required parameter requestParameters.category was null or undefined when calling category.');
        }

        if (requestParameters.parents === null || requestParameters.parents === undefined) {
            throw new runtime.RequiredError('parents','Required parameter requestParameters.parents was null or undefined when calling category.');
        }

        const queryParameters: runtime.HTTPQuery = {};

        if (requestParameters.key !== undefined) {
            queryParameters['key'] = requestParameters.key;
        }

        if (requestParameters.domain !== undefined) {
            queryParameters['domain'] = requestParameters.domain;
        }

        if (requestParameters.category !== undefined) {
            queryParameters['category'] = requestParameters.category;
        }

        if (requestParameters.parents !== undefined) {
            queryParameters['parents'] = requestParameters.parents;
        }

        const headerParameters: runtime.HTTPHeaders = {};

        const response = await this.request({
            path: `/category`,
            method: 'GET',
            headers: headerParameters,
            query: queryParameters,
        });

        return new runtime.JSONApiResponse(response, (jsonValue) => jsonValue.map(CategoryFromJSON));
    }

    /**
     * Retrieve category objects using their node ids and (optional) their parent tree.
     * Returns Amazon category information from Keepa API.
     */
    async category(requestParameters: CategoryRequest): Promise<Array<Category>> {
        const response = await this.categoryRaw(requestParameters);
        return await response.value();
    }

}

/**
    * @export
    * @enum {string}
    */
export enum CategoryDomainEnum {
    NUMBER_1 = 1,
    NUMBER_2 = 2,
    NUMBER_3 = 3,
    NUMBER_4 = 4,
    NUMBER_5 = 5,
    NUMBER_6 = 6,
    NUMBER_7 = 7,
    NUMBER_8 = 8,
    NUMBER_9 = 9,
    NUMBER_10 = 10,
    NUMBER_11 = 11,
    NUMBER_12 = 12,
    NUMBER_13 = 13
}
/**
    * @export
    * @enum {string}
    */
export enum CategoryParentsEnum {
    NUMBER_0 = 0,
    NUMBER_1 = 1
}