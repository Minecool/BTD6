namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(IncreaseRange), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class IncreaseRangeModel : AbilityBehaviorModel
{
	internal class RangeMutator : BehaviorMutator
	{
		private float rangeMultiplier; //Field offset: 0x70
		private float addative; //Field offset: 0x74

		public RangeMutator(string mutatorId, float rangeMultiplier, float addative, bool isUnique = true, bool isArtifactMutator = false) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int lifespanFrames; //Field offset: 0x30
	public float multiplier; //Field offset: 0x34
	public float addative; //Field offset: 0x38
	public bool endOnDefeatScreen; //Field offset: 0x3C
	private RangeMutator mutator; //Field offset: 0x40

	public RangeMutator Mutator
	{
		 get { } //Length: 282
	}

	public IncreaseRangeModel(string name, int lifespanFrames, float multiplier, float addative, bool endOnDefeatScreen) { }

	public virtual Model Clone() { }

	public RangeMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

