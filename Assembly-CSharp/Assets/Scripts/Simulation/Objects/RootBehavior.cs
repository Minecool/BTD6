namespace Assets.Scripts.Simulation.Objects;

[Il2CppSetOption(Option::NullChecks (1), False)]
[Il2CppSetOption(Option::ArrayBoundsChecks (2), False)]
public class RootBehavior : RootObject, IRootBehavior, IRootObject
{
	public Entity entity; //Field offset: 0x48
	public Model model; //Field offset: 0x50

	public override Entity Entity
	{
		 get { } //Length: 5
	}

	public RootBehavior() { }

	public override void Attatched() { }

	public virtual void Cleanup() { }

	public override Entity get_Entity() { }

	public override void Initialise(Entity target, Model modelToUse) { }

	public override void UpdatedModel(Model modelToUse) { }

}

