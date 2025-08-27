namespace Assets.Scripts.Unity.UI_New.Utils;

[RequireComponent(typeof(RatioObject))]
public class RatioEnabler : MonoBehaviour
{
	public bool enable16_9; //Field offset: 0x20
	public bool enable4_3; //Field offset: 0x21
	public bool destroyIfNotUsed; //Field offset: 0x22

	public RatioEnabler() { }

	private void Enable(bool enable) { }

	public void Initialise() { }

	public override void OnQuitToMenu() { }

	public override bool OverrideOpenPauseMenu() { }

	public override void PostInitialised() { }

}

