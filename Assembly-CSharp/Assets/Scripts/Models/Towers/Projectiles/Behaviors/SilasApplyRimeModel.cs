namespace Assets.Scripts.Models.Towers.Projectiles.Behaviors;

[Implementation(typeof(SilasApplyRime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class SilasApplyRimeModel : ProjectileBehaviorModel
{
	internal class Mutator : BehaviorMutator
	{
		public float rimeSpeedModifier; //Field offset: 0x70
		public float rimeMoabSpeedModifier; //Field offset: 0x74
		public string rimeOverlayType; //Field offset: 0x78
		public BloonBehaviorModel[] rimeBehaviors; //Field offset: 0x80
		public string mutationId; //Field offset: 0x88

		public Mutator(float rimeSpeedModifier, float rimeMoabSpeedModifier, string rimeOverlayType, BloonBehaviorModel[] rimeBehaviors, string mutationId, int mutationPrio) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	[Header("Rime Variables")]
	public float speedModifier; //Field offset: 0x38
	public float moabSpeedModifier; //Field offset: 0x3C
	public string rimeMutationId; //Field offset: 0x40
	public string rimeOverlayType; //Field offset: 0x48
	public bool canAttackWhiteBloons; //Field offset: 0x50
	public BloonBehaviorModel[] behaviors; //Field offset: 0x58
	public int mutationPrio; //Field offset: 0x60
	[Header("Freeze Variables")]
	public float freezeSpeed; //Field offset: 0x64
	public int freezeLayers; //Field offset: 0x68
	public string freezeMutationId; //Field offset: 0x70
	public float freezePercentChanceToFreeze; //Field offset: 0x78
	public bool freezeEnablePercentChangeToFreeze; //Field offset: 0x7C
	[SerializeReference]
	public DamageModel damageModel; //Field offset: 0x80
	public bool canFreezeMoabs; //Field offset: 0x88
	public bool freezeCascadeMutators; //Field offset: 0x89
	public GrowBlockModel growBlockModel; //Field offset: 0x90
	public bool freezeApplyAfterDamage; //Field offset: 0x98
	public float freezeLifespan; //Field offset: 0x9C
	public string freezeOverlayType; //Field offset: 0xA0
	private float freezeLifeSpanBase; //Field offset: 0xA8
	[Header("Explosion Variables")]
	public ProjectileModel explosionProjectileModel; //Field offset: 0xB0
	public EmissionModel explosionEmissionModel; //Field offset: 0xB8
	private Mutator _mutator; //Field offset: 0xC0
	private Mutator _freezeMutator; //Field offset: 0xC8

	public float FreezeLifespanBase
	{
		 get { } //Length: 9
	}

	public float FreezeLifespanFrames
	{
		 get { } //Length: 28
	}

	public Mutator freezeMutator
	{
		 get { } //Length: 246
	}

	public Mutator mutator
	{
		 get { } //Length: 348
	}

	public SilasApplyRimeModel(string name, float speedModifier, float moabSpeedModifier, string rimeMutationId, string rimeOverlayType, bool canAttackWhiteBloons, BloonBehaviorModel[] behaviors, float freezeSpeed, int freezeLayers, string freezeMutationId, float freezePercentChanceToFreeze, bool freezeEnablePercentChangeToFreeze, DamageModel damageModel, bool canFreezeMoabs, bool freezeCascadeMutators, GrowBlockModel growBlockModel, string freezeOverlayType, bool freezeApplyAfterDamage, float freezeLifespanBase, ProjectileModel explosionProjectileModel, EmissionModel explosionEmissionModel, int mutationPrio) { }

	public virtual Model Clone() { }

	public float get_FreezeLifespanBase() { }

	public float get_FreezeLifespanFrames() { }

	public Mutator get_freezeMutator() { }

	public Mutator get_mutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

