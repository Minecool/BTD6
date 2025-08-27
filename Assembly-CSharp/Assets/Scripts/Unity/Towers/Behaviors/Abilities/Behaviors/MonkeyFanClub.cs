namespace Assets.Scripts.Unity.Towers.Behaviors.Abilities.Behaviors;

public class MonkeyFanClub : AbilityBehavior
{
	public MonkeyFanClub parent; //Field offset: 0x88
	public float lifespan; //Field offset: 0x90
	public string expLifespan; //Field offset: 0x98
	public float maxTier; //Field offset: 0xA0
	public string expMaxTier; //Field offset: 0xA8
	public float towerCount; //Field offset: 0xB0
	public string expTowerCount; //Field offset: 0xB8
	public float range; //Field offset: 0xC0
	public string expRange; //Field offset: 0xC8
	public float reloadModifier; //Field offset: 0xD0
	public string expReloadModifier; //Field offset: 0xD8
	public string damageType; //Field offset: 0xE0
	public string expDamageType; //Field offset: 0xE8
	public float bonusPierce; //Field offset: 0xF0
	public string expBonusPierce; //Field offset: 0xF8
	public float projectileRadius; //Field offset: 0x100
	public string expProjectileRadius; //Field offset: 0x108
	public int bonusDamage; //Field offset: 0x110
	public string expBonusDamage; //Field offset: 0x118
	public GameObject originDisplay; //Field offset: 0x120
	public GameObject expOriginDisplay; //Field offset: 0x128
	public GameObject towerOriginDisplay; //Field offset: 0x130
	public GameObject expTowerOriginDisplay; //Field offset: 0x138
	public GameObject display; //Field offset: 0x140
	public GameObject expDisplay; //Field offset: 0x148
	public GameObject towerDisplay; //Field offset: 0x150
	public GameObject expTowerDisplay; //Field offset: 0x158
	public GameObject effectDisplay; //Field offset: 0x160
	public GameObject expEffectDisplay; //Field offset: 0x168
	public GameObject effectDisplayLeader; //Field offset: 0x170
	public GameObject expEffectDisplayLeader; //Field offset: 0x178
	public GameObject effectOnOthersDisplay; //Field offset: 0x180
	public GameObject expEffectOnOthersDisplay; //Field offset: 0x188
	public Effect degradeEffect; //Field offset: 0x190
	public Effect expDegradeEffect; //Field offset: 0x198
	public EjectEffect handBlurEjectEffect; //Field offset: 0x1A0
	public GameObject throwMarker; //Field offset: 0x1A8
	public GameObject expThrowMarker; //Field offset: 0x1B0
	public string ignoreWithMutators; //Field offset: 0x1B8
	public string expIgnoreWithMutators; //Field offset: 0x1C0

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1472
	}

	public MonkeyFanClub() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

