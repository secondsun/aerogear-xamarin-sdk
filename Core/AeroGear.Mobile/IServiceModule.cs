﻿using System;
using Aerogear.Mobile.Core;
using Core.AeroGear.Mobile.Core.Configuration;

namespace Core.AeroGear.Mobile
{
    public interface IServiceModule
    {
     
        /// <summary>
        /// Type/name used in the mobile-singleThreadService.json
        /// </summary>
        /// <value>the type/name used to identify the singleThreadService config in the JSON file</value>
        String Type
        {
            get;
        }

        /// <summary>
        /// A method how create/configure the singleThreadService
        /// </summary>
        /// <param name="core">MobileCore instance</param>
        /// <param name="serviceConfiguration">the configuration for the singleThreadService</param>
        void configure(MobileCore core, ServiceConfiguration serviceConfiguration);

        /// <summary>
        /// Whether the singleThreadService module requires its singleThreadService configuration to be
        /// defined or if it can be null. If this is <code>true</code> then an exception will be thrown
        /// if singleThreadService configuration cannot be found.
        /// </summary>
        /// <value><c>true</c> if the singleThreadService configuration should be defined.</value>
        bool requiresConfiguration {
            get;
        }

        /// <summary>
        /// Called when singleThreadService destroyed.
        /// </summary>
        void destroy();
    }
}
