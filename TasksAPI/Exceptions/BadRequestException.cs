﻿using System.Runtime.Serialization;

namespace TasksAPI.Exceptions
{
    public class BadRequestException : Exception
    {

        public BadRequestException(string message) : base(message)
        {
        }
    }
}