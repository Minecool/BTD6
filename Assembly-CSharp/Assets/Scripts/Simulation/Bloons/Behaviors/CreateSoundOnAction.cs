namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateSoundOnAction : BloonBehaviorAction
{
	public CreateSoundOnActionModel modl; //Field offset: 0x78

	public CreateSoundOnAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

