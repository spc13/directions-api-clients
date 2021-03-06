# IO.Swagger.Model.Vehicle
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VehicleId** | **string** | Unique identifier of vehicle | [optional] 
**TypeId** | **string** | Unique identifier referring to the available vehicle types | [optional] 
**StartAddress** | [**Address**](Address.md) |  | [optional] 
**EndAddress** | [**Address**](Address.md) |  | [optional] 
**Break** | [**Break**](Break.md) |  | [optional] 
**ReturnToDepot** | **bool?** | Indicates whether vehicle should return to start address or not. If not, it can end at any service activity. | [optional] 
**EarliestStart** | **long?** | earliest start of vehicle at its start location | [optional] 
**LatestEnd** | **long?** | latest end of vehicle at its end location | [optional] 
**Skills** | **List&lt;string&gt;** | array of skills | [optional] 
**MaxDistance** | **long?** | max distance of vehicle | [optional] 
**MaxDrivingTime** | **long?** | max drive time of vehicle | [optional] 
**MaxJobs** | **int?** | max number of jobs the vehicle can load | [optional] 
**MaxActivities** | **int?** | max number of activities the vehicle can conduct | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

