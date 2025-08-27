namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DruidVengeanceEffect", menuName = "BTD6/Behaviors/Towers/DruidVengeanceEffect")]
public class DruidVengeanceEffect : TowerBehavior
{
	public Effect smallGlowEffect; //Field offset: 0x30
	public Effect mediumGlowEffect; //Field offset: 0x38
	public Effect epicGlowEffect; //Field offset: 0x40
	public PrefabReference defaultProjectile; //Field offset: 0x48
	public PrefabReference weakProjectile; //Field offset: 0x50
	public PrefabReference mediumProjectile; //Field offset: 0x58
	public PrefabReference epicProjectile; //Field offset: 0x60
	public int smallGlowEffectStacks; //Field offset: 0x68
	public int mediumGlowEffectStacks; //Field offset: 0x6C
	public int epicGlowEffectStacks; //Field offset: 0x70
	public DamageModifierWrath damageModifierWrath; //Field offset: 0x78

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 556
	}

	public DruidVengeanceEffect() { }

	public virtual TowerBehaviorModel get_Def() { }

}

