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


#include "OAICategory.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAICategory::OAICategory(QString json) {
    this->init();
    this->fromJson(json);
}

OAICategory::OAICategory() {
    this->init();
}

OAICategory::~OAICategory() {

}

void
OAICategory::init() {
    m_domain_id_isSet = false;
    m_domain_id_isValid = false;
    m_cat_id_isSet = false;
    m_cat_id_isValid = false;
    m_name_isSet = false;
    m_name_isValid = false;
    m_children_isSet = false;
    m_children_isValid = false;
    m_parent_isSet = false;
    m_parent_isValid = false;
    m_highest_rank_isSet = false;
    m_highest_rank_isValid = false;
    m_product_count_isSet = false;
    m_product_count_isValid = false;
}

void
OAICategory::fromJson(QString jsonString) {
    QByteArray array (jsonString.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
}

void
OAICategory::fromJsonObject(QJsonObject json) {
    m_domain_id_isValid = ::OpenAPI::fromJsonValue(domain_id, json[QString("domainId")]);
    
    m_cat_id_isValid = ::OpenAPI::fromJsonValue(cat_id, json[QString("catId")]);
    
    m_name_isValid = ::OpenAPI::fromJsonValue(name, json[QString("name")]);
    
    
    m_children_isValid = ::OpenAPI::fromJsonValue(children, json[QString("children")]);
    m_parent_isValid = ::OpenAPI::fromJsonValue(parent, json[QString("parent")]);
    
    m_highest_rank_isValid = ::OpenAPI::fromJsonValue(highest_rank, json[QString("highestRank")]);
    
    m_product_count_isValid = ::OpenAPI::fromJsonValue(product_count, json[QString("productCount")]);
    
}

QString
OAICategory::asJson () const {
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAICategory::asJsonObject() const {
    QJsonObject obj;
	if(m_domain_id_isSet){
        obj.insert(QString("domainId"), ::OpenAPI::toJsonValue(domain_id));
    }
	if(m_cat_id_isSet){
        obj.insert(QString("catId"), ::OpenAPI::toJsonValue(cat_id));
    }
	if(m_name_isSet){
        obj.insert(QString("name"), ::OpenAPI::toJsonValue(name));
    }
	
    if(children.size() > 0){
        obj.insert(QString("children"), ::OpenAPI::toJsonValue(children));
    } 
	if(m_parent_isSet){
        obj.insert(QString("parent"), ::OpenAPI::toJsonValue(parent));
    }
	if(m_highest_rank_isSet){
        obj.insert(QString("highestRank"), ::OpenAPI::toJsonValue(highest_rank));
    }
	if(m_product_count_isSet){
        obj.insert(QString("productCount"), ::OpenAPI::toJsonValue(product_count));
    }
    return obj;
}

qint32
OAICategory::getDomainId() const {
    return domain_id;
}
void
OAICategory::setDomainId(const qint32 &domain_id) {
    this->domain_id = domain_id;
    this->m_domain_id_isSet = true;
}

qint32
OAICategory::getCatId() const {
    return cat_id;
}
void
OAICategory::setCatId(const qint32 &cat_id) {
    this->cat_id = cat_id;
    this->m_cat_id_isSet = true;
}

QString
OAICategory::getName() const {
    return name;
}
void
OAICategory::setName(const QString &name) {
    this->name = name;
    this->m_name_isSet = true;
}

QList<qint32>
OAICategory::getChildren() const {
    return children;
}
void
OAICategory::setChildren(const QList<qint32> &children) {
    this->children = children;
    this->m_children_isSet = true;
}

qint32
OAICategory::getParent() const {
    return parent;
}
void
OAICategory::setParent(const qint32 &parent) {
    this->parent = parent;
    this->m_parent_isSet = true;
}

qint32
OAICategory::getHighestRank() const {
    return highest_rank;
}
void
OAICategory::setHighestRank(const qint32 &highest_rank) {
    this->highest_rank = highest_rank;
    this->m_highest_rank_isSet = true;
}

qint32
OAICategory::getProductCount() const {
    return product_count;
}
void
OAICategory::setProductCount(const qint32 &product_count) {
    this->product_count = product_count;
    this->m_product_count_isSet = true;
}

bool
OAICategory::isSet() const {
    bool isObjectUpdated = false;
    do{ 
        if(m_domain_id_isSet){ isObjectUpdated = true; break;}
    
        if(m_cat_id_isSet){ isObjectUpdated = true; break;}
    
        if(m_name_isSet){ isObjectUpdated = true; break;}
    
        if(children.size() > 0){ isObjectUpdated = true; break;}
    
        if(m_parent_isSet){ isObjectUpdated = true; break;}
    
        if(m_highest_rank_isSet){ isObjectUpdated = true; break;}
    
        if(m_product_count_isSet){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}

bool
OAICategory::isValid() const {
    // only required properties are required for the object to be considered valid
    return m_domain_id_isValid && m_cat_id_isValid && m_name_isValid && m_children_isValid && m_parent_isValid && m_highest_rank_isValid && m_product_count_isValid && true;
}

}

