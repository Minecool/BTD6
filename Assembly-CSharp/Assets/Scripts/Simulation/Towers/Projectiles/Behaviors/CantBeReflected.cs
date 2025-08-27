namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CantBeReflected : ProjectileBehavior
{
	public CantBeReflectedModel cantBeReflectedModel; //Field offset: 0x68

	public CantBeReflected() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

