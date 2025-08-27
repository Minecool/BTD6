namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AnimateParentTowerOnCollide : ProjectileBehavior
{
	public AnimateParentTowerOnCollideModel syncMovementModel; //Field offset: 0x68
	private Tower tower; //Field offset: 0x70
	private int timeOfLastAnimation; //Field offset: 0x78

	public AnimateParentTowerOnCollide() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

