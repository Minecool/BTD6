namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ExperiencePoints : ProjectileBehavior
{
	public ExperiencePointsModel xpModel; //Field offset: 0x68

	public ExperiencePoints() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual float Pickup(Tower towerPickingUp) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

