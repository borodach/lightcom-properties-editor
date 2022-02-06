using System;
using System.Collections;

namespace LightCom.UI
{
	/// <summary>
	/// Summary description for IProperties.
	/// </summary>
	public interface IProperties
	{
		ObjectInfo GetObjectInfo();
		void GetPropertyList(PropertyGroup group);
		void SetProppertyList(PropertyGroup group);
		PropertyInfo GetProperty(string propertyName);
		void SetProperty(PropertyInfo val);
	}
}
