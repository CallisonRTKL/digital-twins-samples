// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace ADTApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A model definition and metadata for that model.
    /// </summary>
    public partial class ModelData
    {
        /// <summary>
        /// Initializes a new instance of the ModelData class.
        /// </summary>
        public ModelData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelData class.
        /// </summary>
        /// <param name="id">The id of the model as specified in the model
        /// definition.</param>
        /// <param name="displayName">The display name of the model as
        /// specified in the model definition.</param>
        /// <param name="uploadTime">The time the model was uploaded to the
        /// service.</param>
        /// <param name="serviceOrigin">The service which originated this
        /// model. This indicates if the model was uploaded to the service or
        /// was discovered via a device in IoT Hub. Models from IoT Hub may
        /// change at any time and it is recommended they are only used for
        /// creation of proxy twins.</param>
        /// <param name="resolveSource">The repository from which this model
        /// was taken from. This value is always fixed for models uploaded
        /// directly to this service.</param>
        /// <param name="decommissioned">Indicates if the model is
        /// decommissioned. Decommissioned models cannot be referenced by newly
        /// created digital twins.</param>
        /// <param name="model">The model definition.</param>
        public ModelData(string id, string displayName = default(string), System.DateTime? uploadTime = default(System.DateTime?), string serviceOrigin = default(string), string resolveSource = default(string), bool? decommissioned = default(bool?), object model = default(object))
        {
            DisplayName = displayName;
            Id = id;
            UploadTime = uploadTime;
            ServiceOrigin = serviceOrigin;
            ResolveSource = resolveSource;
            Decommissioned = decommissioned;
            Model = model;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the model as specified in the
        /// model definition.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the id of the model as specified in the model
        /// definition.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the time the model was uploaded to the service.
        /// </summary>
        [JsonProperty(PropertyName = "uploadTime")]
        public System.DateTime? UploadTime { get; set; }

        /// <summary>
        /// Gets or sets the service which originated this model. This
        /// indicates if the model was uploaded to the service or was
        /// discovered via a device in IoT Hub. Models from IoT Hub may change
        /// at any time and it is recommended they are only used for creation
        /// of proxy twins.
        /// </summary>
        [JsonProperty(PropertyName = "serviceOrigin")]
        public string ServiceOrigin { get; set; }

        /// <summary>
        /// Gets or sets the repository from which this model was taken from.
        /// This value is always fixed for models uploaded directly to this
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "resolveSource")]
        public string ResolveSource { get; set; }

        /// <summary>
        /// Gets or sets indicates if the model is decommissioned.
        /// Decommissioned models cannot be referenced by newly created digital
        /// twins.
        /// </summary>
        [JsonProperty(PropertyName = "decommissioned")]
        public bool? Decommissioned { get; set; }

        /// <summary>
        /// Gets or sets the model definition.
        /// </summary>
        [JsonProperty(PropertyName = "model")]
        public object Model { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
        }
    }
}
