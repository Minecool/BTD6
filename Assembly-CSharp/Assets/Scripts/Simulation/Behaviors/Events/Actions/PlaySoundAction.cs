namespace Assets.Scripts.Simulation.Behaviors.Events.Actions;

public class PlaySoundAction : EntityAction
{
	public PlaySoundActionModel playSoundActionModel; //Field offset: 0x68

	public PlaySoundAction() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void PerformAction() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

