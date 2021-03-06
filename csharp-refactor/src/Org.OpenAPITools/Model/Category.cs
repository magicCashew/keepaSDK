/* 
 * Keepa API
 *
 * The Keepa API offers numerous endpoints.  Every request requires your API access key as a parameter. You can find and change your key in the keepa portal. All requests must be issued as a HTTPS GET and accept gzip encoding. If possible, use a Keep-Alive connection.  Multiple requests can be made in parallel to increase throughput.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: info@keepa.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Category
    /// </summary>
    [DataContract]
    public partial class Category :  IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
        /// </summary>
        /// <value>Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</value>
        public enum DomainIdEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1,

            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            NUMBER_2 = 2,

            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            NUMBER_3 = 3,

            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            NUMBER_4 = 4,

            /// <summary>
            /// Enum NUMBER_5 for value: 5
            /// </summary>
            NUMBER_5 = 5,

            /// <summary>
            /// Enum NUMBER_6 for value: 6
            /// </summary>
            NUMBER_6 = 6,

            /// <summary>
            /// Enum NUMBER_7 for value: 7
            /// </summary>
            NUMBER_7 = 7,

            /// <summary>
            /// Enum NUMBER_8 for value: 8
            /// </summary>
            NUMBER_8 = 8,

            /// <summary>
            /// Enum NUMBER_9 for value: 9
            /// </summary>
            NUMBER_9 = 9,

            /// <summary>
            /// Enum NUMBER_10 for value: 10
            /// </summary>
            NUMBER_10 = 10,

            /// <summary>
            /// Enum NUMBER_11 for value: 11
            /// </summary>
            NUMBER_11 = 11,

            /// <summary>
            /// Enum NUMBER_12 for value: 12
            /// </summary>
            NUMBER_12 = 12,

            /// <summary>
            /// Enum NUMBER_13 for value: 13
            /// </summary>
            NUMBER_13 = 13

        }

        /// <summary>
        /// Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)
        /// </summary>
        /// <value>Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au)</value>
        [DataMember(Name="domainId", EmitDefaultValue=false)]
        public DomainIdEnum DomainId { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Category() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="domainId">Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au) (required).</param>
        /// <param name="catId">The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories. (required).</param>
        /// <param name="name">The name of the category. (required).</param>
        /// <param name="children">List of all sub categories. null or [] (empty array) if the category has no sub categories. (required).</param>
        /// <param name="parent">The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category. (required).</param>
        /// <param name="highestRank">The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon. (required).</param>
        /// <param name="productCount">Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon. (required).</param>
        public Category(DomainIdEnum domainId = default(DomainIdEnum), int catId = default(int), string name = default(string), List<int?> children = default(List<int?>), int parent = default(int), int highestRank = default(int), int productCount = default(int))
        {
            this.DomainId = domainId;
            // to ensure "catId" is required (not null)
            if (catId == null)
            {
                throw new InvalidDataException("catId is a required property for Category and cannot be null");
            }
            else
            {
                this.CatId = catId;
            }

            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Category and cannot be null");
            }
            else
            {
                this.Name = name;
            }

            // to ensure "children" is required (not null)
            if (children == null)
            {
                throw new InvalidDataException("children is a required property for Category and cannot be null");
            }
            else
            {
                this.Children = children;
            }

            // to ensure "parent" is required (not null)
            if (parent == null)
            {
                throw new InvalidDataException("parent is a required property for Category and cannot be null");
            }
            else
            {
                this.Parent = parent;
            }

            // to ensure "highestRank" is required (not null)
            if (highestRank == null)
            {
                throw new InvalidDataException("highestRank is a required property for Category and cannot be null");
            }
            else
            {
                this.HighestRank = highestRank;
            }

            // to ensure "productCount" is required (not null)
            if (productCount == null)
            {
                throw new InvalidDataException("productCount is a required property for Category and cannot be null");
            }
            else
            {
                this.ProductCount = productCount;
            }

        }
        
        /// <summary>
        /// The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.
        /// </summary>
        /// <value>The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories.</value>
        [DataMember(Name="catId", EmitDefaultValue=false)]
        public int CatId { get; set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        /// <value>The name of the category.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// List of all sub categories. null or [] (empty array) if the category has no sub categories.
        /// </summary>
        /// <value>List of all sub categories. null or [] (empty array) if the category has no sub categories.</value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<int?> Children { get; set; }

        /// <summary>
        /// The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.
        /// </summary>
        /// <value>The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category.</value>
        [DataMember(Name="parent", EmitDefaultValue=false)]
        public int Parent { get; set; }

        /// <summary>
        /// The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
        /// </summary>
        /// <value>The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.</value>
        [DataMember(Name="highestRank", EmitDefaultValue=false)]
        public int HighestRank { get; set; }

        /// <summary>
        /// Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.
        /// </summary>
        /// <value>Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon.</value>
        [DataMember(Name="productCount", EmitDefaultValue=false)]
        public int ProductCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  CatId: ").Append(CatId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  HighestRank: ").Append(HighestRank).Append("\n");
            sb.Append("  ProductCount: ").Append(ProductCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="input">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DomainId == input.DomainId ||
                    this.DomainId.Equals(input.DomainId)
                ) && 
                (
                    this.CatId == input.CatId ||
                    (this.CatId != null &&
                    this.CatId.Equals(input.CatId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.HighestRank == input.HighestRank ||
                    (this.HighestRank != null &&
                    this.HighestRank.Equals(input.HighestRank))
                ) && 
                (
                    this.ProductCount == input.ProductCount ||
                    (this.ProductCount != null &&
                    this.ProductCount.Equals(input.ProductCount))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.CatId != null)
                    hashCode = hashCode * 59 + this.CatId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Parent != null)
                    hashCode = hashCode * 59 + this.Parent.GetHashCode();
                if (this.HighestRank != null)
                    hashCode = hashCode * 59 + this.HighestRank.GetHashCode();
                if (this.ProductCount != null)
                    hashCode = hashCode * 59 + this.ProductCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
