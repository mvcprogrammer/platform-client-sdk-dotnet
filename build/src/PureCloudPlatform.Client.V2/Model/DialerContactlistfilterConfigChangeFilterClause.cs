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
    /// DialerContactlistfilterConfigChangeFilterClause
    /// </summary>
    [DataContract]
    public partial class DialerContactlistfilterConfigChangeFilterClause :  IEquatable<DialerContactlistfilterConfigChangeFilterClause>
    {
        /// <summary>
        /// Contact list filter type
        /// </summary>
        /// <value>Contact list filter type</value>
        [JsonConverter(typeof(UpgradeSdkEnumConverter))]
        public enum FilterTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum And for "AND"
            /// </summary>
            [EnumMember(Value = "AND")]
            And,
            
            /// <summary>
            /// Enum Or for "OR"
            /// </summary>
            [EnumMember(Value = "OR")]
            Or
        }
        /// <summary>
        /// Contact list filter type
        /// </summary>
        /// <value>Contact list filter type</value>
        [DataMember(Name="filterType", EmitDefaultValue=false)]
        public FilterTypeEnum? FilterType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DialerContactlistfilterConfigChangeFilterClause" /> class.
        /// </summary>
        /// <param name="FilterType">Contact list filter type.</param>
        /// <param name="Predicates">The list of predicates in that clause.</param>
        public DialerContactlistfilterConfigChangeFilterClause(FilterTypeEnum? FilterType = null, List<DialerContactlistfilterConfigChangeFilterPredicate> Predicates = null)
        {
            this.FilterType = FilterType;
            this.Predicates = Predicates;
            
        }
        




        /// <summary>
        /// The list of predicates in that clause
        /// </summary>
        /// <value>The list of predicates in that clause</value>
        [DataMember(Name="predicates", EmitDefaultValue=false)]
        public List<DialerContactlistfilterConfigChangeFilterPredicate> Predicates { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DialerContactlistfilterConfigChangeFilterClause {\n");

            sb.Append("  FilterType: ").Append(FilterType).Append("\n");
            sb.Append("  Predicates: ").Append(Predicates).Append("\n");
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
            return this.Equals(obj as DialerContactlistfilterConfigChangeFilterClause);
        }

        /// <summary>
        /// Returns true if DialerContactlistfilterConfigChangeFilterClause instances are equal
        /// </summary>
        /// <param name="other">Instance of DialerContactlistfilterConfigChangeFilterClause to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DialerContactlistfilterConfigChangeFilterClause other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.FilterType == other.FilterType ||
                    this.FilterType != null &&
                    this.FilterType.Equals(other.FilterType)
                ) &&
                (
                    this.Predicates == other.Predicates ||
                    this.Predicates != null &&
                    this.Predicates.SequenceEqual(other.Predicates)
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
                if (this.FilterType != null)
                    hash = hash * 59 + this.FilterType.GetHashCode();

                if (this.Predicates != null)
                    hash = hash * 59 + this.Predicates.GetHashCode();

                return hash;
            }
        }
    }

}
