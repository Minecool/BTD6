namespace Assets.Scripts.Data.Behaviors.Bloons;

[CreateAssetMenu(fileName = "DamageOverTime", menuName = "BTD6/Behaviors/Bloons/DamageOverTime")]
public class DamageOverTime : BloonBehavior
{
	public int damage; //Field offset: 0x30
	public float interval; //Field offset: 0x34
	public string damageType; //Field offset: 0x38
	public string ignoreImmunityForBloonTypes; //Field offset: 0x40
	public PrefabReference display; //Field offset: 0x48
	public float displayLifespan; //Field offset: 0x50
	public bool triggerImmediate; //Field offset: 0x54
	public bool rotateEffectWithBloon; //Field offset: 0x55
	public float initialDelay; //Field offset: 0x58
	public bool damageOnDestroy; //Field offset: 0x5C
	public bool overrideDistributionBlocker; //Field offset: 0x5D
	public bool dontDistributeToChildren; //Field offset: 0x5E
	public DamageModifier[] damageModifier; //Field offset: 0x60

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 540
	}

	public DamageOverTime() { }

	public virtual BloonBehaviorModel get_Def() { }

}

