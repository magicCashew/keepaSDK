{-
   Keepa API

   The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.

   OpenAPI Version: 3.0.1
   Keepa API API version: 1.0.0
   Contact: info@keepa.com
   Generated by OpenAPI Generator (https://openapi-generator.tech)
-}

{-|
Module : Keepa.Lens
-}

{-# LANGUAGE KindSignatures #-}
{-# LANGUAGE NamedFieldPuns #-}
{-# LANGUAGE RankNTypes #-}
{-# LANGUAGE RecordWildCards #-}
{-# OPTIONS_GHC -fno-warn-name-shadowing -fno-warn-unused-matches -fno-warn-unused-binds -fno-warn-unused-imports #-}

module Keepa.ModelLens where

import qualified Data.Aeson as A
import qualified Data.ByteString.Lazy as BL
import qualified Data.Data as P (Data, Typeable)
import qualified Data.Map as Map
import qualified Data.Set as Set
import qualified Data.Time as TI

import Data.Text (Text)

import Prelude (($), (.),(<$>),(<*>),(=<<),Maybe(..),Bool(..),Char,Double,FilePath,Float,Int,Integer,String,fmap,undefined,mempty,maybe,pure,Monad,Applicative,Functor)
import qualified Prelude as P

import Keepa.Model
import Keepa.Core


-- * Category

-- | 'categoryDomainId' Lens
categoryDomainIdL :: Lens_' Category (E'DomainId)
categoryDomainIdL f Category{..} = (\categoryDomainId -> Category { categoryDomainId, ..} ) <$> f categoryDomainId
{-# INLINE categoryDomainIdL #-}

-- | 'categoryCatId' Lens
categoryCatIdL :: Lens_' Category (Int)
categoryCatIdL f Category{..} = (\categoryCatId -> Category { categoryCatId, ..} ) <$> f categoryCatId
{-# INLINE categoryCatIdL #-}

-- | 'categoryName' Lens
categoryNameL :: Lens_' Category (Text)
categoryNameL f Category{..} = (\categoryName -> Category { categoryName, ..} ) <$> f categoryName
{-# INLINE categoryNameL #-}

-- | 'categoryChildren' Lens
categoryChildrenL :: Lens_' Category ([Int])
categoryChildrenL f Category{..} = (\categoryChildren -> Category { categoryChildren, ..} ) <$> f categoryChildren
{-# INLINE categoryChildrenL #-}

-- | 'categoryParent' Lens
categoryParentL :: Lens_' Category (Int)
categoryParentL f Category{..} = (\categoryParent -> Category { categoryParent, ..} ) <$> f categoryParent
{-# INLINE categoryParentL #-}

-- | 'categoryHighestRank' Lens
categoryHighestRankL :: Lens_' Category (Int)
categoryHighestRankL f Category{..} = (\categoryHighestRank -> Category { categoryHighestRank, ..} ) <$> f categoryHighestRank
{-# INLINE categoryHighestRankL #-}

-- | 'categoryProductCount' Lens
categoryProductCountL :: Lens_' Category (Int)
categoryProductCountL f Category{..} = (\categoryProductCount -> Category { categoryProductCount, ..} ) <$> f categoryProductCount
{-# INLINE categoryProductCountL #-}


