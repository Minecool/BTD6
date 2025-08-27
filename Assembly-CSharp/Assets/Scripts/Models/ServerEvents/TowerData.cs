namespace Assets.Scripts.Models.ServerEvents;

public class TowerData
{
	public string tower; //Field offset: 0x10
	public int max; //Field offset: 0x18
	public int path1NumBlockedTiers; //Field offset: 0x1C
	public int path2NumBlockedTiers; //Field offset: 0x20
	public int path3NumBlockedTiers; //Field offset: 0x24
	public bool isHero; //Field offset: 0x28
	public bool restrictParagon; //Field offset: 0x29

	public TowerData() { }

	public TowerData Clone() { }

	public bool Compare(TowerData com) { }

	public string GetPathDisplayText(bool emptyStringForMax) { }

	public int ReturnMaxTierForPath(int path) { }

}

