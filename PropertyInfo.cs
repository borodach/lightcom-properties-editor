/********************************************************************
	created:	2006/02/09
	created:	9:1:2006   16:28
	filename: 	PropertyInfo.cs
	file base:	PropertyInfo
	file ext:	cs
	author:		�.�. �������
	
	purpose:	����� �������� ���������� ������� ��� ������� ����������
				����������� ������� �������� ����������.
*********************************************************************/
using System;
using System.Collections;
using System.ComponentModel;

namespace LightCom.UI
{
	/// <summary>
	/// Summary description for PropertyInfo.
	/// </summary>
	public class PropertyInfo: Component
    {           
        // Simply call Dispose(false).
        ~PropertyInfo ()
        {
            Dispose (false);
        }
	
		/// <summary>
		/// ������������ ����� ������
		/// </summary>
		public enum PropertyType
		{
			Picture,	//����� �����������
			Text,		//���� ������
			List,		//����� �� ����������� ������
			Integer,	//���� ������ �����
			Float,		//���� �������� �����
			Color,		//����� �����
			File,		//����� �����
			Check,		//������
			Switch,		//�������������
			Separator,	//����������� (�� ������������)
			Group		//������ ���������
		};

		public PropertyInfo()
		{
			//
			// TODO: Add constructor logic here
			//
			//ListValues = new ArrayList();
			Enabled = true;
		}

		protected string m_name;
		/// <summary>
		/// ��� ������������ �������� ����������
		/// </summary>
		public string Name
		{
			get{return m_name;}
			set{m_name = value;}
		}

		protected string m_text;
		/// <summary>
		/// ����� ������� ���������� ������ ��������
		/// </summary>
		public string Text
		{
			get{return m_text;}
			set{m_text = value;}
		}

		protected PropertyType m_type;
		/// <summary>
		/// ��� �������� ���������� (��. ������������ ����� �������)
		/// </summary>
		public PropertyType Type
		{
			get{return m_type;}
			set{m_type = value;}
		}

		protected object m_max;
		/// <summary>
		/// ����������� ���������� �������� ��� �������.
		/// � ��������� ������� ����� ����������� ������������:
		/// - ��� ���� Group �������� ���� ������, ������� ����� 
		///		������ ������ � ������� ��������;
		///	- ��� �������� �����/����������� �������� ������ ������ ������.
		/// </summary>
		public object Max
		{
			get{return m_max;}
			set{m_max = value;}
		}

		protected object m_min;
		/// <summary>
		/// ���������� ���������� �������� ��� ��������.
		/// </summary>
		public object Min
		{
			get{return m_min;}
			set{m_min = value;}
		}

		protected object m_value;
		/// <summary>
		/// �������� ��������.
		/// </summary>
		public object Value
		{
			get{return m_value;}
			set{m_value = value;}
		}
        
		protected ArrayList m_listVales;
		/// <summary>
		/// ������ �������� ������� ����� ��������� � ������� ��������,
		/// �������� ��� ���� Group � Switch �������� �������� ����������� ���������.
		/// </summary>
		public ArrayList ListValues
		{
			get{return m_listVales;}
			set{m_listVales = value;}
		}

		protected string [] m_dependentProperties;
		/// <summary>
		/// �� ������������
		/// </summary>
		public string [] DependentProperties
		{
			get{return m_dependentProperties;}
			set{m_dependentProperties = value;}
		}

		protected string m_leftCtrlName;
		/// <summary>
		/// ��� �������� ������ �� �������� ���������� ���������� ������� �������,
		/// ������������ ������ ��� ���� Group.
		/// </summary>
		public string LeftCtrlName
		{
			get{return m_leftCtrlName;}
			set{m_leftCtrlName = value;}
		}

		protected bool m_enabled;
		/// <summary>
		/// ��������� / ��������� ��������� � ��������.
		/// </summary>
		public bool Enabled
		{
			get {return m_enabled;}
			set {m_enabled = value;}
		}

		private static PropertyInfo m_separator;
		public static PropertyInfo Separator
		{
			get
			{
				if (null == m_separator)
				{
					m_separator = new PropertyInfo();
					m_separator.Type = PropertyType.Separator;
				}

				return m_separator;
			}
		}
	}
}
