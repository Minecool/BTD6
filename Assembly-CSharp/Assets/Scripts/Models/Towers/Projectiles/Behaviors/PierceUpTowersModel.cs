namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(PierceUpTowers), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class PierceUpTowersModel : ProjectileBehaviorModel
{
	internal class PierceUpMutator : BehaviorMutator
	{
		private PierceUpTowersModel pierceUpTowersModel; //Field offset: 0x70
		private float increase; //Field offset: 0x78

		public PierceUpMutator(float increase, string id, int priority, PierceUpTowersModel pierceUpTowersModel) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float increase; //Field offset: 0x38
	[SerializeField]
	private float lifespan; //Field offset: 0x3C
	public int lifespanFrames; //Field offset: 0x40
	public bool useClosest; //Field offset: 0x44
	public string mutatorId; //Field offset: 0x48
	public int priority; //Field offset: 0x50
	public bool useTowerPosition; //Field offset: 0x54
	public PrefabReference displayToAddPath; //Field offset: 0x58
	[SerializeField]
	private DisplayModel displayModel; //Field offset: 0x60
	private PierceUpMutator mutator; //Field offset: 0x68

	public PierceUpMutator Mutator
	{
		 get { } //Length: 293
	}

	public PierceUpTowersModel(string name, float increase, float lifespan, bool useClosest, string mutatorId, int priority, bool useTowerPosition, PrefabReference displayToAddPath) { }

	public virtual Model Clone() { }

	public PierceUpMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

