/* 
 * GraphHopper Directions API
 *
 * You use the GraphHopper Directions API to add route planning, navigation and route optimization to your software. E.g. the Routing API has turn instructions and elevation data and the Route Optimization API solves your logistic problems and supports various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// A found path
    /// </summary>
    [DataContract]
    public partial class RouteResponsePath :  IEquatable<RouteResponsePath>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteResponsePath" /> class.
        /// </summary>
        /// <param name="Distance">The total distance of the route, in meter.</param>
        /// <param name="Time">The total time of the route, in ms.</param>
        /// <param name="Ascend">Ascend.</param>
        /// <param name="Descend">The total descend (downhill) of the route, in meter.</param>
        /// <param name="Points">Points.</param>
        /// <param name="PointsEncoded">Is true if the points are encoded, if not paths[0].points contains the geo json of the path (then order is lon,lat,elevation), which is easier to handle but consumes more bandwidth compared to encoded version.</param>
        /// <param name="Bbox">The bounding box of the route, format &lt;br&gt; minLon, minLat, maxLon, maxLat.</param>
        /// <param name="SnappedWaypoints">SnappedWaypoints.</param>
        /// <param name="Instructions">Instructions.</param>
        public RouteResponsePath(double? Distance = default(double?), long? Time = default(long?), double? Ascend = default(double?), double? Descend = default(double?), ResponseCoordinates Points = default(ResponseCoordinates), bool? PointsEncoded = default(bool?), List<double?> Bbox = default(List<double?>), ResponseCoordinates SnappedWaypoints = default(ResponseCoordinates), ResponseInstructions Instructions = default(ResponseInstructions))
        {
            this.Distance = Distance;
            this.Time = Time;
            this.Ascend = Ascend;
            this.Descend = Descend;
            this.Points = Points;
            this.PointsEncoded = PointsEncoded;
            this.Bbox = Bbox;
            this.SnappedWaypoints = SnappedWaypoints;
            this.Instructions = Instructions;
        }
        
        /// <summary>
        /// The total distance of the route, in meter
        /// </summary>
        /// <value>The total distance of the route, in meter</value>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public double? Distance { get; set; }

        /// <summary>
        /// The total time of the route, in ms
        /// </summary>
        /// <value>The total time of the route, in ms</value>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public long? Time { get; set; }

        /// <summary>
        /// Gets or Sets Ascend
        /// </summary>
        [DataMember(Name="ascend", EmitDefaultValue=false)]
        public double? Ascend { get; set; }

        /// <summary>
        /// The total descend (downhill) of the route, in meter
        /// </summary>
        /// <value>The total descend (downhill) of the route, in meter</value>
        [DataMember(Name="descend", EmitDefaultValue=false)]
        public double? Descend { get; set; }

        /// <summary>
        /// Gets or Sets Points
        /// </summary>
        [DataMember(Name="points", EmitDefaultValue=false)]
        public ResponseCoordinates Points { get; set; }

        /// <summary>
        /// Is true if the points are encoded, if not paths[0].points contains the geo json of the path (then order is lon,lat,elevation), which is easier to handle but consumes more bandwidth compared to encoded version
        /// </summary>
        /// <value>Is true if the points are encoded, if not paths[0].points contains the geo json of the path (then order is lon,lat,elevation), which is easier to handle but consumes more bandwidth compared to encoded version</value>
        [DataMember(Name="points_encoded", EmitDefaultValue=false)]
        public bool? PointsEncoded { get; set; }

        /// <summary>
        /// The bounding box of the route, format &lt;br&gt; minLon, minLat, maxLon, maxLat
        /// </summary>
        /// <value>The bounding box of the route, format &lt;br&gt; minLon, minLat, maxLon, maxLat</value>
        [DataMember(Name="bbox", EmitDefaultValue=false)]
        public List<double?> Bbox { get; set; }

        /// <summary>
        /// Gets or Sets SnappedWaypoints
        /// </summary>
        [DataMember(Name="snapped_waypoints", EmitDefaultValue=false)]
        public ResponseCoordinates SnappedWaypoints { get; set; }

        /// <summary>
        /// Gets or Sets Instructions
        /// </summary>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public ResponseInstructions Instructions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteResponsePath {\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Ascend: ").Append(Ascend).Append("\n");
            sb.Append("  Descend: ").Append(Descend).Append("\n");
            sb.Append("  Points: ").Append(Points).Append("\n");
            sb.Append("  PointsEncoded: ").Append(PointsEncoded).Append("\n");
            sb.Append("  Bbox: ").Append(Bbox).Append("\n");
            sb.Append("  SnappedWaypoints: ").Append(SnappedWaypoints).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RouteResponsePath);
        }

        /// <summary>
        /// Returns true if RouteResponsePath instances are equal
        /// </summary>
        /// <param name="input">Instance of RouteResponsePath to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteResponsePath input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Ascend == input.Ascend ||
                    (this.Ascend != null &&
                    this.Ascend.Equals(input.Ascend))
                ) && 
                (
                    this.Descend == input.Descend ||
                    (this.Descend != null &&
                    this.Descend.Equals(input.Descend))
                ) && 
                (
                    this.Points == input.Points ||
                    (this.Points != null &&
                    this.Points.Equals(input.Points))
                ) && 
                (
                    this.PointsEncoded == input.PointsEncoded ||
                    (this.PointsEncoded != null &&
                    this.PointsEncoded.Equals(input.PointsEncoded))
                ) && 
                (
                    this.Bbox == input.Bbox ||
                    this.Bbox != null &&
                    this.Bbox.SequenceEqual(input.Bbox)
                ) && 
                (
                    this.SnappedWaypoints == input.SnappedWaypoints ||
                    (this.SnappedWaypoints != null &&
                    this.SnappedWaypoints.Equals(input.SnappedWaypoints))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Ascend != null)
                    hashCode = hashCode * 59 + this.Ascend.GetHashCode();
                if (this.Descend != null)
                    hashCode = hashCode * 59 + this.Descend.GetHashCode();
                if (this.Points != null)
                    hashCode = hashCode * 59 + this.Points.GetHashCode();
                if (this.PointsEncoded != null)
                    hashCode = hashCode * 59 + this.PointsEncoded.GetHashCode();
                if (this.Bbox != null)
                    hashCode = hashCode * 59 + this.Bbox.GetHashCode();
                if (this.SnappedWaypoints != null)
                    hashCode = hashCode * 59 + this.SnappedWaypoints.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
