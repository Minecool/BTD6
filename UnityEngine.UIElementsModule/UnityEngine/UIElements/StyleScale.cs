namespace UnityEngine.UIElements;

public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale>
{
	private Scale m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x10

	public override StyleKeyword keyword
	{
		 get { } //Length: 6
		 set { } //Length: 4
	}

	public override Scale value
	{
		 get { } //Length: 328
		 set { } //Length: 95
	}

	public StyleScale(Scale v) { }

	public StyleScale(StyleKeyword keyword) { }

	internal StyleScale(Scale v, StyleKeyword keyword) { }

	public override bool Equals(StyleScale other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Scale get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleScale lhs, StyleScale rhs) { }

	public static StyleScale op_Implicit(StyleKeyword keyword) { }

	public static StyleScale op_Implicit(Scale v) { }

	public override void set_keyword(StyleKeyword value) { }

	public override void set_value(Scale value) { }

	public virtual string ToString() { }

}

