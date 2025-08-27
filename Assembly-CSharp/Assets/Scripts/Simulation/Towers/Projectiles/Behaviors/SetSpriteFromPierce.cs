namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SetSpriteFromPierce : ProjectileBehavior
{
	public SetSpriteFromPierceModel setSpriteFromPierceModel; //Field offset: 0x68
	private bool firstUpdate; //Field offset: 0x70

	public SetSpriteFromPierce() { }

	public virtual void Attatched() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

	public void UpdateSprite(int offset = -1) { }

}

