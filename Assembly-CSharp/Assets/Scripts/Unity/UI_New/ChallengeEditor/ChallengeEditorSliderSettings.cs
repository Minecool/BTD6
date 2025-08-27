namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeEditorSliderSettings : MonoBehaviour
{
	public ChallengeEditorSliderPanel bloonSpeedPanel; //Field offset: 0x20
	public ChallengeEditorSliderPanel moabSpeedPanel; //Field offset: 0x28
	public ChallengeEditorSliderPanel ceramicHealthPanel; //Field offset: 0x30
	public ChallengeEditorSliderPanel moabHealthPanel; //Field offset: 0x38
	public ChallengeEditorSliderPanel regrowSpeedPanel; //Field offset: 0x40
	public ChallengeEditorSliderPanel abilityCooldownPanel; //Field offset: 0x48
	public ChallengeEditorSliderPanel removableCostPanel; //Field offset: 0x50

	public ChallengeEditorSliderSettings() { }

	public void ApplyDCMtoUI(DailyChallengeModel dcm) { }

	public void ApplyUIToDCM(DailyChallengeModel dcm) { }

	public ChallengeEditorSliderPanel[] GetAllSliderPanels() { }

	public void SetValues(Restrictions settingsRestrictions) { }

}

