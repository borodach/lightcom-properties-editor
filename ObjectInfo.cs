/********************************************************************
	created:	2006/02/09
	created:	9:1:2006   16:28
	filename: 	ObjectInfo.cs
	file base:	ObjectInfo
	file ext:	cs
	author:		�.�. �������
	
	purpose:	����� �������� ���������� ������� �������.
*********************************************************************/
using System;
using System.Collections.Generic;

namespace LightCom.UI
{
	/// <summary>
	/// Summary description for ObjectInfo.
	/// </summary>
	public class ObjectInfo
	{
		public ObjectInfo()
		{
            m_propertyGroups = new List<PropertyGroup> ();
		}

		protected string m_name;
		public string Name
		{
			get{return m_name;}
			set{m_name = value;}
		}

		protected string m_text;
		public string Text
		{
			get{return m_text;}
			set{m_text = value;}
		}

        protected List<PropertyGroup> m_propertyGroups;
		/// <summary>
		/// ������ ����� ������� �������.
		/// </summary>
		public List<PropertyGroup> PropertyGroups
		{
			get{return m_propertyGroups;}
			set{m_propertyGroups = value;}
		}

		protected PropertyGroup m_basePropertiesGroup;
		public PropertyGroup BaseProperties
		{
			get {return m_basePropertiesGroup;}
			set	{m_basePropertiesGroup = value;}
		}
	}
}
