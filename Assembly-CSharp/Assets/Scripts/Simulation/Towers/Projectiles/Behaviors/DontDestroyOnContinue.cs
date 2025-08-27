namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class DontDestroyOnContinue : ProjectileBehavior
{
	public DontDestroyOnContinueModel dontDestroyOnContinueModel; //Field offset: 0x68

	public DontDestroyOnContinue() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

