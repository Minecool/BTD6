namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(GroundZeroBombBuff), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class GroundZeroBombBuffModel : AbilityBehaviorModel
{
	internal class GroundZeroBuffMutator : BehaviorMutator
	{
		private int increase; //Field offset: 0x70

		public GroundZeroBuffMutator(int increase, string id, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public TowerMutatorModel towerMutatorModel; //Field offset: 0x30
	public int damageIncrease; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x3C
	public int lifespanFrames; //Field offset: 0x40
	private GroundZeroBuffMutator _mutator; //Field offset: 0x48

	public GroundZeroBuffMutator mutator
	{
		 get { } //Length: 269
	}

	public GroundZeroBombBuffModel(string name, int damageIncrease, float lifespan, GroundZeroBuffMutator mutator = null) { }

	public virtual Model Clone() { }

	public GroundZeroBuffMutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

