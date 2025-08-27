namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(RangeReductionZone), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class RangeReductionZoneModel : BloonBehaviorModel
{
	internal class RangeMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public RangeMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float rangeMultiplier; //Field offset: 0x30
	private RangeMutator mutator; //Field offset: 0x38

	public RangeMutator Mutator
	{
		 get { } //Length: 248
	}

	public RangeReductionZoneModel() { }

	public RangeReductionZoneModel(string name, float rangeMultiplier) { }

	public virtual Model Clone() { }

	public RangeMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

