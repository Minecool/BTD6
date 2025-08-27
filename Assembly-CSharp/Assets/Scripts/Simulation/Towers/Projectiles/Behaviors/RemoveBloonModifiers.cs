namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class RemoveBloonModifiers : ProjectileBehavior
{
	public RemoveBloonModifiersModel removeBloonModifiersModel; //Field offset: 0x68
	private Damage damageBehavior; //Field offset: 0x70

	public RemoveBloonModifiers() { }

	public bool CheckList(Bloon bloon, List<String> listToLookIn) { }

	public virtual void Collide(Bloon bloon) { }

	private BloonModel GetCleansed(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

