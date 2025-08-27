namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class ShowDisplayForTerrain : TowerBehavior
{
	public ShowDisplayForTerrainModel sdModel; //Field offset: 0x68
	private DisplayBehavior terrainDisplay; //Field offset: 0x70

	public ShowDisplayForTerrain() { }

	public virtual void Attatched() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	private void TowerAreaChanged(Tower tower, ObjectId areaID, ObjectId oldAreaId) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

