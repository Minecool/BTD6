namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(Biohack), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class BiohackModel : AbilityBehaviorBuffModel
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<TowerBehaviorModel> <>9__16_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetShutOffFrames>b__16_0(TowerBehaviorModel x) { }

	}

	internal class BiohackDamageMutator : BehaviorMutator
	{
		private float increase; //Field offset: 0x70

		public BiohackDamageMutator(BiohackModel parent, float increase) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class Mutator : BehaviorMutator
	{
		public TowerBehaviorModel[] behaviors; //Field offset: 0x70
		public int time; //Field offset: 0x78
		public string mutationId; //Field offset: 0x80

		public Mutator(BiohackModel parent, TowerBehaviorModel[] behaviors, int time) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[SerializeField]
	private float lifespan; //Field offset: 0x48
	public int lifespanFrames; //Field offset: 0x4C
	public float damageIncrease; //Field offset: 0x50
	public int affectedCount; //Field offset: 0x54
	public TowerBehaviorModel[] behaviors; //Field offset: 0x58
	public String[] filterTowers; //Field offset: 0x60
	public EffectModel effectModel; //Field offset: 0x68
	private BiohackDamageMutator damageMutator; //Field offset: 0x70
	private Mutator behaviorMutator; //Field offset: 0x78

	public Mutator BehaviorMutator
	{
		 get { } //Length: 324
	}

	public BiohackDamageMutator DamageMutator
	{
		 get { } //Length: 299
	}

	public BiohackModel(string name, float lifespan, float damageIncrease, int affectedCount, TowerBehaviorModel[] behaviors, String[] filterTowers, EffectModel effectModel, string buffLocsName, string buffIconName) { }

	public virtual Model Clone() { }

	public Mutator get_BehaviorMutator() { }

	public BiohackDamageMutator get_DamageMutator() { }

	public int GetShutOffFrames() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

