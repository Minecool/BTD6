namespace Assets.Scripts.Simulation.Towers.Behaviors.PlacementBehaviors;

public class PlacementAreaTypeRangeBuff : PlacementBehavior
{
	public PlacementAreaTypeRangeBuffModel placementAreaRangeBuffModel; //Field offset: 0x68

	public PlacementAreaTypeRangeBuff() { }

	public void ApplyBuff() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnAreasChanged() { }

	protected virtual void OnDestroy() { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

