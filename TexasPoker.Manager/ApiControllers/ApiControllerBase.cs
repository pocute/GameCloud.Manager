﻿using System.ComponentModel.Composition;
using System.Web.Http;
using GameCloud.UCenter.Web.Common.Filters;
using GameCloud.UCenter.Common.Settings;
using TexasPoker.Database;

namespace Manager.TexasPoker.ApiControllers
{
    /// <summary>
    /// Provide an API controller base class.
    /// </summary>
    [Export]
    [ActionExecutionFilter]
    public class ApiControllerBase : ApiController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiControllerBase" /> class.
        /// </summary>
        /// <param name="database">Indicating the database.</param>
        /// <param name="settings">Indicating the settings.</param>
        [ImportingConstructor]
        public ApiControllerBase(TexasPokerDatabaseContext database, Settings settings)
        {
            this.Database = database;
            this.Settings = settings;
        }

        /// <summary>
        /// Gets the database context.
        /// </summary>
        protected TexasPokerDatabaseContext Database { get; private set; }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        protected Settings Settings { get; private set; }
    }
}