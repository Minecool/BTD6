//Type is in global namespace

public class WebviewBackground : MonoBehaviour
{
	[SerializeField]
	private Button CloseButton; //Field offset: 0x20
	[CompilerGenerated]
	private Action BackButtonEvent; //Field offset: 0x28

	public event Action BackButtonEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 1899
	}

	public WebviewBackground() { }

	[CompilerGenerated]
	private void <Awake>b__4_0() { }

	[CompilerGenerated]
	public void add_BackButtonEvent(Action value) { }

	private void Awake() { }

	[CompilerGenerated]
	public void remove_BackButtonEvent(Action value) { }

	private void TriggerBackButtonEvent() { }

}

