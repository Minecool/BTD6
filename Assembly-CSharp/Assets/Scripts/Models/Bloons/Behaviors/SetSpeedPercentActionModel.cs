namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SetSpeedPercentAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SetSpeedPercentActionModel : BloonBehaviorActionModel
{
	internal class SpeedPercentMutator : BehaviorMutator
	{
		public float percent; //Field offset: 0x70

		public SpeedPercentMutator(float percent, string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorId = "SetSpeedPercent"; //Field offset: 0x0
	public float percent; //Field offset: 0x38
	public bool revert; //Field offset: 0x3C
	public float time; //Field offset: 0x40
	public float distance; //Field offset: 0x44
	private SpeedPercentMutator mutator; //Field offset: 0x48

	public SpeedPercentMutator Mutator
	{
		 get { } //Length: 132
	}

	public SetSpeedPercentActionModel() { }

	public SetSpeedPercentActionModel(string name, string actionId, float percent, bool revert, float time, float distance) { }

	public virtual Model Clone() { }

	public SpeedPercentMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

