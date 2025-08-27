namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class Freeze : ProjectileBehavior
{
	public FreezeModel freezeModel; //Field offset: 0x68
	public int lifespan; //Field offset: 0x70
	private ChildSearchEnumerable<FreezeModifierForTagsModel> freezeModifierForTagsModels; //Field offset: 0x78

	public Freeze() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

