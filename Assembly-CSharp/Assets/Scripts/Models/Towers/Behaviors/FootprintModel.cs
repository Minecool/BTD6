namespace Assets.Scripts.Models.Towers.Behaviors;

public class FootprintModel : TowerBehaviorModel
{
	public bool doesntBlockTowerPlacement; //Field offset: 0x30
	public bool ignoresPlacementCheck; //Field offset: 0x31
	public bool ignoresTowerOverlap; //Field offset: 0x32

	public FootprintModel(string name, bool doesntBlockTowerPlacement, bool ignoresPlacementCheck, bool ignoresTowerOverlap) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

