namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DiscountZone", menuName = "BTD6/Behaviors/Towers/DiscountZone")]
public class DiscountZone : TowerBehaviorBuff
{
	public float discountMultiplier; //Field offset: 0x38
	public float stackLimit; //Field offset: 0x3C
	public string stackName; //Field offset: 0x40
	public string groupName; //Field offset: 0x48
	public bool affectSelf; //Field offset: 0x50
	public int tierCap; //Field offset: 0x54
	public string towerBaseIds; //Field offset: 0x58
	public string upgradeId; //Field offset: 0x60
	public bool dontAffectOthersInCoop; //Field offset: 0x68

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 292
	}

	public DiscountZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

