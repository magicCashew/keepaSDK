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

#ifndef OAI_OAIProductApiRequest_H
#define OAI_OAIProductApiRequest_H

#include <QObject>
#include <QStringList>
#include <QMultiMap>
#include <QNetworkReply>
#include <QSharedPointer>

#include <qhttpengine/socket.h>
#include "OAICategory.h"
#include <QString>
#include "OAIProductApiHandler.h"

namespace OpenAPI {

class OAIProductApiRequest : public QObject
{
    Q_OBJECT

public:
    OAIProductApiRequest(QHttpEngine::Socket *s, OAIProductApiHandler* handler);
    virtual ~OAIProductApiRequest();

    void productRequest();
    

    void productResponse(const QList<OAICategory>& res);
    

    void productError(const QList<OAICategory>& res, QNetworkReply::NetworkError error_type, QString& error_str);
    

    void sendCustomResponse(QByteArray & res, QNetworkReply::NetworkError error_type);

    void sendCustomResponse(QIODevice *res, QNetworkReply::NetworkError error_type);

    QMap<QString, QString> getRequestHeaders() const;

    QHttpEngine::Socket* getRawSocket();

    void setResponseHeaders(const QMultiMap<QString,QString>& headers);

signals:
    void product(QString key, qint32 domain, QString asin, QString code);
    

private:
    QMap<QString, QString> requestHeaders;
    QMap<QString, QString> responseHeaders;
    QHttpEngine::Socket  *socket;
    OAIProductApiHandler *handler;

    inline void writeResponseHeaders(){
        QHttpEngine::Socket::HeaderMap resHeaders;
        for(auto itr = responseHeaders.begin(); itr != responseHeaders.end(); ++itr) {
            resHeaders.insert(itr.key().toUtf8(), itr.value().toUtf8());
        }
        socket->setHeaders(resHeaders);
        socket->writeHeaders();
    }
};

}

#endif // OAI_OAIProductApiRequest_H
