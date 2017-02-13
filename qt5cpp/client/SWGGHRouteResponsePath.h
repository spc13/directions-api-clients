/**
 * GraphHopper Directions API
 * With the GraphHopper Directions API you get reliable and fast web services for routing and more with world wide coverage. We offer A-to-B routing via the Routing API optionally with turn instructions and elevation data as well as route optimization with various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

/*
 * SWGGHRouteResponsePath.h
 * 
 * A found path
 */

#ifndef SWGGHRouteResponsePath_H_
#define SWGGHRouteResponsePath_H_

#include <QJsonObject>


#include "SWGGHResponseCoordinates.h"
#include "SWGGHResponseInstructions.h"
#include <QList>

#include "SWGObject.h"


namespace Swagger {

class SWGGHRouteResponsePath: public SWGObject {
public:
    SWGGHRouteResponsePath();
    SWGGHRouteResponsePath(QString* json);
    virtual ~SWGGHRouteResponsePath();
    void init();
    void cleanup();

    QString asJson ();
    QJsonObject* asJsonObject();
    void fromJsonObject(QJsonObject &json);
    SWGGHRouteResponsePath* fromJson(QString &jsonString);

    double getDistance();
    void setDistance(double distance);

    qint64 getTime();
    void setTime(qint64 time);

    double getAscend();
    void setAscend(double ascend);

    double getDescend();
    void setDescend(double descend);

    SWGGHResponseCoordinates* getPoints();
    void setPoints(SWGGHResponseCoordinates* points);

    bool getPointsEncoded();
    void setPointsEncoded(bool points_encoded);

    QList<double>* getBbox();
    void setBbox(QList<double>* bbox);

    SWGGHResponseCoordinates* getSnappedWaypoints();
    void setSnappedWaypoints(SWGGHResponseCoordinates* snapped_waypoints);

    SWGGHResponseInstructions* getInstructions();
    void setInstructions(SWGGHResponseInstructions* instructions);


private:
    double distance;
    qint64 time;
    double ascend;
    double descend;
    SWGGHResponseCoordinates* points;
    bool points_encoded;
    QList<double>* bbox;
    SWGGHResponseCoordinates* snapped_waypoints;
    SWGGHResponseInstructions* instructions;
};

} /* namespace Swagger */

#endif /* SWGGHRouteResponsePath_H_ */