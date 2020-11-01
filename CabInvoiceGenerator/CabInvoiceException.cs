﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CabInvoiceException.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Akshay Poriya"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    /// <summary>
    /// Custom Exception for Cab Invoice Program
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class CabInvoiceException : Exception
    {
        /// <summary>
        /// Enum for defining different type of custom exception
        /// </summary>
        public ExceptionType type;

        /// <summary>
        /// Initializes a new instance of the <see cref="CabInvoiceException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="message">The message.</param>
        public CabInvoiceException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
        public enum ExceptionType
        {
            INVALID_DISTANCE, INVALID_TIME, NULL_RIDES, INVALID_USER_ID
        }
    }
}