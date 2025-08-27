namespace Assets.Scripts.Models.Bloons.Behaviors.Actions;

[Implementation(typeof(DashForwardsAction), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DashForwardsActionModel : BloonBehaviorActionModel
{
	internal class SetSpeedMutator : BehaviorMutator
	{
		public float speed; //Field offset: 0x70

		public SetSpeedMutator(float speed, string id) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string dashSpeedMutatorID = "DashSpeed"; //Field offset: 0x0
	public float speedMultiplier; //Field offset: 0x38
	public float dashDistance; //Field offset: 0x3C
	public String[] actionIds; //Field offset: 0x40
	public string dashAnimationName; //Field offset: 0x48
	public bool setSpeed; //Field offset: 0x50
	private SpeedPercentMutator mutator; //Field offset: 0x58
	private SetSpeedMutator setSpeedMutator; //Field offset: 0x60

	public SpeedPercentMutator Mutator
	{
		 get { } //Length: 132
	}

	public SetSpeedMutator SetSpeedAmountMutator
	{
		 get { } //Length: 263
	}

	public DashForwardsActionModel(string name, string actionId, float dashDistance, String[] actionIds, float speedMultiplier, string dashAnimationName, bool setSpeed) { }

	public virtual Model Clone() { }

	public SpeedPercentMutator get_Mutator() { }

	public SetSpeedMutator get_SetSpeedAmountMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

