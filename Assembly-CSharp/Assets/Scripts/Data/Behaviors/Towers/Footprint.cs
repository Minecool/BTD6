namespace Assets.Scripts.Data.Behaviors.Towers;

public abstract class Footprint : EntityBehavior<FootprintModel>
{
	[SerializeField]
	public bool doesntBlockTowerPlacement; //Field offset: 0x28
	[SerializeField]
	public bool ignoresPlacementCheck; //Field offset: 0x29
	[SerializeField]
	public bool ignoresTowerOverlap; //Field offset: 0x2A

	protected Footprint() { }

}

