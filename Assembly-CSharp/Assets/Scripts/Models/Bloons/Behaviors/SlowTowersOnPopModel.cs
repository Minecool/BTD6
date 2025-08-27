namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(SlowTowersOnPop), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowTowersOnPopModel : BloonBehaviorModelWithTowerTracking
{
	internal class TowerRateMutator : BehaviorMutator
	{
		private readonly float multiplier; //Field offset: 0x70

		public TowerRateMutator(bool isUnique, string mutatorId, float multiplier, int priority, BuffIndicatorModel buffIndicator) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public bool ignoreSameFrameDegrade; //Field offset: 0x38
	public float duration; //Field offset: 0x3C
	public float rateMultiplier; //Field offset: 0x40
	public float radius; //Field offset: 0x44
	private TowerRateMutator mutator; //Field offset: 0x48

	public TowerRateMutator Mutator
	{
		 get { } //Length: 252
	}

	public SlowTowersOnPopModel() { }

	public SlowTowersOnPopModel(string name, float duration, float rateMultiplier, float radius, bool ignoreSameFrameDegrade, ObjectId tower) { }

	public virtual Model Clone() { }

	public TowerRateMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

