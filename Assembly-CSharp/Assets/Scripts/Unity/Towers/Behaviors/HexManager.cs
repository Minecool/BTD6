namespace Assets.Scripts.Unity.Towers.Behaviors;

public class HexManager : TowerBehavior
{
	public HexManager parent; //Field offset: 0x98
	public Hex hex; //Field offset: 0xA0
	public Hex expHex; //Field offset: 0xA8
	public string overlayType; //Field offset: 0xB0
	public string expOverlayType; //Field offset: 0xB8
	public int overlaysLayer; //Field offset: 0xC0
	public string expOverlaysLayer; //Field offset: 0xC8

	public virtual TowerBehaviorModel Def
	{
		 get { } //Length: 243
	}

	public HexManager() { }

	public virtual TowerBehaviorModel get_Def() { }

}

