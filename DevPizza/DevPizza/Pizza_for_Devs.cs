//------------------------------------------------------------------------------
// <copyright file="Pizza_for_Devs.cs" company="Company">
//     Copyright (c) Company.  All rights reserved.
// </copyright>
//------------------------------------------------------------------------------

namespace DevPizza
{
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.Shell;

    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("f8e51809-1c0a-4a4f-9d04-8e801a1e06ae")]
    public class Pizza_for_Devs : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pizza_for_Devs"/> class.
        /// </summary>
        public Pizza_for_Devs() : base(null)
        {
            this.Caption = "Pizza for Devs";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new Pizza_for_DevsControl();
        }
    }
}
