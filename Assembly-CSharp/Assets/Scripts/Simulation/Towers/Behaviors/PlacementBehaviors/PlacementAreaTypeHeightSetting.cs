namespace Assets.Scripts.Simulation.Towers.Behaviors.PlacementBehaviors;

public class PlacementAreaTypeHeightSetting : PlacementBehavior
{
	public PlacementAreaTypeHeightSettingModel placementAreaTypeHeightSettingModel; //Field offset: 0x68
	public AreaType currentAreaType; //Field offset: 0x70
	public Vector3 currentPosition; //Field offset: 0x74

	public PlacementAreaTypeHeightSetting() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnPlace(bool playPlacementEffects) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

