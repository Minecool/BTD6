namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RangeSupport : SupportBehavior
{
	public RangeSupport parent; //Field offset: 0xC8
	public bool isUnique; //Field offset: 0xD0
	public string expIsUnique; //Field offset: 0xD8
	public float multiplier; //Field offset: 0xE0
	public string expMultiplier; //Field offset: 0xE8
	public float additive; //Field offset: 0xF0
	public string expAdditive; //Field offset: 0xF8
	public string mutatorId; //Field offset: 0x100
	public string expMutatorId; //Field offset: 0x108
	public bool isGlobal; //Field offset: 0x110
	public string expIsGlobal; //Field offset: 0x118

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 363
	}

	public RangeSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

