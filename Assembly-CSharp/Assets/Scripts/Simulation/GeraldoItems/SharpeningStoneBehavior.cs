namespace Assets.Scripts.Simulation.GeraldoItems;

public class SharpeningStoneBehavior : GeraldoTowerHighlightingBehavior
{

	public SharpeningStoneBehavior() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	private SharpeningStoneMutator GetCurrentMutator(SharpeningStoneBehaviorModel sharpeningStoneBehaviorModel, int inputId) { }

	private bool IsPositionValid(Vector2 location, int inputId) { }

	private bool IsTowerValid(SharpeningStoneBehaviorModel sharpeningStoneBehaviorModel, Tower tower, int inputId) { }

}

