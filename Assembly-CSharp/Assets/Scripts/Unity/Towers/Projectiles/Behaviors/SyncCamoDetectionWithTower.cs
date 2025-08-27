namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class SyncCamoDetectionWithTower : ProjectileBehavior
{
	public SyncCamoDetectionWithTower parent; //Field offset: 0x88

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 88
	}

	public SyncCamoDetectionWithTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

