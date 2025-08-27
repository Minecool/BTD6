namespace Assets.Scripts.Unity.Towers;

public abstract class TowerBehaviorBuff : TowerBehavior
{
	public string buffLocsName; //Field offset: 0x98
	public string expBuffLocsName; //Field offset: 0xA0
	public string buffIconName; //Field offset: 0xA8
	public string expBuffIconName; //Field offset: 0xB0

	protected TowerBehaviorBuff() { }

}

