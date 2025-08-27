namespace Assets.Scripts.Simulation.Towers.Pets;

public class PetCreateSoundOnIdle : PetBehavior
{
	private PetCreateSoundOnIdleModel petIdleModel; //Field offset: 0x60
	private int delay; //Field offset: 0x68
	private int currentFrame; //Field offset: 0x6C

	public PetCreateSoundOnIdle() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void PlayIdleSound() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

