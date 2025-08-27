namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(Slow), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SlowModel : ProjectileBehaviorWithOverlayModel
{
	internal class SlowMutator : BehaviorMutatorWithFilters
	{
		public readonly string mutationId; //Field offset: 0x78
		public readonly string overlayType; //Field offset: 0x80
		public ChildSearchEnumerable<SlowModifierForTagModel> slowModifierForTagModels; //Field offset: 0x88
		public bool dontRefreshDuration; //Field offset: 0x90
		public bool didMutatorAffectBloon; //Field offset: 0x91
		public float multiplier; //Field offset: 0x94

		public SlowMutator(float multiplier, string mutationId, string overlayType, bool isUnique, bool dontRefreshDuration, int glueLevel, bool dontRemoveOnBloonDgrade) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public EffectModel effectModel; //Field offset: 0x40
	public int layers; //Field offset: 0x48
	public int overlayLayer; //Field offset: 0x4C
	public int glueLevel; //Field offset: 0x50
	public bool isUnique; //Field offset: 0x54
	public bool dontRefreshDuration; //Field offset: 0x55
	public bool cascadeMutators; //Field offset: 0x56
	public bool removeMutatorIfNotMatching; //Field offset: 0x57
	public bool matchLayersWithDamage; //Field offset: 0x58
	public string mutationId; //Field offset: 0x60
	public bool countGlueAchievement; //Field offset: 0x68
	[SerializeField]
	private float lifespan; //Field offset: 0x6C
	public int lifespanFrames; //Field offset: 0x70
	[SerializeField]
	private float multiplier; //Field offset: 0x74
	private SlowMutator mutator; //Field offset: 0x78
	public float chance; //Field offset: 0x80
	public bool dontRemoveOnBloonDegrade; //Field offset: 0x84

	public float Lifespan
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public float Multiplier
	{
		 get { } //Length: 6
		 set { } //Length: 308
	}

	public SlowMutator Mutator
	{
		 get { } //Length: 280
	}

	public SlowModel(string name, float multiplier, float lifespan, string mutationId, int layers, string overlayType, bool isUnique, bool dontRefreshDuration, EffectModel effectModel, bool cascadeMutators, bool removeMutatorIfNotMatching, bool countGlueAchievement, float chance, int glueLevel = 0, bool matchLayersWithDamage = false, bool dontRemoveOnBloonDegrade = false) { }

	public virtual Model Clone() { }

	public float get_Lifespan() { }

	public float get_Multiplier() { }

	public SlowMutator get_Mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Lifespan(float value) { }

	public void set_Multiplier(float value) { }

}

