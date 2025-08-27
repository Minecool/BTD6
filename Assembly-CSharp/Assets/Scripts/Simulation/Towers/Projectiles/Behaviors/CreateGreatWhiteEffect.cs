namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class CreateGreatWhiteEffect : ProjectileBehavior
{
	private CreateGreatWhiteEffectModel createGreatWhiteEffectModel; //Field offset: 0x68
	private Tower parentTower; //Field offset: 0x70
	private GreatWhiteLimitProjectile limitProjectile; //Field offset: 0x78
	private Emission emission; //Field offset: 0x80

	public CreateGreatWhiteEffect() { }

	private bool CanPullBloon(Bloon bloon) { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Exhausted() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	private void UpdateParent() { }

}

