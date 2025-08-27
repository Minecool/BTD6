namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "PyrotechnicsSupport", menuName = "BTD6/Behaviors/Towers/PyrotechnicsSupport")]
public class PyrotechnicsSupport : SupportBehavior
{
	public bool isUnique; //Field offset: 0x48
	public float percentIncrease; //Field offset: 0x4C
	public string mutatorId; //Field offset: 0x50
	public int priority; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 255
	}

	public PyrotechnicsSupport() { }

	public virtual TowerBehaviorModel get_Def() { }

}

