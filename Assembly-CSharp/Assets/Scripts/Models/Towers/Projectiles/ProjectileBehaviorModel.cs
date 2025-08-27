namespace Assets.Scripts.Models.Towers.Projectiles;

public abstract class ProjectileBehaviorModel : EntityBehaviorModel
{
	public int collisionPass; //Field offset: 0x30

	protected ProjectileBehaviorModel(string name) { }

}

