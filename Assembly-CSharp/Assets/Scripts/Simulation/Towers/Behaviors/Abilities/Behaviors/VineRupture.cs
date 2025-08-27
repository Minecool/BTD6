namespace Assets.Scripts.Simulation.Towers.Behaviors.Abilities.Behaviors;

public class VineRupture : AbilityBehavior
{
	public VineRuptureModel vineRuptureModel; //Field offset: 0x68
	private int currentTick; //Field offset: 0x70
	private bool isExploding; //Field offset: 0x74
	private int framesUntilNextExplosion; //Field offset: 0x78
	private SpiritOfTheForest spiritOfTheForest; //Field offset: 0x80
	private Emission emission; //Field offset: 0x88

	public VineRupture() { }

	public virtual void Activate() { }

	public virtual bool CanUseAbility() { }

	private void ExplodeAtVine(VineScale vine) { }

	private SpiritOfTheForest GetSpiritOfTheForest() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	public virtual bool IsActive() { }

	protected virtual void OnDestroy() { }

	private void PlaySound() { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

