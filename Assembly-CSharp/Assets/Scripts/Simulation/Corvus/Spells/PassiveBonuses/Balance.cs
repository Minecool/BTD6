namespace Assets.Scripts.Simulation.Corvus.Spells.PassiveBonuses;

public class Balance : TowerBehavior
{
	private BalanceModel spiritualBalanceModel; //Field offset: 0x68
	private bool activate; //Field offset: 0x70

	public Balance() { }

	public virtual void Initialise(Entity target, Model modelToUse) { }

	private float ManaGenerationEquation(float x) { }

	private void Process(int elapsed) { }

	public virtual void UpdatedModel(Model modelToUse) { }

}

