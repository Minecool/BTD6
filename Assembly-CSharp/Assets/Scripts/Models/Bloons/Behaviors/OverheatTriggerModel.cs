namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(OverheatTrigger), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class OverheatTriggerModel : BloonBehaviorTriggerModel
{
	internal class OverheatMutator : BehaviorMutator
	{
		public PrefabReference projectileExplosionEffect; //Field offset: 0x70
		public float projectileBurnLifespan; //Field offset: 0x78

		public OverheatMutator(bool isUnique, string mutatorId, int priority, BuffIndicatorModel buffIndicator, PrefabReference projectileExplosionEffect, float projectileBurnLifespan) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public const string mutatorStunID = "TowerStun"; //Field offset: 0x0
	public const string mutatorID = "OverheatDebuff"; //Field offset: 0x0
	public PrefabReference projectileExplosionEffect; //Field offset: 0x30
	public PrefabReference stunEffect; //Field offset: 0x38
	public PrefabReference fullscreenEffect; //Field offset: 0x40
	public AudioClipReference[] sounds; //Field offset: 0x48
	public float maxHeatLevel; //Field offset: 0x50
	public float heatEffectCooldown; //Field offset: 0x54
	public float heatEffectDuration; //Field offset: 0x58
	public float immuneHeat; //Field offset: 0x5C
	public float damagedHeat; //Field offset: 0x60
	public float heatIdleDelay; //Field offset: 0x64
	public float abilityCooldownAddition; //Field offset: 0x68
	public float passiveHeatReduction; //Field offset: 0x6C
	public float idleHeatReduction; //Field offset: 0x70
	public float iceHeatReduction; //Field offset: 0x74
	public float projectileBurnLifespan; //Field offset: 0x78
	public float heatDecayStrength; //Field offset: 0x7C
	public float stunDuration; //Field offset: 0x80
	public string animTriggerId; //Field offset: 0x88
	public bool fillHeatOnSpawn; //Field offset: 0x90
	private OverheatMutator mutator; //Field offset: 0x98
	private TowerFreezeMutator mutatorStun; //Field offset: 0xA0

	public OverheatMutator Mutator
	{
		 get { } //Length: 282
	}

	public TowerFreezeMutator MutatorStun
	{
		 get { } //Length: 156
	}

	public OverheatTriggerModel(string name, PrefabReference projectileExplosionEffect, float maxHeatLevel, float heatEffectCooldown, float heatEffectDuration, float immuneHeat, float damagedHeat, float heatIdleDelay, float abilityCooldownAddition, float passiveHeatReduction, float idleHeatReduction, float iceHeatReduction, float projectileBurnLifespan, float heatDecayStrength, float stunDuration, PrefabReference stunEffect, string animTriggerId, bool fillHeatOnSpawn, PrefabReference fullscreenEffect, AudioClipReference[] sounds) { }

	public virtual Model Clone() { }

	public OverheatMutator get_Mutator() { }

	public TowerFreezeMutator get_MutatorStun() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

