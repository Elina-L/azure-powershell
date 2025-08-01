// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This is the data disk image.
    /// </summary>
    public partial class GalleryDataDiskImage : GalleryDiskImage
    {
        /// <summary>
        /// Initializes a new instance of the GalleryDataDiskImage class.
        /// </summary>
        public GalleryDataDiskImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GalleryDataDiskImage class.
        /// </summary>
        /// <param name="lun">This property specifies the logical unit number
        /// of the data disk. This value is used to identify data disks within
        /// the Virtual Machine and therefore must be unique for each data disk
        /// attached to the Virtual Machine.</param>
        /// <param name="sizeInGB">This property indicates the size of the VHD
        /// to be created.</param>
        /// <param name="hostCaching">The host caching of the disk. Valid
        /// values are 'None', 'ReadOnly', and 'ReadWrite'. Possible values
        /// include: 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="source">The source for the disk image.</param>
        public GalleryDataDiskImage(int lun, int? sizeInGB = default(int?), HostCaching? hostCaching = default(HostCaching?), GalleryDiskImageSource source = default(GalleryDiskImageSource))
            : base(sizeInGB, hostCaching, source)
        {
            Lun = lun;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this property specifies the logical unit number of the
        /// data disk. This value is used to identify data disks within the
        /// Virtual Machine and therefore must be unique for each data disk
        /// attached to the Virtual Machine.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
