namespace Assets.Scripts.Unity.UI_New.InGame;

public class LeastTiersUsedHud : CTScoreHud
{

	public LeastTiersUsedHud() { }

	protected virtual void AttachEvents() { }

	protected virtual int GetAmountUsed() { }

	protected virtual int GetCurrentTarget() { }

	protected virtual string GetDisplayText() { }

	protected virtual bool NoTargetSet() { }

	protected virtual void PerformGameModelMods() { }

	protected virtual bool ShowWarning() { }

	private void SimulationTierUsed(TowerToSimulation t) { }

}

