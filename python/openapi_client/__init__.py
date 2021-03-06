# coding: utf-8

# flake8: noqa

"""
    Keepa API

    The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.  # noqa: E501

    OpenAPI spec version: 1.0.0
    Contact: info@keepa.com
    Generated by: https://openapi-generator.tech
"""


from __future__ import absolute_import

__version__ = "1.0.0"

# import apis into sdk package
from openapi_client.api.category_api import CategoryApi
from openapi_client.api.product_api import ProductApi

# import ApiClient
from openapi_client.api_client import ApiClient
from openapi_client.configuration import Configuration
# import models into sdk package
from openapi_client.models.category import Category
