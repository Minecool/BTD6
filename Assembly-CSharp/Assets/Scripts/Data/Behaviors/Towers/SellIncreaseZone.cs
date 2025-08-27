namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SellIncreaseZone", menuName = "BTD6/Behaviors/Towers/SellIncreaseZone")]
public class SellIncreaseZone : TowerBehavior
{
	public float sellMultiplier; //Field offset: 0x30
	public string stackName; //Field offset: 0x38
	public TowerFilter[] filters; //Field offset: 0x40

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 175
	}

	public SellIncreaseZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

