namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(DamageUpTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageUpTowersModel : ProjectileBehaviorModel
{
	internal class DamageUpMutator : BehaviorMutator
	{
		private int increase; //Field offset: 0x70

		public DamageUpMutator(int increase, string id, int priority) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public int increase; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x3C
	public int lifespanFrames; //Field offset: 0x40
	public bool useClosest; //Field offset: 0x44
	public string mutatorId; //Field offset: 0x48
	public int priority; //Field offset: 0x50
	public bool useTowerPosition; //Field offset: 0x54
	private DamageUpMutator mutator; //Field offset: 0x58

	public DamageUpMutator Mutator
	{
		 get { } //Length: 280
	}

	public DamageUpTowersModel(string name, int increase, float lifespan, bool useClosest, string mutatorId, int priority, bool useTowerPosition) { }

	public virtual Model Clone() { }

	public DamageUpMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

