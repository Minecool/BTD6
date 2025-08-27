namespace Assets.Scripts.Unity.Towers.Behaviors;

public class SupportShinobiTactics : SupportBehavior
{
	public SupportShinobiTactics parent; //Field offset: 0xC8
	public string mutatorId; //Field offset: 0xD0
	public string expMutatorId; //Field offset: 0xD8
	public int maxStacks; //Field offset: 0xE0
	public string expMaxStacks; //Field offset: 0xE8
	public float multiplier; //Field offset: 0xF0
	public string expMultiplier; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 323
	}

	public SupportShinobiTactics() { }

	public virtual TowerBehaviorModel get_Def() { }

}

