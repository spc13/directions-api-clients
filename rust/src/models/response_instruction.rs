/* 
 * GraphHopper Directions API
 *
 * You use the GraphHopper Directions API to add route planning, navigation and route optimization to your software. E.g. the Routing API has turn instructions and elevation data and the Route Optimization API solves your logistic problems and supports various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


#[allow(unused_imports)]
use serde_json::Value;

#[derive(Debug, Serialize, Deserialize)]
pub struct ResponseInstruction {
  /// A description what the user has to do in order to follow the route. The language depends on the locale parameter.
  #[serde(rename = "text")]
  text: Option<String>,
  /// The name of the street to turn onto in order to follow the route.
  #[serde(rename = "street_name")]
  street_name: Option<String>,
  /// The distance for this instruction, in meter
  #[serde(rename = "distance")]
  distance: Option<f64>,
  /// The duration for this instruction, in ms
  #[serde(rename = "time")]
  time: Option<i32>,
  /// An array containing the first and the last index (relative to paths[0].points) of the points for this instruction. This is useful to know for which part of the route the instructions are valid.
  #[serde(rename = "interval")]
  interval: Option<Vec<i32>>,
  /// A number which specifies the sign to show e.g. for right turn etc <br>TURN_SHARP_LEFT = -3<br>TURN_LEFT = -2<br>TURN_SLIGHT_LEFT = -1<br>CONTINUE_ON_STREET = 0<br>TURN_SLIGHT_RIGHT = 1<br>TURN_RIGHT = 2<br>TURN_SHARP_RIGHT = 3<br>FINISH = 4<br>VIA_REACHED = 5<br>USE_ROUNDABOUT = 6
  #[serde(rename = "sign")]
  sign: Option<i32>,
  /// optional - A text describing the instruction in more detail, e.g. like surface of the way, warnings or involved costs.
  #[serde(rename = "annotation_text")]
  annotation_text: Option<String>,
  /// optional - 0 stands for INFO, 1 for warning, 2 for costs, 3 for costs and warning
  #[serde(rename = "annotation_importance")]
  annotation_importance: Option<i32>,
  /// optional - Only available for USE_ROUNDABOUT instructions. The count of exits at which the route leaves the roundabout.
  #[serde(rename = "exit_number")]
  exit_number: Option<i32>,
  /// optional - Only available for USE_ROUNDABOUT instructions. The radian of the route within the roundabout - 0&lt;r&lt;2*PI for clockwise and -2PI&lt;r&lt;0 for counterclockwise transit. Null if the direction of rotation is undefined.
  #[serde(rename = "turn_angle")]
  turn_angle: Option<f64>
}

impl ResponseInstruction {
  pub fn new() -> ResponseInstruction {
    ResponseInstruction {
      text: None,
      street_name: None,
      distance: None,
      time: None,
      interval: None,
      sign: None,
      annotation_text: None,
      annotation_importance: None,
      exit_number: None,
      turn_angle: None
    }
  }

  pub fn set_text(&mut self, text: String) {
    self.text = Some(text);
  }

  pub fn with_text(mut self, text: String) -> ResponseInstruction {
    self.text = Some(text);
    self
  }

  pub fn text(&self) -> Option<&String> {
    self.text.as_ref()
  }

  pub fn reset_text(&mut self) {
    self.text = None;
  }

  pub fn set_street_name(&mut self, street_name: String) {
    self.street_name = Some(street_name);
  }

  pub fn with_street_name(mut self, street_name: String) -> ResponseInstruction {
    self.street_name = Some(street_name);
    self
  }

  pub fn street_name(&self) -> Option<&String> {
    self.street_name.as_ref()
  }

  pub fn reset_street_name(&mut self) {
    self.street_name = None;
  }

  pub fn set_distance(&mut self, distance: f64) {
    self.distance = Some(distance);
  }

  pub fn with_distance(mut self, distance: f64) -> ResponseInstruction {
    self.distance = Some(distance);
    self
  }

  pub fn distance(&self) -> Option<&f64> {
    self.distance.as_ref()
  }

  pub fn reset_distance(&mut self) {
    self.distance = None;
  }

  pub fn set_time(&mut self, time: i32) {
    self.time = Some(time);
  }

  pub fn with_time(mut self, time: i32) -> ResponseInstruction {
    self.time = Some(time);
    self
  }

  pub fn time(&self) -> Option<&i32> {
    self.time.as_ref()
  }

  pub fn reset_time(&mut self) {
    self.time = None;
  }

  pub fn set_interval(&mut self, interval: Vec<i32>) {
    self.interval = Some(interval);
  }

  pub fn with_interval(mut self, interval: Vec<i32>) -> ResponseInstruction {
    self.interval = Some(interval);
    self
  }

  pub fn interval(&self) -> Option<&Vec<i32>> {
    self.interval.as_ref()
  }

  pub fn reset_interval(&mut self) {
    self.interval = None;
  }

  pub fn set_sign(&mut self, sign: i32) {
    self.sign = Some(sign);
  }

  pub fn with_sign(mut self, sign: i32) -> ResponseInstruction {
    self.sign = Some(sign);
    self
  }

  pub fn sign(&self) -> Option<&i32> {
    self.sign.as_ref()
  }

  pub fn reset_sign(&mut self) {
    self.sign = None;
  }

  pub fn set_annotation_text(&mut self, annotation_text: String) {
    self.annotation_text = Some(annotation_text);
  }

  pub fn with_annotation_text(mut self, annotation_text: String) -> ResponseInstruction {
    self.annotation_text = Some(annotation_text);
    self
  }

  pub fn annotation_text(&self) -> Option<&String> {
    self.annotation_text.as_ref()
  }

  pub fn reset_annotation_text(&mut self) {
    self.annotation_text = None;
  }

  pub fn set_annotation_importance(&mut self, annotation_importance: i32) {
    self.annotation_importance = Some(annotation_importance);
  }

  pub fn with_annotation_importance(mut self, annotation_importance: i32) -> ResponseInstruction {
    self.annotation_importance = Some(annotation_importance);
    self
  }

  pub fn annotation_importance(&self) -> Option<&i32> {
    self.annotation_importance.as_ref()
  }

  pub fn reset_annotation_importance(&mut self) {
    self.annotation_importance = None;
  }

  pub fn set_exit_number(&mut self, exit_number: i32) {
    self.exit_number = Some(exit_number);
  }

  pub fn with_exit_number(mut self, exit_number: i32) -> ResponseInstruction {
    self.exit_number = Some(exit_number);
    self
  }

  pub fn exit_number(&self) -> Option<&i32> {
    self.exit_number.as_ref()
  }

  pub fn reset_exit_number(&mut self) {
    self.exit_number = None;
  }

  pub fn set_turn_angle(&mut self, turn_angle: f64) {
    self.turn_angle = Some(turn_angle);
  }

  pub fn with_turn_angle(mut self, turn_angle: f64) -> ResponseInstruction {
    self.turn_angle = Some(turn_angle);
    self
  }

  pub fn turn_angle(&self) -> Option<&f64> {
    self.turn_angle.as_ref()
  }

  pub fn reset_turn_angle(&mut self) {
    self.turn_angle = None;
  }

}



