namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
internal struct StyleSelectorPart
{
	[SerializeField]
	private string m_Value; //Field offset: 0x0
	[SerializeField]
	private StyleSelectorType m_Type; //Field offset: 0x8
	internal object tempData; //Field offset: 0x10

	public internal StyleSelectorType type
	{
		 get { } //Length: 6
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
		internal set { } //Length: 4
	}

	public string value
	{
		 get { } //Length: 6
	}

	public static StyleSelectorPart CreateClass(string className) { }

	public static StyleSelectorPart CreateId(string Id) { }

	public static StyleSelectorPart CreatePredicate(object predicate) { }

	public StyleSelectorType get_type() { }

	public string get_value() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"}])]
	internal void set_type(StyleSelectorType value) { }

	public virtual string ToString() { }

}

