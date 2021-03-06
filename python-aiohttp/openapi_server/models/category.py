# coding: utf-8

from datetime import date, datetime

from typing import List, Dict, Type

from openapi_server.models.base_model_ import Model
from openapi_server import util


class Category(Model):
    """NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).

    Do not edit the class manually.
    """

    def __init__(self, domain_id: int=None, cat_id: int=None, name: str=None, children: List[int]=None, parent: int=None, highest_rank: int=None, product_count: int=None):
        """Category - a model defined in OpenAPI

        :param domain_id: The domain_id of this Category.
        :param cat_id: The cat_id of this Category.
        :param name: The name of this Category.
        :param children: The children of this Category.
        :param parent: The parent of this Category.
        :param highest_rank: The highest_rank of this Category.
        :param product_count: The product_count of this Category.
        """
        self.openapi_types = {
            'domain_id': int,
            'cat_id': int,
            'name': str,
            'children': List[int],
            'parent': int,
            'highest_rank': int,
            'product_count': int
        }

        self.attribute_map = {
            'domain_id': 'domainId',
            'cat_id': 'catId',
            'name': 'name',
            'children': 'children',
            'parent': 'parent',
            'highest_rank': 'highestRank',
            'product_count': 'productCount'
        }

        self._domain_id = domain_id
        self._cat_id = cat_id
        self._name = name
        self._children = children
        self._parent = parent
        self._highest_rank = highest_rank
        self._product_count = product_count

    @classmethod
    def from_dict(cls, dikt: dict) -> 'Category':
        """Returns the dict as a model

        :param dikt: A dict.
        :return: The category of this Category.
        """
        return util.deserialize_model(dikt, cls)

    @property
    def domain_id(self):
        """Gets the domain_id of this Category.

        Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)

        :return: The domain_id of this Category.
        :rtype: int
        """
        return self._domain_id

    @domain_id.setter
    def domain_id(self, domain_id):
        """Sets the domain_id of this Category.

        Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)

        :param domain_id: The domain_id of this Category.
        :type domain_id: int
        """
        allowed_values = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13"]
        if domain_id not in allowed_values:
            raise ValueError(
                "Invalid value for `domain_id` ({0}), must be one of {1}"
                .format(domain_id, allowed_values)
            )

        self._domain_id = domain_id

    @property
    def cat_id(self):
        """Gets the cat_id of this Category.

        The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.

        :return: The cat_id of this Category.
        :rtype: int
        """
        return self._cat_id

    @cat_id.setter
    def cat_id(self, cat_id):
        """Sets the cat_id of this Category.

        The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.

        :param cat_id: The cat_id of this Category.
        :type cat_id: int
        """
        if cat_id is None:
            raise ValueError("Invalid value for `cat_id`, must not be `None`")

        self._cat_id = cat_id

    @property
    def name(self):
        """Gets the name of this Category.

        The name of the category.

        :return: The name of this Category.
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this Category.

        The name of the category.

        :param name: The name of this Category.
        :type name: str
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")

        self._name = name

    @property
    def children(self):
        """Gets the children of this Category.

        List of all sub categories. null or [] (empty array) if the category has no sub categories.

        :return: The children of this Category.
        :rtype: List[int]
        """
        return self._children

    @children.setter
    def children(self, children):
        """Sets the children of this Category.

        List of all sub categories. null or [] (empty array) if the category has no sub categories.

        :param children: The children of this Category.
        :type children: List[int]
        """
        if children is None:
            raise ValueError("Invalid value for `children`, must not be `None`")

        self._children = children

    @property
    def parent(self):
        """Gets the parent of this Category.

        The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.

        :return: The parent of this Category.
        :rtype: int
        """
        return self._parent

    @parent.setter
    def parent(self, parent):
        """Sets the parent of this Category.

        The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.

        :param parent: The parent of this Category.
        :type parent: int
        """
        if parent is None:
            raise ValueError("Invalid value for `parent`, must not be `None`")

        self._parent = parent

    @property
    def highest_rank(self):
        """Gets the highest_rank of this Category.

        The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.

        :return: The highest_rank of this Category.
        :rtype: int
        """
        return self._highest_rank

    @highest_rank.setter
    def highest_rank(self, highest_rank):
        """Sets the highest_rank of this Category.

        The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.

        :param highest_rank: The highest_rank of this Category.
        :type highest_rank: int
        """
        if highest_rank is None:
            raise ValueError("Invalid value for `highest_rank`, must not be `None`")

        self._highest_rank = highest_rank

    @property
    def product_count(self):
        """Gets the product_count of this Category.

        Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.

        :return: The product_count of this Category.
        :rtype: int
        """
        return self._product_count

    @product_count.setter
    def product_count(self, product_count):
        """Sets the product_count of this Category.

        Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.

        :param product_count: The product_count of this Category.
        :type product_count: int
        """
        if product_count is None:
            raise ValueError("Invalid value for `product_count`, must not be `None`")

        self._product_count = product_count
