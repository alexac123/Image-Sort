﻿using System;

namespace Image_sort.Communication
{
    /// <summary>
    /// Contains constant <see cref="string"/>s with messages that can be passed
    /// around when communicating command line (stdio) with the updater.
    /// </summary>
    public class UpdaterConstants
    {
        /// <summary>
        /// Tells the accessing app that the rate limit on GitHub has been reached
        /// and that it must be waited for a reset.
        /// 
        /// Usually followed by two messages: <see cref="ResetsOnTime"/> and the
        /// time as UTC.
        /// </summary>
        public const string RateLimitReached = "rate_limit_reached";
        /// <summary>
        /// Tells the accessing app when the GitHub rate limit resets at the time
        /// returned in the following message.
        /// </summary>
        public const string ResetsOnTime = "resets_on_time";
        /// <summary>
        /// Tells the accessing app that an error occured and that it should read
        /// the next message with the error code.
        /// </summary>
        public const string Error = "Error";
        /// <summary>
        /// Tells the accessing app, that the updater demands user consent.
        /// At this point, if needed, the app should ask for consent, and then 
        /// return either <see cref="Positive"/> or <see cref="Negative"/>
        /// </summary>
        public const string UserConsent = "user_consent";
        /// <summary>
        /// Signals that something is (supposed) to happen.
        /// </summary>
        public const string Positive = "yes";
        /// <summary>
        /// Signals that something is not (supposed) to happen.
        /// </summary>
        public const string Negative = "no";
    }
}
