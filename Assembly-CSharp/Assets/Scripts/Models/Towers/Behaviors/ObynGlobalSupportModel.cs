namespace Assets.Scripts.Models.Towers.Behaviors;

[Implementation(typeof(ObynGlobalSupport), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class ObynGlobalSupportModel : TowerBehaviorModel
{
	internal class AbilityCooldownMutatorClass : BehaviorMutator
	{
		private readonly float mmAbilityCooldownMultiplier; //Field offset: 0x70

		public AbilityCooldownMutatorClass(float mmAbilityCooldownMultiplier, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class DamageTypeMutatorClass : BehaviorMutator
	{
		private readonly DamageModifierForTagModel damageModifierForTagModel; //Field offset: 0x70

		public DamageTypeMutatorClass(DamageModifierForTagModel damageModifierForTagModel, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class ProjectileRadiusMutatorClass : BehaviorMutator
	{
		public readonly float dotsProjectileRadius; //Field offset: 0x70

		public ProjectileRadiusMutatorClass(float dotsProjectileRadius, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class RangeMutatorClass : BehaviorMutator
	{
		public readonly float rangeModifier; //Field offset: 0x70

		public RangeMutatorClass(float rangeModifier, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	internal class TornadoRateMutatorClass : BehaviorMutator
	{
		private readonly float rateMultiplier; //Field offset: 0x70

		public TornadoRateMutatorClass(float rateMultiplier, string mutatorId) { }

		public virtual bool Mutate(Model baseModel, Model model) { }

	}

	public float dotjRangeMultiplier; //Field offset: 0x30
	public float dotsProjectileRadius; //Field offset: 0x34
	public float dotsMoabDamage; //Field offset: 0x38
	public float tornadoAttackCooldownReduction; //Field offset: 0x3C
	public float mmAbilityCooldownMultiplier; //Field offset: 0x40
	public string mutatorIdRange; //Field offset: 0x48
	public string mutatorIdProjectileRadius; //Field offset: 0x50
	public string mutatorIdMoabDamage; //Field offset: 0x58
	public string mutatorIdCooldownMultiplier; //Field offset: 0x60
	public string mutatorIdTornadoRateMultiplier; //Field offset: 0x68
	public DamageModifierForTagModel damageModifierForTag; //Field offset: 0x70
	private RangeMutatorClass rangeMutator; //Field offset: 0x78
	private ProjectileRadiusMutatorClass projectileRadiusMutator; //Field offset: 0x80
	private DamageTypeMutatorClass damageTypeMutator; //Field offset: 0x88
	private AbilityCooldownMutatorClass abilityCooldownMutator; //Field offset: 0x90
	private TornadoRateMutatorClass tornadoRateMutator; //Field offset: 0x98

	public AbilityCooldownMutatorClass AbilityCooldownMutator
	{
		 get { } //Length: 243
	}

	public DamageTypeMutatorClass DamageTypeMutator
	{
		 get { } //Length: 235
	}

	public ProjectileRadiusMutatorClass ProjectileRadiusMutator
	{
		 get { } //Length: 243
	}

	public RangeMutatorClass RangeMutator
	{
		 get { } //Length: 237
	}

	public TornadoRateMutatorClass TornadoRateMutator
	{
		 get { } //Length: 243
	}

	public ObynGlobalSupportModel(string name, float dotjRangeMultiplier, float dotsProjectileRadius, float dotsMoabDamage, float tornadoAttackCooldownReduction, float mmAbilityCooldownMultiplier, string mutatorIdRange, string mutatorIdProjectileRadius, string mutatorIdMoabDamage, string mutatorIdCooldownMultiplier, string mutatorIdTornadoRateMultiplier) { }

	public virtual Model Clone() { }

	public AbilityCooldownMutatorClass get_AbilityCooldownMutator() { }

	public DamageTypeMutatorClass get_DamageTypeMutator() { }

	public ProjectileRadiusMutatorClass get_ProjectileRadiusMutator() { }

	public RangeMutatorClass get_RangeMutator() { }

	public TornadoRateMutatorClass get_TornadoRateMutator() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

