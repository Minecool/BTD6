namespace Assets.Scripts.Data.Behaviors.Abilities;

[CreateAssetMenu(fileName = "MonkeyFanClub", menuName = "BTD6/Behaviors/Abilities/MonkeyFanClub")]
public class MonkeyFanClub : AbilityBehavior
{
	public float lifespan; //Field offset: 0x30
	public float maxTier; //Field offset: 0x34
	public float towerCount; //Field offset: 0x38
	public float range; //Field offset: 0x3C
	public float reloadModifier; //Field offset: 0x40
	public string damageType; //Field offset: 0x48
	public float bonusPierce; //Field offset: 0x50
	public float projectileRadius; //Field offset: 0x54
	public int bonusDamage; //Field offset: 0x58
	public PrefabReference originDisplay; //Field offset: 0x60
	public PrefabReference towerOriginDisplay; //Field offset: 0x68
	public PrefabReference display; //Field offset: 0x70
	public PrefabReference towerDisplay; //Field offset: 0x78
	public PrefabReference effectDisplay; //Field offset: 0x80
	public PrefabReference effectDisplayLeader; //Field offset: 0x88
	public PrefabReference effectOnOthersDisplay; //Field offset: 0x90
	public Effect degradeEffect; //Field offset: 0x98
	public EjectEffect handBlurEjectEffect; //Field offset: 0xA0
	public OffsetPosition throwMarker; //Field offset: 0xA8
	public string ignoreWithMutators; //Field offset: 0xB0

	public virtual AbilityBehaviorModel Def
	{
		 get { } //Length: 1014
	}

	public MonkeyFanClub() { }

	public virtual AbilityBehaviorModel get_Def() { }

}

