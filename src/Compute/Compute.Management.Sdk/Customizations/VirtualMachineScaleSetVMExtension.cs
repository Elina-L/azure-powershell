﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSetVMExtension : SubResourceReadOnly
    {
        public VirtualMachineScaleSetVMExtension(string name, string type, string forceUpdateTag, string publisher = default(string), string virtualMachineExtensionPropertiesType = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), bool? enableAutomaticUpgrade = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string), VirtualMachineExtensionInstanceView instanceView = default(VirtualMachineExtensionInstanceView), bool? suppressFailures = default(bool?), KeyVaultSecretReference protectedSettingsFromKeyVault = default(KeyVaultSecretReference))
        {
            Name = name;
            Type = type;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            VirtualMachineExtensionPropertiesType = virtualMachineExtensionPropertiesType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            EnableAutomaticUpgrade = enableAutomaticUpgrade;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            SuppressFailures = suppressFailures;
            ProtectedSettingsFromKeyVault = protectedSettingsFromKeyVault;
            CustomInit();
        }

        public VirtualMachineScaleSetVMExtension(string id = default(string), string name = default(string), string type = default(string), string location = default(string), string forceUpdateTag = default(string), string publisher = default(string), string virtualMachineExtensionPropertiesType = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), bool? enableAutomaticUpgrade = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string), VirtualMachineExtensionInstanceView instanceView = default(VirtualMachineExtensionInstanceView), bool? suppressFailures = default(bool?), KeyVaultSecretReference protectedSettingsFromKeyVault = default(KeyVaultSecretReference))
            : base(id)
        {
            Name = name;
            Type = type;
            Location = location;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            VirtualMachineExtensionPropertiesType = virtualMachineExtensionPropertiesType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            EnableAutomaticUpgrade = enableAutomaticUpgrade;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            SuppressFailures = suppressFailures;
            ProtectedSettingsFromKeyVault = protectedSettingsFromKeyVault;
            CustomInit();
        }

        public VirtualMachineScaleSetVMExtension(string id, string name, string type, string forceUpdateTag, string publisher = default(string), string virtualMachineExtensionPropertiesType = default(string), string typeHandlerVersion = default(string), bool? autoUpgradeMinorVersion = default(bool?), bool? enableAutomaticUpgrade = default(bool?), object settings = default(object), object protectedSettings = default(object), string provisioningState = default(string), VirtualMachineExtensionInstanceView instanceView = default(VirtualMachineExtensionInstanceView), bool? suppressFailures = default(bool?), KeyVaultSecretReference protectedSettingsFromKeyVault = default(KeyVaultSecretReference))
            : base(id)
        {
            Name = name;
            Type = type;
            ForceUpdateTag = forceUpdateTag;
            Publisher = publisher;
            VirtualMachineExtensionPropertiesType = virtualMachineExtensionPropertiesType;
            TypeHandlerVersion = typeHandlerVersion;
            AutoUpgradeMinorVersion = autoUpgradeMinorVersion;
            EnableAutomaticUpgrade = enableAutomaticUpgrade;
            Settings = settings;
            ProtectedSettings = protectedSettings;
            ProvisioningState = provisioningState;
            InstanceView = instanceView;
            SuppressFailures = suppressFailures;
            ProtectedSettingsFromKeyVault = protectedSettingsFromKeyVault;
            CustomInit();
        }
    }
}