//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// --------------------------------------------------------------------------------------------------
// <auto-generatedInfo>
// 	This code was generated by ResW File Code Generator (http://reswcodegen.codeplex.com)
// 	ResW File Code Generator was written by Christian Resma Helle
// 	and is under GNU General Public License version 2 (GPLv2)
// 
// 	This code contains a helper class exposing property representations
// 	of the string resources defined in the specified .ResW file
// 
// 	Generated: 07/25/2015 17:07:08
// </auto-generatedInfo>
// --------------------------------------------------------------------------------------------------
namespace Microsoft.IoT.Devices
{
    using Windows.ApplicationModel.Resources;
    
    
    internal partial class Strings
    {
        
        private static ResourceLoader resourceLoader;
        
        static Strings()
        {
            string executingAssemblyName;
            executingAssemblyName = Windows.UI.Xaml.Application.Current.GetType().AssemblyQualifiedName;
            string[] executingAssemblySplit;
            executingAssemblySplit = executingAssemblyName.Split(',');
            executingAssemblyName = executingAssemblySplit[1];
            string currentAssemblyName;
            currentAssemblyName = typeof(Strings).AssemblyQualifiedName;
            string[] currentAssemblySplit;
            currentAssemblySplit = currentAssemblyName.Split(',');
            currentAssemblyName = currentAssemblySplit[1];
            if (executingAssemblyName.Equals(currentAssemblyName))
            {
                resourceLoader = ResourceLoader.GetForCurrentView("Strings");
            }
            else
            {
                resourceLoader = ResourceLoader.GetForCurrentView(currentAssemblyName + "/Strings");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Already subscribed"
        /// </summary>
        public static string AlreadySubscribed
        {
            get
            {
                return resourceLoader.GetString("AlreadySubscribed");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "An existing update action has already been scheduled and cannot be changed"
        /// </summary>
        public static string ExistingUpdateAction
        {
            get
            {
                return resourceLoader.GetString("ExistingUpdateAction");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Subscriber must be of type Action or Func<Task>"
        /// </summary>
        public static string InvalidSubscriberType
        {
            get
            {
                return resourceLoader.GetString("InvalidSubscriberType");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "The update action must first be specified by calling SetUpdateAction or SetAsyncUpdateAction"
        /// </summary>
        public static string NoUpdateAction
        {
            get
            {
                return resourceLoader.GetString("NoUpdateAction");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "Subscription not found"
        /// </summary>
        public static string SubscriptionNotFound
        {
            get
            {
                return resourceLoader.GetString("SubscriptionNotFound");
            }
        }
        
        /// <summary>
        /// Localized resource similar to "The specified type '{0}' is not a delegate"
        /// </summary>
        public static string TypeNotDelegate
        {
            get
            {
                return resourceLoader.GetString("TypeNotDelegate");
            }
        }
    }
}