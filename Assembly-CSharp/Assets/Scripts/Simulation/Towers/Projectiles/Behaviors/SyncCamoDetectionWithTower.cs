namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SyncCamoDetectionWithTower : ProjectileBehavior
{
	public SyncCamoDetectionWithTowerModel syncCamoDetectionWithTowerModel; //Field offset: 0x68

	public SyncCamoDetectionWithTower() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

