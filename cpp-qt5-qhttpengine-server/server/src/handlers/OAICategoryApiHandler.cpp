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

#include <QJsonArray>
#include <QJsonDocument>
#include <QJsonObject>
#include <QVariantMap>
#include <QDebug>

#include "OAICategoryApiHandler.h"
#include "OAICategoryApiRequest.h"

namespace OpenAPI {

OAICategoryApiHandler::OAICategoryApiHandler(){

}

OAICategoryApiHandler::~OAICategoryApiHandler(){

}

void OAICategoryApiHandler::category(QString key, qint32 domain, qint32 category, qint32 parents) {
    Q_UNUSED(key);
    Q_UNUSED(domain);
    Q_UNUSED(category);
    Q_UNUSED(parents);
    auto reqObj = qobject_cast<OAICategoryApiRequest*>(sender());
    if( reqObj != nullptr ) 
    { 
        QList<OAICategory> res;
        reqObj->categoryResponse(res);
    }    
}


}
