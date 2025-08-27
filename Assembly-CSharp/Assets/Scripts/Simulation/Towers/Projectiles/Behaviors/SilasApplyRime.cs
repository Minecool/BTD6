namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class SilasApplyRime : ProjectileBehaviorOnEmit
{
	public SilasApplyRimeModel rimeModel; //Field offset: 0x68
	public int lifespan; //Field offset: 0x70
	private Emission emission; //Field offset: 0x78
	private ChildSearchEnumerable<FreezeModifierForTagsModel> freezeModifierForTagsModels; //Field offset: 0x80

	public SilasApplyRime() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnEmit() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

