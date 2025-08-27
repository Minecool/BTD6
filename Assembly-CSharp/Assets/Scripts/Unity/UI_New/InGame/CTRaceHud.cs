namespace Assets.Scripts.Unity.UI_New.InGame;

public class CTRaceHud : CTScoreHud
{
	private const float warningDelay = 5; //Field offset: 0x0
	private float warningTimer; //Field offset: 0x90

	public CTRaceHud() { }

	protected virtual int GetCurrentTarget() { }

	protected virtual string GetDisplayText() { }

	protected virtual bool NoTargetSet() { }

	protected virtual bool ShowWarning() { }

	public void Update() { }

}

