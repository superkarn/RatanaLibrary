﻿using System;

namespace RatanaLibrary.Cache
{
    /// <summary>
    /// An implementation of the ICache interface that does not do anything.
    /// This is useful for testing.
    /// </summary>
    public class NoCache : ICache
    {
        T ICache.GetOrAdd<T>(String key, Func<T> orAdd, TimeSpan expiration)
        {
            return orAdd();
        }

        void ICache.Remove(String key)
        {
            // Nothing to do
        }

        Boolean ICache.TryGet<T>(string key, out T value)
        {
            value = default(T);
            return true;
        }
    }
}
