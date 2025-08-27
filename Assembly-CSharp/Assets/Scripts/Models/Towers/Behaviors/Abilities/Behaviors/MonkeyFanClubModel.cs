namespace Assets.Scripts.Models.Towers.Behaviors.Abilities.Behaviors;

[Implementation(typeof(MonkeyFanClub), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MonkeyFanClubModel : AbilityBehaviorModel
{
	[SerializeField]
	private float lifespan; //Field offset: 0x30
	public int lifespanFrames; //Field offset: 0x34
	public int maxTier; //Field offset: 0x38
	public int towerCount; //Field offset: 0x3C
	public float range; //Field offset: 0x40
	public float reloadModifier; //Field offset: 0x44
	public BloonProperties immuneBloonProperties; //Field offset: 0x48
	public PrefabReference display; //Field offset: 0x50
	public PrefabReference towerDisplay; //Field offset: 0x58
	public PrefabReference originDisplay; //Field offset: 0x60
	public PrefabReference towerOriginDisplay; //Field offset: 0x68
	public PrefabReference effectId; //Field offset: 0x70
	public PrefabReference effectLeaderId; //Field offset: 0x78
	public PrefabReference effectOnOtherId; //Field offset: 0x80
	public float bonusPierce; //Field offset: 0x88
	public float projectileRadius; //Field offset: 0x8C
	public int bonusDamage; //Field offset: 0x90
	public EffectModel effectModel; //Field offset: 0x98
	public EjectEffectModel handBlurEjectEffectModel; //Field offset: 0xA0
	public float ejectX; //Field offset: 0xA8
	public float ejectY; //Field offset: 0xAC
	public float ejectZ; //Field offset: 0xB0
	public DisplayModel otherDisplayModel; //Field offset: 0xB8
	public DisplayModel displayModel; //Field offset: 0xC0
	public DisplayModel leaderDisplayModel; //Field offset: 0xC8
	public CreateEffectAfterTimeModel endDisplayModel; //Field offset: 0xD0
	public string ignoreWithMutators; //Field offset: 0xD8
	public String[] ignoreWithMutatorsList; //Field offset: 0xE0

	public MonkeyFanClubModel(string name, float lifespan, int maxTier, int towerCount, float range, float reloadModifier, BloonProperties immuneBloonProperties, PrefabReference display, PrefabReference towerDisplay, PrefabReference originDisplay, PrefabReference towerOriginDisplay, PrefabReference effectId, PrefabReference effectLeaderId, PrefabReference effectOnOtherId, EffectModel effectModel, float bonusPierce, float projectileRadius, int bonusDamage, EjectEffectModel handBlurEjectEffectModel, float ejectX, float ejectY, float ejectZ, string ignoreWithMutators) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

