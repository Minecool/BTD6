namespace Assets.Scripts.Unity.Towers.Behaviors;

public abstract class Footprint : TowerBehavior
{
	public bool doesntBlockTowerPlacement; //Field offset: 0x98
	public string expDoesntBlockTowerPlacement; //Field offset: 0xA0
	public bool ignoresPlacementCheck; //Field offset: 0xA8
	public string expIgnoresPlacementCheck; //Field offset: 0xB0
	public bool ignoresTowerOverlap; //Field offset: 0xB8
	public string expIgnoresTowerOverlap; //Field offset: 0xC0

	protected Footprint() { }

}

