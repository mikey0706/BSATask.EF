using System;

namespace CollectionsAndLinq.BL.Exceptions
{
    public sealed class WrongIdException : Exception
    {
        public WrongIdException(int id) : base($"Item with id {id} does not exist.") { }
    }
}
