/* 
 * Keepa API
 *
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 * Generated by: https://openapi-generator.tech
 */

use std::rc::Rc;
use std::borrow::Borrow;

use hyper;
use serde_json;
use futures::Future;

use super::{Error, configuration};
use super::request as __internal_request;

pub struct ProductApiClient<C: hyper::client::Connect> {
    configuration: Rc<configuration::Configuration<C>>,
}

impl<C: hyper::client::Connect> ProductApiClient<C> {
    pub fn new(configuration: Rc<configuration::Configuration<C>>) -> ProductApiClient<C> {
        ProductApiClient {
            configuration: configuration,
        }
    }
}

pub trait ProductApi {
    fn product(&self, key: &str, domain: i32, asin: &str, code: &str) -> Box<Future<Item = Vec<::models::Category>, Error = Error<serde_json::Value>>>;
}


impl<C: hyper::client::Connect>ProductApi for ProductApiClient<C> {
    fn product(&self, key: &str, domain: i32, asin: &str, code: &str) -> Box<Future<Item = Vec<::models::Category>, Error = Error<serde_json::Value>>> {
        __internal_request::Request::new(hyper::Method::Get, "/product".to_string())
            .with_query_param("key".to_string(), key.to_string())
            .with_query_param("domain".to_string(), domain.to_string())
            .with_query_param("asin".to_string(), asin.to_string())
            .with_query_param("code".to_string(), code.to_string())
            .execute(self.configuration.borrow())
    }

}
