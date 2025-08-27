namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SupportShinobiTactics", menuName = "BTD6/Behaviors/Towers/SupportShinobiTactics")]
public class SupportShinobiTactics : SupportBehavior
{
	public string mutatorId; //Field offset: 0x48
	public int maxStacks; //Field offset: 0x50
	public float multiplier; //Field offset: 0x54

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 282
	}

	public SupportShinobiTactics() { }

	public virtual TowerBehaviorModel get_Def() { }

}

