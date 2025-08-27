namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "BonusCashZone", menuName = "BTD6/Behaviors/Towers/BonusCashZone")]
public class BonusCashZone : TowerBehavior
{
	public float multiplier; //Field offset: 0x30
	public int stackLimit; //Field offset: 0x34
	public string stackName; //Field offset: 0x38
	public string groupName; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 167
	}

	public BonusCashZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

