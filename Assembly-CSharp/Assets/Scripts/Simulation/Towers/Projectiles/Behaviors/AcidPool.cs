namespace Assets.Scripts.Simulation.Towers.Projectiles.Behaviors;

public class AcidPool : ProjectileBehavior
{
	public AcidPoolModel acidModel; //Field offset: 0x68
	protected int lifespanFrames; //Field offset: 0x70
	private bool createdAcidPool; //Field offset: 0x74
	public bool alwaysMakePool; //Field offset: 0x75

	public AcidPool() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

