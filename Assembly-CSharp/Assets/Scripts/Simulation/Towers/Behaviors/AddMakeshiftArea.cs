namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class AddMakeshiftArea : TowerBehavior
{
	public AddMakeshiftAreaModel addMakeshiftAreaModel; //Field offset: 0x68
	public Area addedArea; //Field offset: 0x70

	public AddMakeshiftArea() { }

	public virtual void Attatched() { }

	private void CreateArea() { }

	private AreaModel CreatePlaceableAreaModel() { }

	public virtual void GetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public virtual void SetSaveMetaData(Dictionary<String, String> metaData) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

