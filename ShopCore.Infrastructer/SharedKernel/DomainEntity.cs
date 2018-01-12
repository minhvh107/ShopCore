﻿namespace ShopCore.Infrastructer.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { set; get; }

        /// <summary>
        /// True if domain entity has an identity
        /// </summary>
        /// <returns></returns>
        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}