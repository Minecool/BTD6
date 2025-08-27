namespace Assets.Scripts.Unity.UI_New.ChallengeEditor;

public class ChallengeEditorSliderPanel : MonoBehaviour
{
	public Slider slider; //Field offset: 0x20
	public TMP_Text valueTxt; //Field offset: 0x28
	public Button leftBtn; //Field offset: 0x30
	public Button rightBtn; //Field offset: 0x38
	public Button defaultBtn; //Field offset: 0x40
	public GameObject defNotch; //Field offset: 0x48
	public float increment; //Field offset: 0x50
	private bool changeMinMaxMsg; //Field offset: 0x54

	public ChallengeEditorSliderPanel() { }

	[CompilerGenerated]
	private void <Awake>b__8_0() { }

	[CompilerGenerated]
	private void <Awake>b__8_1() { }

	[CompilerGenerated]
	private void <Awake>b__8_2() { }

	private void Awake() { }

	public float GetValue() { }

	public void SetDefaultValues(float minValue, float maxValue, bool changeMinMaxMsg = false) { }

	public void SetValue(float value) { }

	public void UpdateValueText(float value) { }

}

