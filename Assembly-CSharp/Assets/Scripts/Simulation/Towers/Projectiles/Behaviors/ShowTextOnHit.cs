namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ShowTextOnHit : ProjectileBehavior
{
	private ShowTextOnHitModel showTextOnHitModel; //Field offset: 0x68

	public ShowTextOnHit() { }

	public virtual void Collide(Bloon bloon) { }

	public void CreateText(string content) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

