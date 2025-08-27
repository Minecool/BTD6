namespace Assets.Scripts.Simulation.GeraldoItems;

public class BottleHotSauceBehavior : GeraldoTowerHighlightingBehavior
{

	public BottleHotSauceBehavior() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	private bool IsPositionValid(Vector2 location) { }

}

