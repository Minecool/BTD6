namespace Assets.Scripts.Unity.Bloons.Behaviors;

public class DamageOverTime : BloonBehavior
{
	public int damage; //Field offset: 0x88
	public string expDamage; //Field offset: 0x90
	public float interval; //Field offset: 0x98
	public string expInterval; //Field offset: 0xA0
	public string damageType; //Field offset: 0xA8
	public string expDamageType; //Field offset: 0xB0
	public string ignoreImmunityForBloonTypes; //Field offset: 0xB8
	public string expIgnoreImmunityForBloonTypes; //Field offset: 0xC0
	public GameObject display; //Field offset: 0xC8
	public GameObject expDisplay; //Field offset: 0xD0
	public float displayLifespan; //Field offset: 0xD8
	public string expDisplayLifespan; //Field offset: 0xE0
	public bool triggerImmediate; //Field offset: 0xE8
	public string expTriggerImmediate; //Field offset: 0xF0
	public bool rotateEffectWithBloon; //Field offset: 0xF8
	public string expRotateEffectWithBloon; //Field offset: 0x100
	public float initialDelay; //Field offset: 0x108
	public string expInitialDelay; //Field offset: 0x110
	public bool damageOnDestroy; //Field offset: 0x118
	public string expDamageOnDestroy; //Field offset: 0x120
	public bool overrideDistributionBlocker; //Field offset: 0x128
	public string expOverrideDistributionBlocker; //Field offset: 0x130
	public bool dontDistributeToChildren; //Field offset: 0x138
	public string expDontDistributeToChildren; //Field offset: 0x140
	public DamageModifier damageModifier1; //Field offset: 0x148
	public DamageModifier expDamageModifier1; //Field offset: 0x150
	public DamageModifier damageModifier2; //Field offset: 0x158
	public DamageModifier expDamageModifier2; //Field offset: 0x160
	public DamageModifier damageModifier3; //Field offset: 0x168
	public DamageModifier expDamageModifier3; //Field offset: 0x170
	public DamageModifier damageModifier4; //Field offset: 0x178
	public DamageModifier expDamageModifier4; //Field offset: 0x180

	public virtual BloonBehaviorModel Def
	{
		 get { } //Length: 2165
	}

	public DamageOverTime() { }

	public virtual BloonBehaviorModel get_Def() { }

}

