namespace Assets.Scripts.Simulation.GeraldoItems;

public class PetRabbitBehavior : GeraldoTowerHighlightingBehavior
{
	private PetRabbitBehaviorModel petRabbitBehaviorModel; //Field offset: 0x28

	public PetRabbitBehavior() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	public virtual void Initialise(GeraldoItemBehaviorModel model, Simulation sim) { }

}

