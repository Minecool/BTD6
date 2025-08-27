namespace Assets.Scripts.Unity.Towers.Behaviors;

public abstract class SupportBehavior : TowerBehavior
{
	public string buffLocsName; //Field offset: 0x98
	public string expBuffLocsName; //Field offset: 0xA0
	public string buffIconName; //Field offset: 0xA8
	public string expBuffIconName; //Field offset: 0xB0
	public bool onlyAffectParagon; //Field offset: 0xB8
	public string expOnlyAffectParagon; //Field offset: 0xC0

	protected SupportBehavior() { }

	public TowerFilterModel[] GatherFilters() { }

}

