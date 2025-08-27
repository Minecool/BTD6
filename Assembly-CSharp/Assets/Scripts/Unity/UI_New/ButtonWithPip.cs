namespace Assets.Scripts.Unity.UI_New;

public class ButtonWithPip : MonoBehaviour
{
	[SerializeField]
	private Button button; //Field offset: 0x20
	[SerializeField]
	private GameObject pip; //Field offset: 0x28

	public bool PipEnabled
	{
		 get { } //Length: 29
		 set { } //Length: 30
	}

	public ButtonWithPip() { }

	public void AddListener(UnityAction onClick) { }

	private void Awake() { }

	public bool get_PipEnabled() { }

	public void set_PipEnabled(bool value) { }

}

