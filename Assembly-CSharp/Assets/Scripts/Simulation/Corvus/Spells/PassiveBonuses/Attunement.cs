namespace Assets.Scripts.Simulation.Corvus.Spells.PassiveBonuses;

public class Attunement : TowerBehavior
{
	private AttunementModel attunementModel; //Field offset: 0x68
	private bool activate; //Field offset: 0x70

	public Attunement() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

