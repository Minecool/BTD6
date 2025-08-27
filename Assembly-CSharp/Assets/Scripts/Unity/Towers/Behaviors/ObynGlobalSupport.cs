namespace Assets.Scripts.Unity.Towers.Behaviors;

public class ObynGlobalSupport : TowerBehavior
{
	public ObynGlobalSupport parent; //Field offset: 0x98
	public float dotjRangeMultiplier; //Field offset: 0xA0
	public string expDotjRangeMultiplier; //Field offset: 0xA8
	public float dotsProjectileRadius; //Field offset: 0xB0
	public string expDotsProjectileRadius; //Field offset: 0xB8
	public float dotsMoabDamage; //Field offset: 0xC0
	public string expDotsMoabDamage; //Field offset: 0xC8
	public float tornadoAttackCooldownReduction; //Field offset: 0xD0
	public string expTornadoAttackCooldownReduction; //Field offset: 0xD8
	public float mmAbilityCooldownMultiplier; //Field offset: 0xE0
	public string expMmAbilityCooldownMultiplier; //Field offset: 0xE8
	public string mutatorIdRange; //Field offset: 0xF0
	public string expMutatorIdRange; //Field offset: 0xF8
	public string mutatorIdProjectileRadius; //Field offset: 0x100
	public string expMutatorIdProjectileRadius; //Field offset: 0x108
	public string mutatorIdMoabDamage; //Field offset: 0x110
	public string expMutatorIdMoabDamage; //Field offset: 0x118
	public string mutatorIdCooldownMultiplier; //Field offset: 0x120
	public string expMutatorIdCooldownMultiplier; //Field offset: 0x128
	public string mutatorIdTornadoRateMultiplier; //Field offset: 0x130
	public string expMutatorIdTornadoRateMultiplier; //Field offset: 0x138

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 317
	}

	public ObynGlobalSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

