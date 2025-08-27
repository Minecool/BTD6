namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class ProjectileSetAnimationOnContact : ProjectileBehavior
{
	private ProjectileSetAnimationOnContactModel modelBehavior; //Field offset: 0x68
	public bool pauseEffectThisFrame; //Field offset: 0x70

	public ProjectileSetAnimationOnContact() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

