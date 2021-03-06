library swagger.api;

import 'dart:async';
import 'dart:convert';
import 'package:http/browser_client.dart';
import 'package:http/http.dart';
import 'package:dartson/dartson.dart';
import 'package:dartson/transformers/date_time.dart';
import 'package:dartson/type_transformer.dart';

part 'api_client.dart';
part 'api_helper.dart';
part 'api_exception.dart';
part 'auth/authentication.dart';
part 'auth/api_key_auth.dart';
part 'auth/oauth.dart';
part 'auth/http_basic_auth.dart';

part 'api/geocoding_api.dart';
part 'api/isochrone_api.dart';
part 'api/matrix_api.dart';
part 'api/routing_api.dart';
part 'api/solution_api.dart';
part 'api/vrp_api.dart';

part 'model/activity.dart';
part 'model/address.dart';
part 'model/algorithm.dart';
part 'model/configuration.dart';
part 'model/cost_matrix.dart';
part 'model/cost_matrix_data.dart';
part 'model/cost_matrix_data_info.dart';
part 'model/gh_error.dart';
part 'model/gh_error_hints.dart';
part 'model/geocoding_location.dart';
part 'model/geocoding_point.dart';
part 'model/geocoding_response.dart';
part 'model/isochrone_response.dart';
part 'model/isochrone_response_polygon.dart';
part 'model/isochrone_response_polygon_geometry.dart';
part 'model/isochrone_response_polygon_properties.dart';
part 'model/job_id.dart';
part 'model/location.dart';
part 'model/matrix_request.dart';
part 'model/matrix_response.dart';
part 'model/model_break.dart';
part 'model/objective.dart';
part 'model/relation.dart';
part 'model/request.dart';
part 'model/response.dart';
part 'model/response_coordinates.dart';
part 'model/response_coordinates_array.dart';
part 'model/response_info.dart';
part 'model/response_instruction.dart';
part 'model/response_instructions.dart';
part 'model/route.dart';
part 'model/route_point.dart';
part 'model/route_response.dart';
part 'model/route_response_path.dart';
part 'model/routing.dart';
part 'model/service.dart';
part 'model/shipment.dart';
part 'model/solution.dart';
part 'model/solution_unassigned.dart';
part 'model/stop.dart';
part 'model/time_window.dart';
part 'model/vehicle.dart';
part 'model/vehicle_type.dart';


ApiClient defaultApiClient = new ApiClient();
