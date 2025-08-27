namespace Assets.Scripts.Models.Towers.Behaviors.PlacementBehaviors;

[Implementation(typeof(PlacementAreaTypeRangeBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PlacementAreaTypeRangeBuffModel : PlacementBehaviorModel
{
	internal class RangeMutator : BehaviorMutator
	{
		public float rangeMultiplier; //Field offset: 0x70

		public RangeMutator(float rangeMultiplier) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float rangeMultiplier; //Field offset: 0x30
	private RangeMutator mutator; //Field offset: 0x38

	public RangeMutator Mutator
	{
		 get { } //Length: 233
	}

	public PlacementAreaTypeRangeBuffModel(string name, float rangeMultiplier) { }

	public virtual Model Clone() { }

	public RangeMutator get_Mutator() { }

	public virtual BehaviorMutator GetMutator(AreaType areaType) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

