// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters for a docker quick build.
    /// </summary>
    [Newtonsoft.Json.JsonObject("DockerBuildRequest")]
    public partial class DockerBuildRequest : RunRequest
    {
        /// <summary>
        /// Initializes a new instance of the DockerBuildRequest class.
        /// </summary>
        public DockerBuildRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DockerBuildRequest class.
        /// </summary>
        /// <param name="dockerFilePath">The Docker file path relative to the
        /// source location.</param>
        /// <param name="platform">The platform properties against which the
        /// run has to happen.</param>
        /// <param name="isArchiveEnabled">The value that indicates whether
        /// archiving is enabled for the run or not.</param>
        /// <param name="imageNames">The fully qualified image names including
        /// the repository and tag.</param>
        /// <param name="isPushEnabled">The value of this property indicates
        /// whether the image built should be pushed to the registry or
        /// not.</param>
        /// <param name="noCache">The value of this property indicates whether
        /// the image cache is enabled or not.</param>
        /// <param name="target">The name of the target build stage for the
        /// docker build.</param>
        /// <param name="arguments">The collection of override arguments to be
        /// used when executing the run.</param>
        /// <param name="timeout">Run timeout in seconds.</param>
        /// <param name="agentConfiguration">The machine configuration of the
        /// run agent.</param>
        /// <param name="sourceLocation">The URL(absolute or relative) of the
        /// source context. It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from
        /// calling listBuildSourceUploadUrl API.</param>
        /// <param name="credentials">The properties that describes a set of
        /// credentials that will be used when this run is invoked.</param>
        public DockerBuildRequest(string dockerFilePath, PlatformProperties platform, bool? isArchiveEnabled = default(bool?), IList<string> imageNames = default(IList<string>), bool? isPushEnabled = default(bool?), bool? noCache = default(bool?), string target = default(string), IList<Argument> arguments = default(IList<Argument>), int? timeout = default(int?), AgentProperties agentConfiguration = default(AgentProperties), string sourceLocation = default(string), Credentials credentials = default(Credentials))
            : base(isArchiveEnabled)
        {
            ImageNames = imageNames;
            IsPushEnabled = isPushEnabled;
            NoCache = noCache;
            DockerFilePath = dockerFilePath;
            Target = target;
            Arguments = arguments;
            Timeout = timeout;
            Platform = platform;
            AgentConfiguration = agentConfiguration;
            SourceLocation = sourceLocation;
            Credentials = credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the fully qualified image names including the
        /// repository and tag.
        /// </summary>
        [JsonProperty(PropertyName = "imageNames")]
        public IList<string> ImageNames { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// built should be pushed to the registry or not.
        /// </summary>
        [JsonProperty(PropertyName = "isPushEnabled")]
        public bool? IsPushEnabled { get; set; }

        /// <summary>
        /// Gets or sets the value of this property indicates whether the image
        /// cache is enabled or not.
        /// </summary>
        [JsonProperty(PropertyName = "noCache")]
        public bool? NoCache { get; set; }

        /// <summary>
        /// Gets or sets the Docker file path relative to the source location.
        /// </summary>
        [JsonProperty(PropertyName = "dockerFilePath")]
        public string DockerFilePath { get; set; }

        /// <summary>
        /// Gets or sets the name of the target build stage for the docker
        /// build.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the collection of override arguments to be used when
        /// executing the run.
        /// </summary>
        [JsonProperty(PropertyName = "arguments")]
        public IList<Argument> Arguments { get; set; }

        /// <summary>
        /// Gets or sets run timeout in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the platform properties against which the run has to
        /// happen.
        /// </summary>
        [JsonProperty(PropertyName = "platform")]
        public PlatformProperties Platform { get; set; }

        /// <summary>
        /// Gets or sets the machine configuration of the run agent.
        /// </summary>
        [JsonProperty(PropertyName = "agentConfiguration")]
        public AgentProperties AgentConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the URL(absolute or relative) of the source context.
        /// It can be an URL to a tar or git repository.
        /// If it is relative URL, the relative path should be obtained from
        /// calling listBuildSourceUploadUrl API.
        /// </summary>
        [JsonProperty(PropertyName = "sourceLocation")]
        public string SourceLocation { get; set; }

        /// <summary>
        /// Gets or sets the properties that describes a set of credentials
        /// that will be used when this run is invoked.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public Credentials Credentials { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DockerFilePath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DockerFilePath");
            }
            if (Platform == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Platform");
            }
            if (Arguments != null)
            {
                foreach (var element in Arguments)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Timeout != null)
            {
                if (Timeout > 28800)
                {
                    throw new ValidationException(ValidationRules.InclusiveMaximum, "Timeout", 28800);
                }
                if (Timeout < 300)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "Timeout", 300);
                }
            }
            if (Platform != null)
            {
                Platform.Validate();
            }
        }
    }
}
