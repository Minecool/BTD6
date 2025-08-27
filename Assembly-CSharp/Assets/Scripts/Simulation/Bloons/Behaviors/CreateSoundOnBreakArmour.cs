namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class CreateSoundOnBreakArmour : BloonBehavior
{
	public CreateSoundOnBreakArmourModel createSoundOnBreakArmourModel; //Field offset: 0x70

	public CreateSoundOnBreakArmour() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void OnArmourBroken(Bloon obj) { }

	protected virtual void OnDestroy() { }

	private void PlayArmourBreakSound() { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

