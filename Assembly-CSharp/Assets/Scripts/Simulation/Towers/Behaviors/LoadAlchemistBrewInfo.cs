namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class LoadAlchemistBrewInfo : TowerBehavior
{
	public LoadAlchemistBrewInfoModel loadAlchemistBrewInfoModel; //Field offset: 0x68

	public LoadAlchemistBrewInfo() { }

	private void ApplyToTower(Tower tower) { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void LateSetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

