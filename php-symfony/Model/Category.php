<?php
/**
 * Category
 *
 * PHP version 5
 *
 * @category Class
 * @package  OpenAPI\Server\Model
 * @author   OpenAPI Generator team
 * @link     https://github.com/openapitools/openapi-generator
 */

/**
 * Keepa API
 *
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 *
 */

/**
 * NOTE: This class is auto generated by the openapi generator program.
 * https://github.com/openapitools/openapi-generator
 * Do not edit the class manually.
 */

namespace OpenAPI\Server\Model;

use Symfony\Component\Validator\Constraints as Assert;
use JMS\Serializer\Annotation\Type;
use JMS\Serializer\Annotation\SerializedName;

/**
 * Class representing the Category model.
 *
 * @package OpenAPI\Server\Model
 * @author  OpenAPI Generator team
 */
class Category 
{
        /**
     * Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
     *
     * @var int
     * @SerializedName("domainId")
     * @Assert\NotNull()
     * @Assert\Choice({ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 })
     * @Assert\Type("int")
     * @Type("int")
     */
    protected $domainId;

    /**
     * The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.
     *
     * @var int
     * @SerializedName("catId")
     * @Assert\NotNull()
     * @Assert\Type("int")
     * @Type("int")
     */
    protected $catId;

    /**
     * The name of the category.
     *
     * @var string
     * @SerializedName("name")
     * @Assert\NotNull()
     * @Assert\Type("string")
     * @Type("string")
     */
    protected $name;

    /**
     * List of all sub categories. null or [] (empty array) if the category has no sub categories.
     *
     * @var int[]
     * @SerializedName("children")
     * @Assert\NotNull()
     * @Assert\All({
     *   @Assert\Type("int")
     * })
     * @Type("array<int>")
     */
    protected $children;

    /**
     * The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.
     *
     * @var int
     * @SerializedName("parent")
     * @Assert\NotNull()
     * @Assert\Type("int")
     * @Type("int")
     */
    protected $parent;

    /**
     * The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
     *
     * @var int
     * @SerializedName("highestRank")
     * @Assert\NotNull()
     * @Assert\Type("int")
     * @Type("int")
     */
    protected $highestRank;

    /**
     * Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
     *
     * @var int
     * @SerializedName("productCount")
     * @Assert\NotNull()
     * @Assert\Type("int")
     * @Type("int")
     */
    protected $productCount;

    /**
     * Constructor
     * @param mixed[] $data Associated array of property values initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->domainId = isset($data['domainId']) ? $data['domainId'] : null;
        $this->catId = isset($data['catId']) ? $data['catId'] : null;
        $this->name = isset($data['name']) ? $data['name'] : null;
        $this->children = isset($data['children']) ? $data['children'] : null;
        $this->parent = isset($data['parent']) ? $data['parent'] : null;
        $this->highestRank = isset($data['highestRank']) ? $data['highestRank'] : null;
        $this->productCount = isset($data['productCount']) ? $data['productCount'] : null;
    }

    /**
     * Gets domainId.
     *
     * @return int
     */
    public function getDomainId()
    {
        return $this->domainId;
    }

    /**
     * Sets domainId.
     *
     * @param int $domainId  Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
     *
     * @return $this
     */
    public function setDomainId($domainId)
    {
        $this->domainId = $domainId;

        return $this;
    }

    /**
     * Gets catId.
     *
     * @return int
     */
    public function getCatId()
    {
        return $this->catId;
    }

    /**
     * Sets catId.
     *
     * @param int $catId  The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.
     *
     * @return $this
     */
    public function setCatId($catId)
    {
        $this->catId = $catId;

        return $this;
    }

    /**
     * Gets name.
     *
     * @return string
     */
    public function getName()
    {
        return $this->name;
    }

    /**
     * Sets name.
     *
     * @param string $name  The name of the category.
     *
     * @return $this
     */
    public function setName($name)
    {
        $this->name = $name;

        return $this;
    }

    /**
     * Gets children.
     *
     * @return int[]
     */
    public function getChildren()
    {
        return $this->children;
    }

    /**
     * Sets children.
     *
     * @param int[] $children  List of all sub categories. null or [] (empty array) if the category has no sub categories.
     *
     * @return $this
     */
    public function setChildren(array $children)
    {
        $this->children = $children;

        return $this;
    }

    /**
     * Gets parent.
     *
     * @return int
     */
    public function getParent()
    {
        return $this->parent;
    }

    /**
     * Sets parent.
     *
     * @param int $parent  The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.
     *
     * @return $this
     */
    public function setParent($parent)
    {
        $this->parent = $parent;

        return $this;
    }

    /**
     * Gets highestRank.
     *
     * @return int
     */
    public function getHighestRank()
    {
        return $this->highestRank;
    }

    /**
     * Sets highestRank.
     *
     * @param int $highestRank  The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
     *
     * @return $this
     */
    public function setHighestRank($highestRank)
    {
        $this->highestRank = $highestRank;

        return $this;
    }

    /**
     * Gets productCount.
     *
     * @return int
     */
    public function getProductCount()
    {
        return $this->productCount;
    }

    /**
     * Sets productCount.
     *
     * @param int $productCount  Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
     *
     * @return $this
     */
    public function setProductCount($productCount)
    {
        $this->productCount = $productCount;

        return $this;
    }
}


