using System;
using System.Reflection;

namespace PetaPoco
{
	// Optionally provide an implementation of this to Database.Mapper
	public interface IMapper
	{
		void GetTableInfo(Type t, TableInfo ti);
		bool MapPropertyToColumn(PropertyInfo pi, ref string columnName, ref bool resultColumn);
		Func<object, object> GetFromDbConverter(PropertyInfo pi, Type SourceType);
		Func<object, object> GetToDbConverter(Type SourceType);
	}
}