namespace Assets.Scripts.Models.Difficulty;

public class SpecialCondition
{
	private readonly string _localisationId; //Field offset: 0x10
	[CompilerGenerated]
	private readonly SpecialConditionType <Type>k__BackingField; //Field offset: 0x18

	public string LocalisedDisplayText
	{
		 get { } //Length: 79
	}

	public SpecialConditionType Type
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public SpecialCondition(SpecialConditionType type, string localisationId) { }

	public string get_LocalisedDisplayText() { }

	[CompilerGenerated]
	public SpecialConditionType get_Type() { }

}

