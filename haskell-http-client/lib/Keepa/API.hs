{-
   Keepa API

   The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.

   OpenAPI Version: 3.0.1
   Keepa API API version: 1.0.0
   Contact: info@keepa.com
   Generated by OpenAPI Generator (https://openapi-generator.tech)
-}

{-|
Module : Keepa.API
-}

module Keepa.API
  ( module Keepa.API.Category
  , module Keepa.API.Product
  ) where

import Keepa.API.Category
import Keepa.API.Product