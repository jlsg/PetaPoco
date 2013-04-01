using System;

namespace PetaPoco
{
	// This will be merged with IMapper in the next major version
	public interface IMapper2 : IMapper
	{
		Func<object, object> GetFromDbConverter(Type DestType, Type SourceType);
	}

}