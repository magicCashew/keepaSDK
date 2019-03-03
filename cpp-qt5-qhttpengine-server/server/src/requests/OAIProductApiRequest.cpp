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

#include "OAIHelpers.h"
#include "OAIProductApiRequest.h"

namespace OpenAPI {

OAIProductApiRequest::OAIProductApiRequest(QHttpEngine::Socket *s, OAIProductApiHandler* hdl) : QObject(s), socket(s), handler(hdl) {
    auto headers = s->headers();
    for(auto itr = headers.begin(); itr != headers.end(); itr++) {
        requestHeaders.insert(QString(itr.key()), QString(itr.value()));
    }
}

OAIProductApiRequest::~OAIProductApiRequest(){
    disconnect(this, nullptr, nullptr, nullptr);
    qDebug() << "OAIProductApiRequest::~OAIProductApiRequest()";
}

QMap<QString, QString>
OAIProductApiRequest::getRequestHeaders() const {
    return requestHeaders;
}

void OAIProductApiRequest::setResponseHeaders(const QMultiMap<QString, QString>& headers){
    for(auto itr = headers.begin(); itr != headers.end(); ++itr) {
        responseHeaders.insert(itr.key(), itr.value());
    }
}


QHttpEngine::Socket* OAIProductApiRequest::getRawSocket(){
    return socket;
}


void OAIProductApiRequest::productRequest(){
    qDebug() << "/magicCashew/keepa/1.0.0/product";
    connect(this, &OAIProductApiRequest::product, handler, &OAIProductApiHandler::product);

    
    QString key;
    if(socket->queryString().keys().contains("key")){
        fromStringValue(socket->queryString().value("key"), key);
    }
    
    qint32 domain;
    if(socket->queryString().keys().contains("domain")){
        fromStringValue(socket->queryString().value("domain"), domain);
    }
    
    QString asin;
    if(socket->queryString().keys().contains("asin")){
        fromStringValue(socket->queryString().value("asin"), asin);
    }
    
    QString code;
    if(socket->queryString().keys().contains("code")){
        fromStringValue(socket->queryString().value("code"), code);
    }
    


    emit product(key, domain, asin, code);
}



void OAIProductApiRequest::productResponse(const QList<OAICategory>& res){
    writeResponseHeaders();
    QJsonDocument resDoc(::OpenAPI::toJsonValue(res).toArray());
    socket->writeJson(resDoc);
    if(socket->isOpen()){
        socket->close();
    }
}


void OAIProductApiRequest::productError(const QList<OAICategory>& res, QNetworkReply::NetworkError error_type, QString& error_str){
    Q_UNUSED(error_type); // TODO: Remap error_type to QHttpEngine::Socket errors
    writeResponseHeaders();
    Q_UNUSED(error_str);  // response will be used instead of error string
    QJsonDocument resDoc(::OpenAPI::toJsonValue(res).toArray());
    socket->writeJson(resDoc);
    if(socket->isOpen()){
        socket->close();
    }
}


void OAIProductApiRequest::sendCustomResponse(QByteArray & res, QNetworkReply::NetworkError error_type){
    Q_UNUSED(error_type); // TODO
    socket->write(res);
    if(socket->isOpen()){
        socket->close();
    }    
}

void OAIProductApiRequest::sendCustomResponse(QIODevice *res, QNetworkReply::NetworkError error_type){
    Q_UNUSED(error_type);  // TODO
    socket->write(res->readAll());
    if(socket->isOpen()){
        socket->close();
    }
}

}
