﻿using System;
using WorldDomination.Web.Authentication;

namespace Nancy.Authentication.WorldDomination
{
    public class AuthenticateCallbackData
    {
        /// <summary>
        /// The authenticated client information, if we have successfully authenticated.
        /// </summary>
        public IAuthenticatedClient AuthenticatedClient { get; set; }

        /// <summary>
        /// Possible Url to redirect to.
        /// </summary>
        public Uri RedirectUrl { get; set; }

        /// <summary>
        /// Exception information, if an error has occurred.
        /// </summary>
        public Exception Exception { get; set; }
    }
}