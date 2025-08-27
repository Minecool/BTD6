namespace Assets.Scripts.Data.Behaviors.Towers;

[CreateAssetMenu(fileName = "CashbackZone", menuName = "BTD6/Behaviors/Towers/CashbackZone")]
public class CashbackZone : TowerBehavior
{
	public float cashbackZoneMultiplier; //Field offset: 0x30
	public float cashbackMaxPercent; //Field offset: 0x34
	public string groupName; //Field offset: 0x38
	public int maxStacks; //Field offset: 0x40
	public string buffLocsName; //Field offset: 0x48
	public string buffIconName; //Field offset: 0x50
	public string baseIds; //Field offset: 0x58

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 213
	}

	public CashbackZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

