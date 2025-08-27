namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "SellIncreaseZone", menuName = "BTD6/Behaviors/Towers/SellIncreaseZone")]
public class SellIncreaseZone : TowerBehaviorBuff
{
	public float sellMultiplier; //Field offset: 0x38
	public string stackName; //Field offset: 0x40
	public TowerFilter[] filters; //Field offset: 0x48
	public int stackLimit; //Field offset: 0x50
	public string towerBaseIds; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 196
	}

	public SellIncreaseZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

