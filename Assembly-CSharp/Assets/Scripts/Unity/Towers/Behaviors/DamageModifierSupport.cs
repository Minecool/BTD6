namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DamageModifierSupport : SupportBehavior
{
	public DamageModifierSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public string mutatorId; //Field offset: 0xE0
	public string expMutatorId; //Field offset: 0xE8
	public bool isGlobal; //Field offset: 0xF0
	public string expIsGlobal; //Field offset: 0xF8
	public DamageModifier damageModifier; //Field offset: 0x100
	public DamageModifier expDamageModifier; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 356
	}

	public DamageModifierSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

