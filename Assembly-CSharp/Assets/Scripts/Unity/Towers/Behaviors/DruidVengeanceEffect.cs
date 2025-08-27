namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DruidVengeanceEffect : TowerBehavior
{
	public DruidVengeanceEffect parent; //Field offset: 0x98
	public Effect smallGlowEffect; //Field offset: 0xA0
	public Effect expSmallGlowEffect; //Field offset: 0xA8
	public Effect mediumGlowEffect; //Field offset: 0xB0
	public Effect expMediumGlowEffect; //Field offset: 0xB8
	public Effect epicGlowEffect; //Field offset: 0xC0
	public Effect expEpicGlowEffect; //Field offset: 0xC8
	public GameObject defaultProjectile; //Field offset: 0xD0
	public GameObject expDefaultProjectile; //Field offset: 0xD8
	public GameObject weakProjectile; //Field offset: 0xE0
	public GameObject expWeakProjectile; //Field offset: 0xE8
	public GameObject mediumProjectile; //Field offset: 0xF0
	public GameObject expMediumProjectile; //Field offset: 0xF8
	public GameObject epicProjectile; //Field offset: 0x100
	public GameObject expEpicProjectile; //Field offset: 0x108
	public int smallGlowEffectStacks; //Field offset: 0x110
	public int mediumGlowEffectStacks; //Field offset: 0x114
	public int epicGlowEffectStacks; //Field offset: 0x118
	public string expSmallGlowEffectStacks; //Field offset: 0x120
	public string expMediumGlowEffectStacks; //Field offset: 0x128
	public string expEpicGlowEffectStacks; //Field offset: 0x130
	public DamageModifierWrath damageModifierWrath; //Field offset: 0x138
	public DamageModifierWrath expDamageModifierWrath; //Field offset: 0x140

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 622
	}

	public DruidVengeanceEffect() { }

	public virtual TowerBehaviorModel get_Def() { }

}

