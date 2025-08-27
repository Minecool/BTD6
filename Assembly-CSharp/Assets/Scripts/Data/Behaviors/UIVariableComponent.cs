namespace Assets.Scripts.Data.Behaviors;

[AttributeUsage(AttributeTargets::Field (256))]
public class UIVariableComponent : Attribute
{
	[CompilerGenerated]
	private readonly string <VariablePrefabName>k__BackingField; //Field offset: 0x10

	public string VariablePrefabName
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public UIVariableComponent(string variablePrefabName) { }

	[CompilerGenerated]
	public string get_VariablePrefabName() { }

}

