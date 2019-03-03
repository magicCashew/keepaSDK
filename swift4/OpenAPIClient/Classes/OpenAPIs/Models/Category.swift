//
// Category.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation



public struct Category: Codable {

    public enum DomainId: Int, Codable {
        case _1 = 1
        case _2 = 2
        case _3 = 3
        case _4 = 4
        case _5 = 5
        case _6 = 6
        case _7 = 7
        case _8 = 8
        case _9 = 9
        case _10 = 10
        case _11 = 11
        case _12 = 12
        case _13 = 13
    }
    /** Integer value for the Amazon locale you want to access. (1-com, 2-co.uk, 3-de, 4-fr, 5-co.jp, 6-ca, 7-cn, 8-it, 9-es, 10-in, 11-com.mx, 12-com.br, 13-com.au) */
    public var domainId: DomainId
    /** The category node id used by Amazon. Represents the identifier of the category. Also part of the Product object’s categories and rootCategory fields. Always a positive Long value. Note - The id 9223372036854775807 (max signed long value) denotes a blank category with the name “?”. We use this in cases where a product is listed in no or non-existent categories. */
    public var catId: Int
    /** The name of the category. */
    public var name: String
    /** List of all sub categories. null or [] (empty array) if the category has no sub categories. */
    public var children: [Int]
    /** The parent category’s Id. Always a positive Long value. If it is 0 the category is a root category and has no parent category. */
    public var parent: Int
    /** The highest (root category) sales rank we have observed of a product that is listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon. */
    public var highestRank: Int
    /** Number of products that are listed in this category. Note- Estimate, as the value is from the Keepa product database and not retrieved from Amazon. */
    public var productCount: Int

    public init(domainId: DomainId, catId: Int, name: String, children: [Int], parent: Int, highestRank: Int, productCount: Int) {
        self.domainId = domainId
        self.catId = catId
        self.name = name
        self.children = children
        self.parent = parent
        self.highestRank = highestRank
        self.productCount = productCount
    }


}

