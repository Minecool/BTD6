namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "RateSupport", menuName = "BTD6/Behaviors/Towers/RateSupport")]
public class RateSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float multiplier; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50
	public string isGlobal; //Field offset: 0x58
	public int priority; //Field offset: 0x60

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 334
	}

	public RateSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

