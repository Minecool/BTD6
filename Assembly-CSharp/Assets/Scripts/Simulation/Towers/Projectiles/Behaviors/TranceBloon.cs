namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class TranceBloon : ProjectileBehavior
{
	private TranceBloonModel tranceBloonModel; //Field offset: 0x68

	public TranceBloon() { }

	public virtual void Collide(Bloon bloon) { }

	private void DetonateDamageOverTime(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

