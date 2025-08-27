namespace Assets.Scripts.Simulation.Towers.Behaviors;

public class CreateSoundOnEndOfRound : TowerBehavior
{
	public CreateSoundOnEndOfRoundModel createSoundOnEndOfRoundModel; //Field offset: 0x68

	public CreateSoundOnEndOfRound() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	protected virtual void OnDestroy() { }

	public void OnRoundEnd(int round) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

