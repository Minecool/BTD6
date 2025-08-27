namespace Assets.Scripts.Simulation.GeraldoItems;

public class GeraldoChangeTowerBehavior : GeraldoTowerHighlightingBehavior
{
	private readonly String[] mutatorBanList; //Field offset: 0x28
	private readonly String[] mutatorTagBanList; //Field offset: 0x30

	public GeraldoChangeTowerBehavior() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	private bool CanCarryMutator(BehaviorMutator mutator) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	private bool IsPositionValid(Vector2 location) { }

	private bool IsTierValid(TowerModel towerModel) { }

}

