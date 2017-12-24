/*
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


package com.graphhopper.directions.api.client.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.graphhopper.directions.api.client.model.ResponseInfo;
import com.graphhopper.directions.api.client.model.RouteResponsePath;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * RouteResponse
 */

public class RouteResponse {
  @SerializedName("paths")
  private List<RouteResponsePath> paths = null;

  @SerializedName("info")
  private ResponseInfo info = null;

  public RouteResponse paths(List<RouteResponsePath> paths) {
    this.paths = paths;
    return this;
  }

  public RouteResponse addPathsItem(RouteResponsePath pathsItem) {
    if (this.paths == null) {
      this.paths = new ArrayList<RouteResponsePath>();
    }
    this.paths.add(pathsItem);
    return this;
  }

   /**
   * Get paths
   * @return paths
  **/
  @ApiModelProperty(value = "")
  public List<RouteResponsePath> getPaths() {
    return paths;
  }

  public void setPaths(List<RouteResponsePath> paths) {
    this.paths = paths;
  }

  public RouteResponse info(ResponseInfo info) {
    this.info = info;
    return this;
  }

   /**
   * Get info
   * @return info
  **/
  @ApiModelProperty(value = "")
  public ResponseInfo getInfo() {
    return info;
  }

  public void setInfo(ResponseInfo info) {
    this.info = info;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    RouteResponse routeResponse = (RouteResponse) o;
    return Objects.equals(this.paths, routeResponse.paths) &&
        Objects.equals(this.info, routeResponse.info);
  }

  @Override
  public int hashCode() {
    return Objects.hash(paths, info);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RouteResponse {\n");
    
    sb.append("    paths: ").append(toIndentedString(paths)).append("\n");
    sb.append("    info: ").append(toIndentedString(info)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}
