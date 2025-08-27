namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AddCorvusMana : ProjectileBehaviorOnEmit
{
	public AddCorvusManaModel addCorvusManaModel; //Field offset: 0x68

	public AddCorvusMana() { }

	public virtual void Collide(Bloon bloon) { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void OnEmit() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

