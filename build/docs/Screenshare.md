---
title: Screenshare
---
## ININ.PureCloudApi.Model.Screenshare

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **State** | **string** | The connection state of this communication. | [optional] |
| **Id** | **string** | A globally unique identifier for this communication. | [optional] |
| **Context** | **string** | The room id context (xmpp jid) for the conference session. | [optional] |
| **Sharing** | **bool?** | Indicates whether this participant is sharing their screen. | [optional] |
| **PeerCount** | **int?** | The number of peer participants from the perspective of the participant in the conference. | [optional] |
| **DisconnectType** | **string** | System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects. | [optional] |
| **StartAlertingTime** | **DateTime?** | The timestamp the communication has when it is first put into an alerting state. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConnectedTime** | **DateTime?** | The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DisconnectedTime** | **DateTime?** | The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Provider** | **string** | The source provider for the screen share. | [optional] |
| **PeerId** | **string** | The id of the peer communication corresponding to a matching leg for this communication. | [optional] |
| **Segments** | [**List&lt;Segment&gt;**](Segment.html) | The time line of the participant&#39;s call, divided into activity segments. | [optional] |
| **Wrapup** | [**Wrapup**](Wrapup.html) | Call wrap up or disposition data. | [optional] |
| **AfterCallWork** | [**AfterCallWork**](AfterCallWork.html) | After-call work for the communication. | [optional] |
| **AfterCallWorkRequired** | **bool?** | Indicates if after-call work is required for a communication. Only used when the ACW Setting is Agent Requested. | [optional] |
| **InitialState** | **string** | The initial connection state of this communication. | [optional] |
{: class="table table-striped"}


