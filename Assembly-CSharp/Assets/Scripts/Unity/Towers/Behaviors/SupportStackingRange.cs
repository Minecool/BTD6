namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SupportStackingRange : SupportBehavior
{
	public SupportStackingRange parent; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8
	public int maxStacks; //Field offset: 0xE0
	public string expMaxStacks; //Field offset: 0xE8
	public float rangeMultiplier; //Field offset: 0xF0
	public string expRangeMultiplier; //Field offset: 0xF8
	public bool isGlobalRange; //Field offset: 0x100
	public string expIsGlobalRange; //Field offset: 0x108

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 331
	}

	public SupportStackingRange() { }

	public virtual TowerBehaviorModel get_Def() { }

}

