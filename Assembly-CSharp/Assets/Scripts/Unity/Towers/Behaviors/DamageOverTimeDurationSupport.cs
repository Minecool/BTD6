namespace Assets.Scripts.Unity.Towers.Behaviors;

public class DamageOverTimeDurationSupport : SupportBehavior
{
	public DamageOverTimeDurationSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float durationMultiplier; //Field offset: 0xE0
	public string expDurationMultiplier; //Field offset: 0xE8
	public string mutatorId; //Field offset: 0xF0
	public string expMutatorId; //Field offset: 0xF8
	public bool isGlobal; //Field offset: 0x100
	public string expIsGlobal; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 273
	}

	public DamageOverTimeDurationSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

