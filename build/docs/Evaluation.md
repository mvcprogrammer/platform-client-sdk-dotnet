---
title: Evaluation
---
## ININ.PureCloudApi.Model.Evaluation

## Properties

|Name | Type | Description | Notes|
|------------ | ------------- | ------------- | -------------|
| **Id** | **string** | The globally unique identifier for the object. | [optional] |
| **Name** | **string** |  | [optional] |
| **Conversation** | [**ConversationReference**](ConversationReference.html) |  | [optional] |
| **EvaluationForm** | [**EvaluationForm**](EvaluationForm.html) | Evaluation form used for evaluation. | [optional] |
| **Evaluator** | [**User**](User.html) |  | [optional] |
| **Agent** | [**User**](User.html) |  | [optional] |
| **Calibration** | [**Calibration**](Calibration.html) |  | [optional] |
| **Status** | **string** |  | [optional] |
| **Answers** | [**EvaluationScoringSet**](EvaluationScoringSet.html) |  | [optional] |
| **AgentHasRead** | **bool?** |  | [optional] |
| **ReleaseDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **AssignedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ChangedDate** | **DateTime?** | Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **Queue** | [**Queue**](Queue.html) |  | [optional] |
| **MediaType** | **List&lt;string&gt;** | List of different communication types used in conversation. | [optional] |
| **Rescore** | **bool?** | Is only true when evaluation is re-scored. | [optional] |
| **ConversationDate** | **DateTime?** | Date of conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **ConversationEndDate** | **DateTime?** | End date of conversation if it had completed before evaluation creation. Null if created before the conversation ended. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z | [optional] |
| **NeverRelease** | **bool?** | Signifies if the evaluation is never to be released. This cannot be set true if release date is also set. | [optional] |
| **ResourceId** | **string** | Only used for email evaluations. Will be null for all other evaluations. | [optional] |
| **ResourceType** | **string** | The type of resource. Only used for email evaluations. Will be null for evaluations on all other resources. | [optional] |
| **Redacted** | **bool?** | Is only true when the user making the request does not have sufficient permissions to see evaluation | [optional] |
| **IsScoringIndex** | **bool?** |  | [optional] |
| **AuthorizedActions** | **List&lt;string&gt;** | List of user authorized actions on evaluation. Possible values: edit, editScore, editAgentSignoff, delete, viewAudit | [optional] |
| **HasAssistanceFailed** | **bool?** | Is true when evaluation assistance didn&#39;t execute successfully | [optional] |
| **SelfUri** | **string** | The URI for this object | [optional] |
{: class="table table-striped"}


