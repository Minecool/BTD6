namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(DamageOverTime), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DamageOverTimeModel : BloonBehaviorModelWithTowerTracking
{
	public float damage; //Field offset: 0x38
	public int payloadCount; //Field offset: 0x3C
	public BloonProperties immuneBloonProperties; //Field offset: 0x40
	public BloonProperties immuneBloonPropertiesOriginal; //Field offset: 0x44
	[SerializeField]
	protected float interval; //Field offset: 0x48
	public int intervalFrames; //Field offset: 0x4C
	public PrefabReference displayPath; //Field offset: 0x50
	public float displayLifetime; //Field offset: 0x58
	public bool triggerImmediate; //Field offset: 0x5C
	public bool rotateEffectWithBloon; //Field offset: 0x5D
	[SerializeField]
	protected float initialDelay; //Field offset: 0x60
	public int initialDelayFrames; //Field offset: 0x64
	public bool damageOnDestroy; //Field offset: 0x68
	public bool overrideDistributionBlocker; //Field offset: 0x69
	public bool distributeToChildren; //Field offset: 0x6A
	[SerializeReference]
	public DamageModifierModel[] damageModifierModels; //Field offset: 0x70
	public bool isFireBased; //Field offset: 0x78

	public float Interval
	{
		 get { } //Length: 6
		 set { } //Length: 21
	}

	public DamageOverTimeModel() { }

	public DamageOverTimeModel(string name, float damage, float interval, BloonProperties immuneBloonProperties, BloonProperties immuneBloonPropertiesOriginal, PrefabReference displayPath, float displayLifetime, bool triggerImmediate, ObjectId tower, bool rotateEffectWithBloon, float initialDelay, bool damageOnDestroy, bool overrideDistributionBlocker, bool distributeToChildren, DamageModifierModel[] damageModifierModels, bool isFireBased) { }

	public virtual Model Clone() { }

	public float get_Interval() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

	public void set_Interval(float value) { }

}

