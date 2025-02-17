---
title: WebDeployment
---
## ININ.PureCloudApi.Model.WebDeployment

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The deployment ID | [optional] |
| **Name** | **string** | The deployment name | |
| **Description** | **string** | The description of the config | [optional] |
| **Configuration** | [**WebDeploymentConfigurationVersionEntityRef**](WebDeploymentConfigurationVersionEntityRef.html) | The config version this deployment uses | |
| **AllowAllDomains** | **bool?** | Property indicates whether all domains are allowed or not. allowedDomains must be empty when this is set as true. | [optional] |
| **AllowedDomains** | **List&lt;string&gt;** | The list of domains that are approved to use this deployment; the list will be added to CORS headers for ease of web use. | [optional] |
| **Snippet** | **string** | Javascript snippet used to load the config | [optional] |
| **DateCreated** | **DateTime?** | The date the deployment was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **DateModified** | **DateTime?** | The date the deployment was most recently modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **LastModifiedUser** | [**AddressableEntityRef**](AddressableEntityRef.html) | A reference to the user who most recently modified the deployment | [optional] |
| **Flow** | [**DomainEntityRef**](DomainEntityRef.html) | A reference to the inboundshortmessage flow used by this deployment | [optional] |
| **Status** | **string** | The current status of the deployment | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


