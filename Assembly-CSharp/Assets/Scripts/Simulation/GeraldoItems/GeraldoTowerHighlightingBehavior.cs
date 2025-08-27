namespace Assets.Scripts.Simulation.GeraldoItems;

public class GeraldoTowerHighlightingBehavior : GeraldoItemBehavior
{
	private Tower lastHighlightedTower; //Field offset: 0x20

	public GeraldoTowerHighlightingBehavior() { }

	public virtual void OnDestroy() { }

	protected void RemoveLastHighlight() { }

	protected void SetValidSelection(Tower selection) { }

}

