namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "ComancheDefence", menuName = "BTD6/Behaviors/Towers/ComancheDefence")]
public class ComancheDefence : TowerBehavior
{
	public Tower tower; //Field offset: 0x30
	public int reinforcementCount; //Field offset: 0x38
	public float duration; //Field offset: 0x3C
	public float cooldown; //Field offset: 0x40
	public bool immediate; //Field offset: 0x44
	public Sound sound; //Field offset: 0x48
	public int maxActivationsPerRound; //Field offset: 0x50

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 362
	}

	public ComancheDefence() { }

	public virtual TowerBehaviorModel get_Def() { }

}

