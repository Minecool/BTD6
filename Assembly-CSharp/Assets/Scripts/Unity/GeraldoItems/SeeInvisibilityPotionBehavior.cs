namespace Assets.Scripts.Unity.GeraldoItems;

public class SeeInvisibilityPotionBehavior : GeraldoItemBehavior
{
	[SerializeField]
	private int rounds; //Field offset: 0x10
	[SerializeField]
	private PrefabReference buffDisplay; //Field offset: 0x18
	[SerializeField]
	private string buffLocsName; //Field offset: 0x20
	[SerializeField]
	private string buffIconName; //Field offset: 0x28
	[SerializeField]
	private PrefabReference effectAtTower; //Field offset: 0x30
	[SerializeField]
	private int upgradeV2At; //Field offset: 0x38
	[SerializeField]
	private int roundsUpgradedTo; //Field offset: 0x3C
	[SerializeField]
	private float upgradedRangeScale; //Field offset: 0x40
	[SerializeField]
	private int upgradeV3At; //Field offset: 0x44
	[SerializeField]
	private int bonusCamoDamage; //Field offset: 0x48

	public virtual GeraldoItemBehaviorModel Def
	{
		 get { } //Length: 256
	}

	public SeeInvisibilityPotionBehavior() { }

	public virtual GeraldoItemBehaviorModel get_Def() { }

}

