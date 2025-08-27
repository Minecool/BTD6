namespace Assets.Scripts.Data.Behaviors.Projectiles;

[CreateAssetMenu(fileName = "CreateTower", menuName = "BTD6/Behaviors/Projectiles/CreateTower")]
public class CreateTower : ProjectileBehavior
{
	public Tower tower; //Field offset: 0x30
	public float height; //Field offset: 0x38
	public bool positionAtTarget; //Field offset: 0x3C
	public bool destroySubTowersOnCreateNewTower; //Field offset: 0x3D
	public bool useProjectileRotation; //Field offset: 0x3E
	public bool useParentTargetPriority; //Field offset: 0x3F
	public bool carryMutatorsFromDestroyedTower; //Field offset: 0x40

	public virtual ProjectileBehaviorModel Def
	{
		 get { } //Length: 273
	}

	public CreateTower() { }

	public virtual ProjectileBehaviorModel get_Def() { }

}

