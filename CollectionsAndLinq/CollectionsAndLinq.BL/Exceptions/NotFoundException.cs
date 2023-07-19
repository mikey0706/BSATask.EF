using System;

namespace CollectionsAndLinq.BL.Exceptions
{
    public sealed class NotFoundException : Exception
    {

        public NotFoundException(int id) : base($"Entity with id: {id} was not found.") { }
    }
}
