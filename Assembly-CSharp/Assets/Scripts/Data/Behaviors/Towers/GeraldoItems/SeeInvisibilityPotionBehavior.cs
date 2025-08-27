namespace Assets.Scripts.Data.Behaviors.Towers.GeraldoItems;

[CreateAssetMenu(fileName = "SeeInvisibilityPotionBehavior", menuName = "BTD6/Behaviors/Towers/GeraldoItems/SeeInvisibilityPotionBehavior")]
public class SeeInvisibilityPotionBehavior : GeraldoItemBehavior
{
	public int rounds; //Field offset: 0x28
	public PrefabReference buffDisplay; //Field offset: 0x30
	public string buffLocsName; //Field offset: 0x38
	public string buffIconName; //Field offset: 0x40
	public PrefabReference effectAtTower; //Field offset: 0x48
	public int upgradeV2At; //Field offset: 0x50
	public int roundsUpgradedTo; //Field offset: 0x54
	public float upgradedRangeScale; //Field offset: 0x58
	public int upgradeV3At; //Field offset: 0x5C
	public int bonusCamoDamage; //Field offset: 0x60

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 256
	}

	public SeeInvisibilityPotionBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

