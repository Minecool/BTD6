namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RefreshPierce : ProjectileBehavior
{
	public RefreshPierceModel rpModel; //Field offset: 0x68
	private float lastRefresh; //Field offset: 0x70

	public RefreshPierce() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

