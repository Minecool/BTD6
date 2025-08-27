namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RateSupportBombExpert", menuName = "BTD6/Behaviors/Towers/RateSupportBombExpert")]
public class RateSupportBombExpert : SupportBehavior
{
	public bool isThisUnique; //Field offset: 0x48
	public float rangeMultiplier; //Field offset: 0x4C
	public float pierceMultiplier; //Field offset: 0x50
	public bool isGlobal; //Field offset: 0x54

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 280
	}

	public RateSupportBombExpert() { }

	public virtual TowerBehaviorModel get_Def() { }

}

