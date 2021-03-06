/**
 * GraphHopper Directions API
 * You use the GraphHopper Directions API to add route planning, navigation and route optimization to your software. E.g. the Routing API has turn instructions and elevation data and the Route Optimization API solves your logistic problems and supports various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


#include "SWGMatrixRequest.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {

SWGMatrixRequest::SWGMatrixRequest(QString* json) {
    init();
    this->fromJson(*json);
}

SWGMatrixRequest::SWGMatrixRequest() {
    init();
}

SWGMatrixRequest::~SWGMatrixRequest() {
    this->cleanup();
}

void
SWGMatrixRequest::init() {
    points = new QList<QList<double>*>();
    m_points_isSet = false;
    from_points = new QList<QList<double>*>();
    m_from_points_isSet = false;
    to_points = new QList<QList<double>*>();
    m_to_points_isSet = false;
    out_arrays = new QList<QString*>();
    m_out_arrays_isSet = false;
    vehicle = new QString("");
    m_vehicle_isSet = false;
}

void
SWGMatrixRequest::cleanup() {
    if(points != nullptr) { 
        auto arr = points;
        for(auto o: *arr) { 
            for(auto o1: *o) {                
                delete o1;
            }
            delete o;
        }
        delete points;
    }
    if(from_points != nullptr) { 
        auto arr = from_points;
        for(auto o: *arr) { 
            for(auto o1: *o) {                
                delete o1;
            }
            delete o;
        }
        delete from_points;
    }
    if(to_points != nullptr) { 
        auto arr = to_points;
        for(auto o: *arr) { 
            for(auto o1: *o) {                
                delete o1;
            }
            delete o;
        }
        delete to_points;
    }
    if(out_arrays != nullptr) { 
        auto arr = out_arrays;
        for(auto o: *arr) { 
            delete o;
        }
        delete out_arrays;
    }
    if(vehicle != nullptr) { 
        delete vehicle;
    }
}

SWGMatrixRequest*
SWGMatrixRequest::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGMatrixRequest::fromJsonObject(QJsonObject &pJson) {
    
    
    if(pJson["points"].isArray()){
        auto arr = pJson["points"].toArray();
        for (const QJsonValue & jval : arr) {
            auto points_item = new QList<double>();
            
            auto jsonval = jval.toObject();
            ::Swagger::setValue(points_item, jsonval, "QList", "double"); 
            points->push_back(points_item);
        }
    }
    
    
    if(pJson["from_points"].isArray()){
        auto arr = pJson["from_points"].toArray();
        for (const QJsonValue & jval : arr) {
            auto from_points_item = new QList<double>();
            
            auto jsonval = jval.toObject();
            ::Swagger::setValue(from_points_item, jsonval, "QList", "double"); 
            from_points->push_back(from_points_item);
        }
    }
    
    
    if(pJson["to_points"].isArray()){
        auto arr = pJson["to_points"].toArray();
        for (const QJsonValue & jval : arr) {
            auto to_points_item = new QList<double>();
            
            auto jsonval = jval.toObject();
            ::Swagger::setValue(to_points_item, jsonval, "QList", "double"); 
            to_points->push_back(to_points_item);
        }
    }
    
    ::Swagger::setValue(&out_arrays, pJson["out_arrays"], "QList", "QString");
    ::Swagger::setValue(&vehicle, pJson["vehicle"], "QString", "QString");
    
}

QString
SWGMatrixRequest::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGMatrixRequest::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    if(points->size() > 0){
        
        QJsonArray jarray;
        for(auto items : *points){
            QJsonObject jobj;
            toJsonArray((QList<void*>*)items, &jobj, "points", "double");
            
            jarray.append(jobj.value("points"));
        }
        obj->insert("points", jarray);
    }
    
    if(from_points->size() > 0){
        
        QJsonArray jarray;
        for(auto items : *from_points){
            QJsonObject jobj;
            toJsonArray((QList<void*>*)items, &jobj, "from_points", "double");
            
            jarray.append(jobj.value("from_points"));
        }
        obj->insert("from_points", jarray);
    }
    
    if(to_points->size() > 0){
        
        QJsonArray jarray;
        for(auto items : *to_points){
            QJsonObject jobj;
            toJsonArray((QList<void*>*)items, &jobj, "to_points", "double");
            
            jarray.append(jobj.value("to_points"));
        }
        obj->insert("to_points", jarray);
    }
    
    if(out_arrays->size() > 0){
        toJsonArray((QList<void*>*)out_arrays, obj, "out_arrays", "QString");
    }
    
    if(vehicle != nullptr && *vehicle != QString("")){
        toJsonValue(QString("vehicle"), vehicle, obj, QString("QString"));
    }

    return obj;
}

QList<QList<double>*>*
SWGMatrixRequest::getPoints() {
    return points;
}
void
SWGMatrixRequest::setPoints(QList<QList<double>*>* points) {
    this->points = points;
    this->m_points_isSet = true;
}

QList<QList<double>*>*
SWGMatrixRequest::getFromPoints() {
    return from_points;
}
void
SWGMatrixRequest::setFromPoints(QList<QList<double>*>* from_points) {
    this->from_points = from_points;
    this->m_from_points_isSet = true;
}

QList<QList<double>*>*
SWGMatrixRequest::getToPoints() {
    return to_points;
}
void
SWGMatrixRequest::setToPoints(QList<QList<double>*>* to_points) {
    this->to_points = to_points;
    this->m_to_points_isSet = true;
}

QList<QString*>*
SWGMatrixRequest::getOutArrays() {
    return out_arrays;
}
void
SWGMatrixRequest::setOutArrays(QList<QString*>* out_arrays) {
    this->out_arrays = out_arrays;
    this->m_out_arrays_isSet = true;
}

QString*
SWGMatrixRequest::getVehicle() {
    return vehicle;
}
void
SWGMatrixRequest::setVehicle(QString* vehicle) {
    this->vehicle = vehicle;
    this->m_vehicle_isSet = true;
}


bool 
SWGMatrixRequest::isSet(){
    bool isObjectUpdated = false;
    do{
        if(points->size() > 0){ isObjectUpdated = true; break;}
        if(from_points->size() > 0){ isObjectUpdated = true; break;}
        if(to_points->size() > 0){ isObjectUpdated = true; break;}
        if(out_arrays->size() > 0){ isObjectUpdated = true; break;}
        if(vehicle != nullptr && *vehicle != QString("")){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}

