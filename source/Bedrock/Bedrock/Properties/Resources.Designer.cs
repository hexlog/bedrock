﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bedrock.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Bedrock.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The object must be of type &apos;{0}&apos; in order to use the current region adapter..
        /// </summary>
        internal static string AdapterInvalidTypeException {
            get {
                return ResourceManager.GetString("AdapterInvalidTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot change the region name once is set. The current region name is &apos;{0}&apos;..
        /// </summary>
        internal static string CannotChangeRegionNameException {
            get {
                return ResourceManager.GetString("CannotChangeRegionNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot create navigation target &apos;{0}&apos;..
        /// </summary>
        internal static string CannotCreateNavigationTarget {
            get {
                return ResourceManager.GetString("CannotCreateNavigationTarget", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Can&apos;t find name property for this control!.
        /// </summary>
        internal static string CannotFindNameProperty {
            get {
                return ResourceManager.GetString("CannotFindNameProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Type &apos;{0}&apos; does not implement from IRegionBehavior..
        /// </summary>
        internal static string CanOnlyAddTypesThatInheritIFromRegionBehavior {
            get {
                return ResourceManager.GetString("CanOnlyAddTypesThatInheritIFromRegionBehavior", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ConfigurationStore cannot contain a null value. .
        /// </summary>
        internal static string ConfigurationStoreCannotBeNull {
            get {
                return ResourceManager.GetString("ConfigurationStoreCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ContentControl&apos;s Content property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s Content property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string ContentControlHasContentException {
            get {
                return ResourceManager.GetString("ContentControlHasContentException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to At least one cyclic dependency has been found in the module catalog. Cycles in the module dependencies must be avoided..
        /// </summary>
        internal static string CyclicDependencyFound {
            get {
                return ResourceManager.GetString("CyclicDependencyFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Deactivation is not possible in this type of region..
        /// </summary>
        internal static string DeactiveNotPossibleException {
            get {
                return ResourceManager.GetString("DeactiveNotPossibleException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {1}: {2}. Priority: {3}. Timestamp:{0:u}..
        /// </summary>
        internal static string DefaultTextLoggerPattern {
            get {
                return ResourceManager.GetString("DefaultTextLoggerPattern", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Neither the executeMethod nor the canExecuteMethod delegates can be null..
        /// </summary>
        internal static string DelegateCommandDelegatesCannotBeNull {
            get {
                return ResourceManager.GetString("DelegateCommandDelegatesCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to T for DelegateCommand&lt;T&gt; is not an object nor Nullable..
        /// </summary>
        internal static string DelegateCommandInvalidGenericPayloadType {
            get {
                return ResourceManager.GetString("DelegateCommandInvalidGenericPayloadType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot add dependency for unknown module {0}.
        /// </summary>
        internal static string DependencyForUnknownModule {
            get {
                return ResourceManager.GetString("DependencyForUnknownModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A module declared a dependency on another module which is not declared to be loaded. Missing module(s): {0}.
        /// </summary>
        internal static string DependencyOnMissingModule {
            get {
                return ResourceManager.GetString("DependencyOnMissingModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Directory {0} was not found..
        /// </summary>
        internal static string DirectoryNotFound {
            get {
                return ResourceManager.GetString("DirectoryNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicated module with name {0} has been found by the loader..
        /// </summary>
        internal static string DuplicatedModule {
            get {
                return ResourceManager.GetString("DuplicatedModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicated module group with name {0} has been found by the loader..
        /// </summary>
        internal static string DuplicatedModuleGroup {
            get {
                return ResourceManager.GetString("DuplicatedModuleGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to retrieve the module type {0} from the loaded assemblies.  You may need to specify a more fully-qualified type name..
        /// </summary>
        internal static string FailedToGetType {
            get {
                return ResourceManager.GetString("FailedToGetType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while initializing module &apos;{0}&apos;. 
        ///    - The exception message was: {2}
        ///    - The Assembly that the module was trying to be loaded from was:{1}
        ///    Check the InnerException property of the exception for more information. If the exception occurred while creating an object in a DI container, you can exception.GetRootException() to help locate the root cause of the problem. 
        ///  .
        /// </summary>
        internal static string FailedToLoadModule {
            get {
                return ResourceManager.GetString("FailedToLoadModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while initializing module &apos;{0}&apos;. 
        ///    - The exception message was: {1}
        ///    Check the InnerException property of the exception for more information. If the exception occurred 
        ///    while creating an object in a DI container, you can exception.GetRootException() to help locate the 
        ///    root cause of the problem. .
        /// </summary>
        internal static string FailedToLoadModuleNoAssemblyInfo {
            get {
                return ResourceManager.GetString("FailedToLoadModuleNoAssemblyInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load type for module {0}. 
        ///Error was: {1}..
        /// </summary>
        internal static string FailedToRetrieveModule {
            get {
                return ResourceManager.GetString("FailedToRetrieveModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HostControl cannot have null value when behavior attaches. .
        /// </summary>
        internal static string HostControlCannotBeNull {
            get {
                return ResourceManager.GetString("HostControlCannotBeNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The HostControl property cannot be set after Attach method has been called..
        /// </summary>
        internal static string HostControlCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("HostControlCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to HostControl type must be a TabControl..
        /// </summary>
        internal static string HostControlMustBeATabControl {
            get {
                return ResourceManager.GetString("HostControlMustBeATabControl", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IModuleEnumerator interface is no longer used and has been replaced by ModuleCatalog..
        /// </summary>
        internal static string IEnumeratorObsolete {
            get {
                return ResourceManager.GetString("IEnumeratorObsolete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The argument must be a valid absolute Uri to an assembly file..
        /// </summary>
        internal static string InvalidArgumentAssemblyUri {
            get {
                return ResourceManager.GetString("InvalidArgumentAssemblyUri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Target of the IDelegateReference should be of type {0}..
        /// </summary>
        internal static string InvalidDelegateRerefenceTypeException {
            get {
                return ResourceManager.GetString("InvalidDelegateRerefenceTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ItemsControl&apos;s ItemsSource property is not empty. 
        ///    This control is being associated with a region, but the control is already bound to something else. 
        ///    If you did not explicitly set the control&apos;s ItemSource property, 
        ///    this exception may be caused by a change in the value of the inherited RegionManager attached property..
        /// </summary>
        internal static string ItemsControlHasItemsSourceException {
            get {
                return ResourceManager.GetString("ItemsControlHasItemsSourceException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mapping with the given type is already registered: {0}..
        /// </summary>
        internal static string MappingExistsException {
            get {
                return ResourceManager.GetString("MappingExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} depends on other modules that don&apos;t belong to the same group..
        /// </summary>
        internal static string ModuleDependenciesNotMetInGroup {
            get {
                return ResourceManager.GetString("ModuleDependenciesNotMetInGroup", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} was not found in the catalog..
        /// </summary>
        internal static string ModuleNotFound {
            get {
                return ResourceManager.GetString("ModuleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The ModulePath cannot contain a null value or be empty.
        /// </summary>
        internal static string ModulePathCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("ModulePathCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed to load type &apos;{0}&apos; from assembly &apos;{1}&apos;..
        /// </summary>
        internal static string ModuleTypeNotFound {
            get {
                return ResourceManager.GetString("ModuleTypeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The name of this control should not be null!.
        /// </summary>
        internal static string NameValueOfControlIsNull {
            get {
                return ResourceManager.GetString("NameValueOfControlIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navigation is already in progress on region with name &apos;{0}&apos;..
        /// </summary>
        internal static string NavigationInProgress {
            get {
                return ResourceManager.GetString("NavigationInProgress", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Navigation cannot proceed until a region is set for the RegionNavigationService..
        /// </summary>
        internal static string NavigationServiceHasNoRegion {
            get {
                return ResourceManager.GetString("NavigationServiceHasNoRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The IRegionAdapter for the type {0} is not registered in the region adapter mappings. You can register an IRegionAdapter for this control by overriding the ConfigureRegionAdapterMappings method in the bootstrapper..
        /// </summary>
        internal static string NoRegionAdapterException {
            get {
                return ResourceManager.GetString("NoRegionAdapterException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to There is currently no moduleTypeLoader in the ModuleManager that can retrieve the specified module..
        /// </summary>
        internal static string NoRetrieverCanRetrieveModule {
            get {
                return ResourceManager.GetString("NoRetrieverCanRetrieveModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception has occurred while trying to add a view to region &apos;{0}&apos;. 
        ///    - The most likely causing exception was was: &apos;{1}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException(). .
        /// </summary>
        internal static string OnViewRegisteredException {
            get {
                return ResourceManager.GetString("OnViewRegisteredException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The member access expression does not access a property..
        /// </summary>
        internal static string PropertySupport_ExpressionNotProperty_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_ExpressionNotProperty_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The expression is not a member access expression..
        /// </summary>
        internal static string PropertySupport_NotMemberAccessExpression_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_NotMemberAccessExpression_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The referenced property is a static property..
        /// </summary>
        internal static string PropertySupport_StaticExpression_Exception {
            get {
                return ResourceManager.GetString("PropertySupport_StaticExpression_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Attach method cannot be called when Region property is null..
        /// </summary>
        internal static string RegionBehaviorAttachCannotBeCallWithNullRegion {
            get {
                return ResourceManager.GetString("RegionBehaviorAttachCannotBeCallWithNullRegion", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Region property cannot be set after Attach method has been called..
        /// </summary>
        internal static string RegionBehaviorRegionCannotBeSetAfterAttach {
            get {
                return ResourceManager.GetString("RegionBehaviorRegionCannotBeSetAfterAttach", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while creating a region with name &apos;{0}&apos;. The exception was: {1}. .
        /// </summary>
        internal static string RegionCreationException {
            get {
                return ResourceManager.GetString("RegionCreationException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region being added already has a name of &apos;{0}&apos; and cannot be added to the region manager with a different name (&apos;{1}&apos;)..
        /// </summary>
        internal static string RegionManagerWithDifferentNameException {
            get {
                return ResourceManager.GetString("RegionManagerWithDifferentNameException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region name cannot be null or empty..
        /// </summary>
        internal static string RegionNameCannotBeEmptyException {
            get {
                return ResourceManager.GetString("RegionNameCannotBeEmptyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Region with the given name is already registered: {0}.
        /// </summary>
        internal static string RegionNameExistsException {
            get {
                return ResourceManager.GetString("RegionNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This RegionManager does not contain a Region with the name &apos;{0}&apos;..
        /// </summary>
        internal static string RegionNotFound {
            get {
                return ResourceManager.GetString("RegionNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region manager does not contain the {0} region..
        /// </summary>
        internal static string RegionNotInRegionManagerException {
            get {
                return ResourceManager.GetString("RegionNotInRegionManagerException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View already exists in region..
        /// </summary>
        internal static string RegionViewExistsException {
            get {
                return ResourceManager.GetString("RegionViewExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to View with name &apos;{0}&apos; already exists in the region..
        /// </summary>
        internal static string RegionViewNameExistsException {
            get {
                return ResourceManager.GetString("RegionViewNameExistsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Module {0} is marked for automatic initialization when the application starts, but it depends on modules that are marked as OnDemand initialization. To fix this error, mark the dependency modules for InitializationMode=WhenAvailable, or remove this validation by extending the ModuleCatalog class..
        /// </summary>
        internal static string StartupModuleDependsOnAnOnDemandModule {
            get {
                return ResourceManager.GetString("StartupModuleDependsOnAnOnDemandModule", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided String argument {0} must not be null or empty..
        /// </summary>
        internal static string StringCannotBeNullOrEmpty {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The provided String argument {0} must not be null or empty..
        /// </summary>
        internal static string StringCannotBeNullOrEmpty1 {
            get {
                return ResourceManager.GetString("StringCannotBeNullOrEmpty1", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No BehaviorType with key &apos;{0}&apos; was registered..
        /// </summary>
        internal static string TypeWithKeyNotRegistered {
            get {
                return ResourceManager.GetString("TypeWithKeyNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to An exception occurred while trying to create region objects. 
        ///    - The most likely causing exception was: &apos;{0}&apos;.
        ///    But also check the InnerExceptions for more detail or call .GetRootException(). .
        /// </summary>
        internal static string UpdateRegionException {
            get {
                return ResourceManager.GetString("UpdateRegionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The value must be of type ModuleInfo..
        /// </summary>
        internal static string ValueMustBeOfTypeModuleInfo {
            get {
                return ResourceManager.GetString("ValueMustBeOfTypeModuleInfo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} not found..
        /// </summary>
        internal static string ValueNotFound {
            get {
                return ResourceManager.GetString("ValueNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The region does not contain the specified view..
        /// </summary>
        internal static string ViewNotInRegionException {
            get {
                return ResourceManager.GetString("ViewNotInRegionException", resourceCulture);
            }
        }
    }
}
