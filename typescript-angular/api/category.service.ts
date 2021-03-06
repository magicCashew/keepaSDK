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
/* tslint:disable:no-unused-variable member-ordering */

import { Inject, Injectable, Optional }                      from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams,
         HttpResponse, HttpEvent }                           from '@angular/common/http';
import { CustomHttpUrlEncodingCodec }                        from '../encoder';

import { Observable }                                        from 'rxjs/Observable';

import { Category } from '../model/category';

import { BASE_PATH, COLLECTION_FORMATS }                     from '../variables';
import { Configuration }                                     from '../configuration';


@Injectable()
export class CategoryService {

    protected basePath = 'https://virtserver.swaggerhub.com/magicCashew/keepa/1.0.0';
    public defaultHeaders = new HttpHeaders();
    public configuration = new Configuration();

    constructor(protected httpClient: HttpClient, @Optional()@Inject(BASE_PATH) basePath: string, @Optional() configuration: Configuration) {

        if (configuration) {
            this.configuration = configuration;
            this.configuration.basePath = configuration.basePath || basePath || this.basePath;

        } else {
            this.configuration.basePath = basePath || this.basePath;
        }
    }

    /**
     * @param consumes string[] mime-types
     * @return true: consumes contains 'multipart/form-data', false: otherwise
     */
    private canConsumeForm(consumes: string[]): boolean {
        const form = 'multipart/form-data';
        for (const consume of consumes) {
            if (form === consume) {
                return true;
            }
        }
        return false;
    }


    /**
     * Returns Amazon category information from Keepa API.
     * Retrieve category objects using their node ids and (optional) their parent tree.
     * @param key Your private API key.
     * @param domain Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
     * @param category The category node id of the category you want to request. For batch requests a comma separated list of ids (up to 10, the token cost stays the same). Alternatively you can specify the value 0, which will retrieve a list of all root categories.
     * @param parents Whether or not to include the category tree for each category. (1 &#x3D; include, 0 &#x3D; do not include.)
     * @param observe set whether or not to return the data Observable as the body, response or events. defaults to returning the body.
     * @param reportProgress flag to report request and response progress.
     */
    public category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, observe?: 'body', reportProgress?: boolean): Observable<Array<Category>>;
    public category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, observe?: 'response', reportProgress?: boolean): Observable<HttpResponse<Array<Category>>>;
    public category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, observe?: 'events', reportProgress?: boolean): Observable<HttpEvent<Array<Category>>>;
    public category(key: string, domain: 1 | 2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 | 13, category: number, parents: 0 | 1, observe: any = 'body', reportProgress: boolean = false ): Observable<any> {
        if (key === null || key === undefined) {
            throw new Error('Required parameter key was null or undefined when calling category.');
        }
        if (domain === null || domain === undefined) {
            throw new Error('Required parameter domain was null or undefined when calling category.');
        }
        if (category === null || category === undefined) {
            throw new Error('Required parameter category was null or undefined when calling category.');
        }
        if (parents === null || parents === undefined) {
            throw new Error('Required parameter parents was null or undefined when calling category.');
        }

        let queryParameters = new HttpParams({encoder: new CustomHttpUrlEncodingCodec()});
        if (key !== undefined && key !== null) {
            queryParameters = queryParameters.set('key', <any>key);
        }
        if (domain !== undefined && domain !== null) {
            queryParameters = queryParameters.set('domain', <any>domain);
        }
        if (category !== undefined && category !== null) {
            queryParameters = queryParameters.set('category', <any>category);
        }
        if (parents !== undefined && parents !== null) {
            queryParameters = queryParameters.set('parents', <any>parents);
        }

        let headers = this.defaultHeaders;

        // to determine the Accept header
        const httpHeaderAccepts: string[] = [
            'application/json'
        ];
        const httpHeaderAcceptSelected: string | undefined = this.configuration.selectHeaderAccept(httpHeaderAccepts);
        if (httpHeaderAcceptSelected !== undefined) {
            headers = headers.set('Accept', httpHeaderAcceptSelected);
        }

        // to determine the Content-Type header
        const consumes: string[] = [
        ];

        return this.httpClient.get<Array<Category>>(`${this.configuration.basePath}/category`,
            {
                params: queryParameters,
                withCredentials: this.configuration.withCredentials,
                headers: headers,
                observe: observe,
                reportProgress: reportProgress
            }
        );
    }

}
