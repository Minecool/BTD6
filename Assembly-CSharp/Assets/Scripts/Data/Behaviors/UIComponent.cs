namespace Assets.Scripts.Data.Behaviors;

[AttributeUsage(AttributeTargets::Class (4), Inherited = True)]
public class UIComponent : Attribute
{
	[CompilerGenerated]
	private readonly string <PrefabName>k__BackingField; //Field offset: 0x10

	public string PrefabName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public UIComponent(string prefabName) { }

	[CompilerGenerated]
	public string get_PrefabName() { }

}

