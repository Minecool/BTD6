namespace Assets.Scripts.Unity.UI_New;

public class PauseButton : MonoBehaviour
{
	public Button button; //Field offset: 0x20
	public Image pauseCooldown; //Field offset: 0x28
	public Image disabledImg; //Field offset: 0x30
	private Nullable<DateTime> cooldownStartTime; //Field offset: 0x38
	private Nullable<TimeSpan> cooldownDuration; //Field offset: 0x48
	private bool isCooldownPaused; //Field offset: 0x58

	public bool Interactable
	{
		 set { } //Length: 86
	}

	public PauseButton() { }

	public void Awake() { }

	public void DisableCooldown() { }

	public void OnPauseButtonClicked() { }

	public void ResumeCooldown() { }

	public void set_Interactable(bool value) { }

	public void ShowCooldown(TimeSpan duration) { }

	public void Update() { }

}

