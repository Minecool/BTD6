namespace Assets.Scripts.Simulation.Towers.Behaviors.Attack.Behaviors;

public class RandomTargetTrack : TargetTrack
{
	public RandomTargetTrackModel randomTargetTrackModel; //Field offset: 0x90

	public RandomTargetTrack() { }

	public virtual string GetName() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

