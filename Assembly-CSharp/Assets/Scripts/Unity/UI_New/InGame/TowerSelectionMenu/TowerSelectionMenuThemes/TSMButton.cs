namespace Assets.Scripts.Unity.UI_New.InGame.TowerSelectionMenu.TowerSelectionMenuThemes;

public class TSMButton : MonoBehaviour
{
	public string buttonId; //Field offset: 0x20
	public bool canInvokeCustomInput; //Field offset: 0x28
	public string customInputId; //Field offset: 0x30
	public List<AudioClip> sounds; //Field offset: 0x38
	public bool ignoreOwnerCheck; //Field offset: 0x40
	[Header("Check this if audio (eg voicelines) is intended to be skinnable with cosmetics")]
	public bool isSkinnable; //Field offset: 0x41
	[HideInInspector]
	public List<AudioClipReference> soundsRef; //Field offset: 0x48
	[HideInInspector]
	public List<AudioClipReference> heroVoicesRef; //Field offset: 0x50
	private Button button; //Field offset: 0x58

	public Button Button
	{
		 get { } //Length: 149
	}

	public TSMButton() { }

	public Button get_Button() { }

	public void OnButtonPressed() { }

	private void PlayButtonSound(List<AudioClip> soundList, string groupId, AudioType audioType) { }

	private void PlaySoundFromRef(List<AudioClipReference> refList, string groupId, AudioType audioType) { }

}

