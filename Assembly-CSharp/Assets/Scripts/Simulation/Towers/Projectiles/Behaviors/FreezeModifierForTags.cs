namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class FreezeModifierForTags : ProjectileBehavior
{
	public FreezeModifierForTagsModel freezeModifierForTagsModel; //Field offset: 0x68

	public FreezeModifierForTags() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

