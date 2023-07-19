using BSATask.WebAPI.Enums;
using CollectionsAndLinq.BL.Exceptions;
using System;
using System.Net;


namespace BSATask.WebAPI.Extensions
{
    public static class ExceptionFilterExtensions
    {
        public static (HttpStatusCode statusCode, ErrorCode errorCode) ParseException(this Exception exception)
        {
            return exception switch
            {
                NotFoundException _ => (HttpStatusCode.NotFound, ErrorCode.NotFound),
                WrongIdException _ => (HttpStatusCode.Unauthorized, ErrorCode.WrongId),
            };
        }
    }
}
