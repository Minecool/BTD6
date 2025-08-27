namespace Assets.Scripts.GameEditor.UI;

[AttributeUsage(384, AllowMultiple = False)]
public class BindToAttribute : Attribute
{
	[CompilerGenerated]
	private readonly string <ViewModelProperty>k__BackingField; //Field offset: 0x10

	public string ViewModelProperty
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BindToAttribute(string viewModelProperty) { }

	[CompilerGenerated]
	public string get_ViewModelProperty() { }

}

