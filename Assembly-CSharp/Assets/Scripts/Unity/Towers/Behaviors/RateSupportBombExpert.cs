namespace Assets.Scripts.Unity.Towers.Behaviors;

public class RateSupportBombExpert : SupportBehavior
{
	[FormerlySerializedAs("isUnique")]
	public bool isThisUnique; //Field offset: 0xC8
	[FormerlySerializedAs("expIsUnique")]
	public string expIsThisUnique; //Field offset: 0xD0
	public float rangeMultiplier; //Field offset: 0xD8
	public string expRangeMultiplier; //Field offset: 0xE0
	public float pierceMultiplier; //Field offset: 0xE8
	public string expPierceMultiplier; //Field offset: 0xF0
	public bool isGlobal; //Field offset: 0xF8
	public string expIsGlobal; //Field offset: 0x100

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 257
	}

	public RateSupportBombExpert() { }

	public virtual TowerBehaviorModel get_Def() { }

}

