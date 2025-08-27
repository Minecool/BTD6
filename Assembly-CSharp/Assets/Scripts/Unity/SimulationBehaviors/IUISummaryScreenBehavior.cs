namespace Assets.Scripts.Unity.SimulationBehaviors;

public interface IUISummaryScreenBehavior : IUIBehavior
{

	public void OnDefeatScreen(T screen) { }

	public void OnOpenSummaryScreen(T screen) { }

	public void OnVictoryScreen(T screen) { }

}

