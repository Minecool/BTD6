namespace Assets.Scripts.Unity.Towers.Behaviors;

public class CashbackZone : TowerBehaviorBuff
{
	public CashbackZone parent; //Field offset: 0xB8
	public float cashbackZoneMultiplier; //Field offset: 0xC0
	public string expCashbackZoneMultiplier; //Field offset: 0xC8
	public float cashbackMaxPercent; //Field offset: 0xD0
	public string expCashbackMaxPercent; //Field offset: 0xD8
	public string groupName; //Field offset: 0xE0
	public string expGroupName; //Field offset: 0xE8
	public int maxStacks; //Field offset: 0xF0
	public string expMaxStacks; //Field offset: 0xF8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 211
	}

	public CashbackZone() { }

	public virtual TowerBehaviorModel get_Def() { }

}

