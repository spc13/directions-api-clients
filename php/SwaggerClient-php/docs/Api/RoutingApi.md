# Swagger\Client\RoutingApi

All URIs are relative to *https://graphhopper.com/api/1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**routeGet**](RoutingApi.md#routeGet) | **GET** /route | Routing Request


# **routeGet**
> \Swagger\Client\Model\RouteResponse routeGet($point, $points_encoded, $key, $locale, $instructions, $vehicle, $elevation, $calc_points, $point_hint, $ch_disable, $weighting, $edge_traversal, $algorithm, $heading, $heading_penalty, $pass_through, $round_trip_distance, $round_trip_seed, $alternative_route_max_paths, $alternative_route_max_weight_factor, $alternative_route_max_share_factor, $avoid)

Routing Request

The GraphHopper Routing API allows to calculate route and implement navigation via the turn instructions

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\RoutingApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$point = array("point_example"); // string[] | Specify multiple points for which the route should be calculated. The order is important. Specify at least two points.
$points_encoded = true; // bool | IMPORTANT- TODO - currently you have to pass false for the swagger client - Have not found a way to force add a parameter. If `false` the coordinates in `point` and `snapped_waypoints` are returned as array using the order [lon,lat,elevation] for every point. If `true` the coordinates will be encoded as string leading to less bandwith usage. You'll need a special handling for the decoding of this string on the client-side. We provide open source code in [Java](https://github.com/graphhopper/graphhopper/blob/d70b63660ac5200b03c38ba3406b8f93976628a6/web/src/main/java/com/graphhopper/http/WebHelper.java#L43) and [JavaScript](https://github.com/graphhopper/graphhopper/blob/d70b63660ac5200b03c38ba3406b8f93976628a6/web/src/main/webapp/js/ghrequest.js#L139). It is especially important to use no 3rd party client if you set `elevation=true`!
$key = "key_example"; // string | Get your key at graphhopper.com
$locale = "locale_example"; // string | The locale of the resulting turn instructions. E.g. `pt_PT` for Portuguese or `de` for German
$instructions = true; // bool | If instruction should be calculated and returned
$vehicle = "vehicle_example"; // string | The vehicle for which the route should be calculated. Other vehicles are foot, small_truck, ...
$elevation = true; // bool | If `true` a third dimension - the elevation - is included in the polyline or in the GeoJson. If enabled you have to use a modified version of the decoding method or set points_encoded to `false`. See the points_encoded attribute for more details. Additionally a request can fail if the vehicle does not support elevation. See the features object for every vehicle.
$calc_points = true; // bool | If the points for the route should be calculated at all printing out only distance and time.
$point_hint = array("point_hint_example"); // string[] | Optional parameter. Specifies a hint for each `point` parameter to prefer a certain street for the closest location lookup. E.g. if there is an address or house with two or more neighboring streets you can control for which street the closest location is looked up.
$ch_disable = true; // bool | Use this parameter in combination with one or more parameters of this table
$weighting = "weighting_example"; // string | Which kind of 'best' route calculation you need. Other option is `shortest` (e.g. for `vehicle=foot` or `bike`), `short_fastest` if time and distance is expensive e.g. for `vehicle=truck`
$edge_traversal = true; // bool | Use `true` if you want to consider turn restrictions for bike and motor vehicles. Keep in mind that the response time is roughly 2 times slower.
$algorithm = "algorithm_example"; // string | The algorithm to calculate the route. Other options are `dijkstra`, `astar`, `astarbi`, `alternative_route` and `round_trip`
$heading = 56; // int | Favour a heading direction for a certain point. Specify either one heading for the start point or as many as there are points. In this case headings are associated by their order to the specific points. Headings are given as north based clockwise angle between 0 and 360 degree. This parameter also influences the tour generated with `algorithm=round_trip` and force the initial direction.
$heading_penalty = 56; // int | Penalty for omitting a specified heading. The penalty corresponds to the accepted time delay in seconds in comparison to the route without a heading.
$pass_through = true; // bool | If `true` u-turns are avoided at via-points with regard to the `heading_penalty`.
$round_trip_distance = 56; // int | If `algorithm=round_trip` this parameter configures approximative length of the resulting round trip
$round_trip_seed = 789; // int | If `algorithm=round_trip` this parameter introduces randomness if e.g. the first try wasn't good.
$alternative_route_max_paths = 56; // int | If `algorithm=alternative_route` this parameter sets the number of maximum paths which should be calculated. Increasing can lead to worse alternatives.
$alternative_route_max_weight_factor = 56; // int | If `algorithm=alternative_route` this parameter sets the factor by which the alternatives routes can be longer than the optimal route. Increasing can lead to worse alternatives.
$alternative_route_max_share_factor = 56; // int | If `algorithm=alternative_route` this parameter specifies how much alternatives routes can have maximum in common with the optimal route. Increasing can lead to worse alternatives.
$avoid = "avoid_example"; // string | comma separate list to avoid certain roads. You can avoid motorway, ferry, tunnel or track

