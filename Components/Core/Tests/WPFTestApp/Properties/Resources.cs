﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

using System.ComponentModel;
using System.Globalization;
using System.Resources;

namespace WindowsPresentationFramework.Properties
{
    /// <summary>
    ///    A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the Strongly Typed Resource Builder
    // class via a tool like ResGen or Visual Studio.NET.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    internal class Resources
    {
        private static ResourceManager _resMgr;

        private static CultureInfo _resCulture;

        /*FamANDAssem*/
        internal Resources() {}

        /// <summary>
        ///    Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static ResourceManager ResourceManager
        {
            get
            {
                if ((_resMgr == null))
                {
                    ResourceManager temp = new ResourceManager("Resources", typeof (Resources).Assembly);
                    _resMgr = temp;
                }
                return _resMgr;
            }
        }

        /// <summary>
        ///    Overrides the current thread's CurrentUICulture property for all
        ///    resource lookups using this strongly typed resource class.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public static CultureInfo Culture
        {
            get { return _resCulture; }
            set { _resCulture = value; }
        }
    }
}