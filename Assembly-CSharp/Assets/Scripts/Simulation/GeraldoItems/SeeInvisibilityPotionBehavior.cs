namespace Assets.Scripts.Simulation.GeraldoItems;

public class SeeInvisibilityPotionBehavior : GeraldoTowerHighlightingBehavior
{

	public SeeInvisibilityPotionBehavior() { }

	public virtual void Activate(Vector2 location, int inputId, GeraldoItemModel geraldoItemModel) { }

	public virtual bool CheckLocation(Vector2 location, int inputId) { }

	private BehaviorMutator GetCurrentMutator(SeeInvisibilityPotionBehaviorModel seeInvisibilityPotionModel, Tower geraldo, out int version) { }

	private bool IsPositionValid(Vector2 location, int inputId) { }

	private bool IsTowerModelVisiblyImpaired(SeeInvisibilityPotionBehaviorModel seeInvisibilityPotionModel, Tower selection) { }

}