try {
    $result = $apiInstance->routeGet($point, $points_encoded, $key, $locale, $instructions, $vehicle, $elevation, $calc_points, $point_hint, $ch_disable, $weighting, $edge_traversal, $algorithm, $heading, $heading_penalty, $pass_through, $round_trip_distance, $round_trip_seed, $alternative_route_max_paths, $alternative_route_max_weight_factor, $alternative_route_max_share_factor, $avoid);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling RoutingApi->routeGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **point** | [**string[]**](../Model/string.md)| Specify multiple points for which the route should be calculated. The order is important. Specify at least two points. |
 **points_encoded** | **bool**| IMPORTANT- TODO - currently you have to pass false for the swagger client - Have not found a way to force add a parameter. If &#x60;false&#x60; the coordinates in &#x60;point&#x60; and &#x60;snapped_waypoints&#x60; are returned as array using the order [lon,lat,elevation] for every point. If &#x60;true&#x60; the coordinates will be encoded as string leading to less bandwith usage. You&#39;ll need a special handling for the decoding of this string on the client-side. We provide open source code in [Java](https://github.com/graphhopper/graphhopper/blob/d70b63660ac5200b03c38ba3406b8f93976628a6/web/src/main/java/com/graphhopper/http/WebHelper.java#L43) and [JavaScript](https://github.com/graphhopper/graphhopper/blob/d70b63660ac5200b03c38ba3406b8f93976628a6/web/src/main/webapp/js/ghrequest.js#L139). It is especially important to use no 3rd party client if you set &#x60;elevation&#x3D;true&#x60;! |
 **key** | **string**| Get your key at graphhopper.com |
 **locale** | **string**| The locale of the resulting turn instructions. E.g. &#x60;pt_PT&#x60; for Portuguese or &#x60;de&#x60; for German | [optional]
 **instructions** | **bool**| If instruction should be calculated and returned | [optional]
 **vehicle** | **string**| The vehicle for which the route should be calculated. Other vehicles are foot, small_truck, ... | [optional]
 **elevation** | **bool**| If &#x60;true&#x60; a third dimension - the elevation - is included in the polyline or in the GeoJson. If enabled you have to use a modified version of the decoding method or set points_encoded to &#x60;false&#x60;. See the points_encoded attribute for more details. Additionally a request can fail if the vehicle does not support elevation. See the features object for every vehicle. | [optional]
 **calc_points** | **bool**| If the points for the route should be calculated at all printing out only distance and time. | [optional]
 **point_hint** | [**string[]**](../Model/string.md)| Optional parameter. Specifies a hint for each &#x60;point&#x60; parameter to prefer a certain street for the closest location lookup. E.g. if there is an address or house with two or more neighboring streets you can control for which street the closest location is looked up. | [optional]
 **ch_disable** | **bool**| Use this parameter in combination with one or more parameters of this table | [optional]
 **weighting** | **string**| Which kind of &#39;best&#39; route calculation you need. Other option is &#x60;shortest&#x60; (e.g. for &#x60;vehicle&#x3D;foot&#x60; or &#x60;bike&#x60;), &#x60;short_fastest&#x60; if time and distance is expensive e.g. for &#x60;vehicle&#x3D;truck&#x60; | [optional]
 **edge_traversal** | **bool**| Use &#x60;true&#x60; if you want to consider turn restrictions for bike and motor vehicles. Keep in mind that the response time is roughly 2 times slower. | [optional]
 **algorithm** | **string**| The algorithm to calculate the route. Other options are &#x60;dijkstra&#x60;, &#x60;astar&#x60;, &#x60;astarbi&#x60;, &#x60;alternative_route&#x60; and &#x60;round_trip&#x60; | [optional]
 **heading** | **int**| Favour a heading direction for a certain point. Specify either one heading for the start point or as many as there are points. In this case headings are associated by their order to the specific points. Headings are given as north based clockwise angle between 0 and 360 degree. This parameter also influences the tour generated with &#x60;algorithm&#x3D;round_trip&#x60; and force the initial direction. | [optional]
 **heading_penalty** | **int**| Penalty for omitting a specified heading. The penalty corresponds to the accepted time delay in seconds in comparison to the route without a heading. | [optional]
 **pass_through** | **bool**| If &#x60;true&#x60; u-turns are avoided at via-points with regard to the &#x60;heading_penalty&#x60;. | [optional]
 **round_trip_distance** | **int**| If &#x60;algorithm&#x3D;round_trip&#x60; this parameter configures approximative length of the resulting round trip | [optional]
 **round_trip_seed** | **int**| If &#x60;algorithm&#x3D;round_trip&#x60; this parameter introduces randomness if e.g. the first try wasn&#39;t good. | [optional]
 **alternative_route_max_paths** | **int**| If &#x60;algorithm&#x3D;alternative_route&#x60; this parameter sets the number of maximum paths which should be calculated. Increasing can lead to worse alternatives. | [optional]
 **alternative_route_max_weight_factor** | **int**| If &#x60;algorithm&#x3D;alternative_route&#x60; this parameter sets the factor by which the alternatives routes can be longer than the optimal route. Increasing can lead to worse alternatives. | [optional]
 **alternative_route_max_share_factor** | **int**| If &#x60;algorithm&#x3D;alternative_route&#x60; this parameter specifies how much alternatives routes can have maximum in common with the optimal route. Increasing can lead to worse alternatives. | [optional]
 **avoid** | **string**| comma separate list to avoid certain roads. You can avoid motorway, ferry, tunnel or track | [optional]

### Return type

[**\Swagger\Client\Model\RouteResponse**](../Model/RouteResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

