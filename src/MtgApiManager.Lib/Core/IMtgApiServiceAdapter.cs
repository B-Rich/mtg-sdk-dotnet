﻿namespace MtgApiManager.Lib.Core
{
    using System;
    using System.Threading.Tasks;
    using Dto;

    /// <summary>
    /// Used to make web service calls.
    /// </summary>
    internal interface IMtgApiServiceAdapter
    {
        /// <summary>
        /// Do a Web Get for the given request Uri .
        /// </summary>
        /// <typeparam name="T">The type to serialize into.</typeparam>
        /// <param name="requestUri">The URL to call.</param>
        /// <returns>The serialized response.</returns>
        Task<T> WebGetAsync<T>(Uri requestUri) where T : IMtgResponse;
    }
}