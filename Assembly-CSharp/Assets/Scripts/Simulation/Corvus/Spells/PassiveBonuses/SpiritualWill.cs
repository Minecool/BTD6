namespace Assets.Scripts.Simulation.Corvus.Spells.PassiveBonuses;

public class SpiritualWill : TowerBehavior
{
	private int framesSinceLastManaGain; //Field offset: 0x68
	private SpiritualWillModel spiritualWillModel; //Field offset: 0x70

	public SpiritualWill() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

