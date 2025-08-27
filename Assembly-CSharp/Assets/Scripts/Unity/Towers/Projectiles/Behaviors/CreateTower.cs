namespace Assets.Scripts.Unity.Towers.Projectiles.Behaviors;

public class CreateTower : ProjectileBehavior
{
	public CreateTower parent; //Field offset: 0x88
	public Tower tower; //Field offset: 0x90
	public Tower expTower; //Field offset: 0x98
	public float height; //Field offset: 0xA0
	public string expHeight; //Field offset: 0xA8
	public bool positionAtTarget; //Field offset: 0xB0
	public string expPositionAtTarget; //Field offset: 0xB8
	public bool destroySubTowersOnCreateNewTower; //Field offset: 0xC0
	public string expDestroySubTowersOnCreateNewTower; //Field offset: 0xC8
	public bool useProjectileRotation; //Field offset: 0xD0
	public string expUseProjectileRotation; //Field offset: 0xD8
	public bool useParentTargetPriority; //Field offset: 0xE0
	public string expUseParentTargetPriority; //Field offset: 0xE8
	public bool carryMutatorsFromDestroyedTower; //Field offset: 0xF0
	public string expCarryMutatorsFromDestroyedTower; //Field offset: 0xF8

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 282
	}

	public CreateTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

