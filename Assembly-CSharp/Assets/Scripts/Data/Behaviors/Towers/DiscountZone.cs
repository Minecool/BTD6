namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "DiscountZone", menuName = "BTD6/Behaviors/Towers/DiscountZone")]
public class DiscountZone : TowerBehaviorBuff
{
	public float discountMultiplier; //Field offset: 0x38
	public float stackLimit; //Field offset: 0x3C
	public string stackName; //Field offset: 0x40
	public bool affectSelf; //Field offset: 0x48
	public int tierCap; //Field offset: 0x4C
	public string towerBaseIds; //Field offset: 0x50
	public string upgradeId; //Field offset: 0x58
	public bool dontAffectOthersInCoop; //Field offset: 0x60
	public bool isGlobal; //Field offset: 0x61
	public int tierMin; //Field offset: 0x64

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 310
	}

	public DiscountZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

