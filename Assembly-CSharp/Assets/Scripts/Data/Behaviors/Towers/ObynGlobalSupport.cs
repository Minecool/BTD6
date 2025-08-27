namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ObynGlobalSupport", menuName = "BTD6/Behaviors/Towers/ObynGlobalSupport")]
public class ObynGlobalSupport : TowerBehavior
{
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

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 287
	}

	public ObynGlobalSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

