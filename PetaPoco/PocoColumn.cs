using System;
using System.Reflection;

namespace PetaPoco
{
	public class PocoColumn
	{
		public string ColumnName;
		public PropertyInfo PropertyInfo;
		public bool ResultColumn;
		public virtual void SetValue(object target, object val) { PropertyInfo.SetValue(target, val, null); }
		public virtual object GetValue(object target) { return PropertyInfo.GetValue(target, null); }
		public virtual object ChangeType(object val) { return Convert.ChangeType(val, PropertyInfo.PropertyType); }
	}
}