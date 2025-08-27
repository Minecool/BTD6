namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(QuickEntry), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class QuickEntryModel : BloonBehaviorModel
{
	internal class BloonSpeedMutator : BehaviorMutator
	{
		public float speedMultiplier; //Field offset: 0x70

		public BloonSpeedMutator(float speedMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float speedMultiplier; //Field offset: 0x30
	public float percentOfTrack; //Field offset: 0x34
	private BloonSpeedMutator mutator; //Field offset: 0x38

	public BloonSpeedMutator Mutator
	{
		 get { } //Length: 233
	}

	public QuickEntryModel() { }

	public QuickEntryModel(string name, float speedMultiplier, float percentOFTrack) { }

	public virtual Model Clone() { }

	public BloonSpeedMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

