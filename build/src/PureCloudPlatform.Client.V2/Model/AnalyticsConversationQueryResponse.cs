using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using PureCloudPlatform.Client.V2.Client;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// AnalyticsConversationQueryResponse
    /// </summary>
    [DataContract]
    public partial class AnalyticsConversationQueryResponse :  IEquatable<AnalyticsConversationQueryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnalyticsConversationQueryResponse" /> class.
        /// </summary>
        /// <param name="Aggregations">Aggregations.</param>
        /// <param name="Conversations">Conversations.</param>
        /// <param name="TotalHits">TotalHits.</param>
        public AnalyticsConversationQueryResponse(List<AggregationResult> Aggregations = null, List<AnalyticsConversationWithoutAttributes> Conversations = null, int? TotalHits = null)
        {
            this.Aggregations = Aggregations;
            this.Conversations = Conversations;
            this.TotalHits = TotalHits;
            
        }
        


        /// <summary>
        /// Gets or Sets Aggregations
        /// </summary>
        [DataMember(Name="aggregations", EmitDefaultValue=false)]
        public List<AggregationResult> Aggregations { get; set; }



        /// <summary>
        /// Gets or Sets Conversations
        /// </summary>
        [DataMember(Name="conversations", EmitDefaultValue=false)]
        public List<AnalyticsConversationWithoutAttributes> Conversations { get; set; }



        /// <summary>
        /// Gets or Sets TotalHits
        /// </summary>
        [DataMember(Name="totalHits", EmitDefaultValue=false)]
        public int? TotalHits { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnalyticsConversationQueryResponse {\n");

            sb.Append("  Aggregations: ").Append(Aggregations).Append("\n");
            sb.Append("  Conversations: ").Append(Conversations).Append("\n");
            sb.Append("  TotalHits: ").Append(TotalHits).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                Formatting = Formatting.Indented
            });
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AnalyticsConversationQueryResponse);
        }

        /// <summary>
        /// Returns true if AnalyticsConversationQueryResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of AnalyticsConversationQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnalyticsConversationQueryResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Aggregations == other.Aggregations ||
                    this.Aggregations != null &&
                    this.Aggregations.SequenceEqual(other.Aggregations)
                ) &&
                (
                    this.Conversations == other.Conversations ||
                    this.Conversations != null &&
                    this.Conversations.SequenceEqual(other.Conversations)
                ) &&
                (
                    this.TotalHits == other.TotalHits ||
                    this.TotalHits != null &&
                    this.TotalHits.Equals(other.TotalHits)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Aggregations != null)
                    hash = hash * 59 + this.Aggregations.GetHashCode();

                if (this.Conversations != null)
                    hash = hash * 59 + this.Conversations.GetHashCode();

                if (this.TotalHits != null)
                    hash = hash * 59 + this.TotalHits.GetHashCode();

                return hash;
            }
        }
    }

}
