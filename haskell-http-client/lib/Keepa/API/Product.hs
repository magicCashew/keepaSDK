{-
   Keepa API

   The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.

   OpenAPI Version: 3.0.1
   Keepa API API version: 1.0.0
   Contact: info@keepa.com
   Generated by OpenAPI Generator (https://openapi-generator.tech)
-}

{-|
Module : Keepa.API.Product
-}

{-# LANGUAGE FlexibleContexts #-}
{-# LANGUAGE FlexibleInstances #-}
{-# LANGUAGE MonoLocalBinds #-}
{-# LANGUAGE MultiParamTypeClasses #-}
{-# LANGUAGE OverloadedStrings #-}
{-# OPTIONS_GHC -fno-warn-name-shadowing -fno-warn-unused-binds -fno-warn-unused-imports #-}

module Keepa.API.Product where

import Keepa.Core
import Keepa.MimeTypes
import Keepa.Model as M

import qualified Data.Aeson as A
import qualified Data.ByteString as B
import qualified Data.ByteString.Lazy as BL
import qualified Data.Data as P (Typeable, TypeRep, typeOf, typeRep)
import qualified Data.Foldable as P
import qualified Data.Map as Map
import qualified Data.Maybe as P
import qualified Data.Proxy as P (Proxy(..))
import qualified Data.Set as Set
import qualified Data.String as P
import qualified Data.Text as T
import qualified Data.Text.Encoding as T
import qualified Data.Text.Lazy as TL
import qualified Data.Text.Lazy.Encoding as TL
import qualified Data.Time as TI
import qualified Network.HTTP.Client.MultipartFormData as NH
import qualified Network.HTTP.Media as ME
import qualified Network.HTTP.Types as NH
import qualified Web.FormUrlEncoded as WH
import qualified Web.HttpApiData as WH

import Data.Text (Text)
import GHC.Base ((<|>))

import Prelude ((==),(/=),($), (.),(<$>),(<*>),(>>=),Maybe(..),Bool(..),Char,Double,FilePath,Float,Int,Integer,String,fmap,undefined,mempty,maybe,pure,Monad,Applicative,Functor)
import qualified Prelude as P

-- * Operations


-- ** Product

-- *** product

-- | @GET \/product@
-- 
-- Retrieve the product for the specified ASIN and domain.
-- 
-- Retrieves the product object for the specified ASIN and domain. If our last update is older than one hour it will be automatically refreshed before delivered to you to ensure you get near to real-time pricing data.  You can request products via either their ASIN (preferred) or via UPC and EAN codes. You can not use both parameters, asin and code, in the same request. Keepa can not track Amazon Fresh and eBooks.
-- 
product 
  :: Key -- ^ "key" -  Your private API key.
  -> Domain -- ^ "domain" -  Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
  -> KeepaRequest Product MimeNoContent [Category] MimeJSON
product (Key key) (Domain domain) =
  _mkRequest "GET" ["/product"]
    `setQuery` toQuery ("key", Just key)
    `setQuery` toQuery ("domain", Just domain)

data Product  

-- | /Optional Param/ "asin" - The ASIN of the product you want to request. For batch requests a comma separated list of ASINs (up to one hundred).
instance HasOptionalParam Product Asin where
  applyOptionalParam req (Asin xs) =
    req `setQuery` toQuery ("asin", Just xs)

-- | /Optional Param/ "code" - The product code of the product you want to request. We currently allow UPC, EAN and ISBN-13 codes. For batch requests a comma separated list of codes (up to one hundred). Multiple ASINs can have the same product code, so requesting a product code can return multiple products.
instance HasOptionalParam Product Code where
  applyOptionalParam req (Code xs) =
    req `setQuery` toQuery ("code", Just xs)

-- | @application/json@
instance Produces Product MimeJSON

