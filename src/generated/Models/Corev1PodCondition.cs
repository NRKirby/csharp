// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// PodCondition contains details for the current condition of this pod.
    /// </summary>
    public partial class Corev1PodCondition
    {
        /// <summary>
        /// Initializes a new instance of the Corev1PodCondition class.
        /// </summary>
        public Corev1PodCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Corev1PodCondition class.
        /// </summary>
        /// <param name="status">Status is the status of the condition. Can be
        /// True, False, Unknown. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</param>
        /// <param name="type">Type is the type of the condition. Currently
        /// only Ready. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions</param>
        /// <param name="lastProbeTime">Last time we probed the
        /// condition.</param>
        /// <param name="lastTransitionTime">Last time the condition
        /// transitioned from one status to another.</param>
        /// <param name="message">Human-readable message indicating details
        /// about last transition.</param>
        /// <param name="reason">Unique, one-word, CamelCase reason for the
        /// condition's last transition.</param>
        public Corev1PodCondition(string status, string type, System.DateTime? lastProbeTime = default(System.DateTime?), System.DateTime? lastTransitionTime = default(System.DateTime?), string message = default(string), string reason = default(string))
        {
            LastProbeTime = lastProbeTime;
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets last time we probed the condition.
        /// </summary>
        [JsonProperty(PropertyName = "lastProbeTime")]
        public System.DateTime? LastProbeTime { get; set; }

        /// <summary>
        /// Gets or sets last time the condition transitioned from one status
        /// to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets human-readable message indicating details about last
        /// transition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets unique, one-word, CamelCase reason for the condition's
        /// last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets status is the status of the condition. Can be True,
        /// False, Unknown. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets type is the type of the condition. Currently only
        /// Ready. More info:
        /// https://kubernetes.io/docs/concepts/workloads/pods/pod-lifecycle#pod-conditions
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}