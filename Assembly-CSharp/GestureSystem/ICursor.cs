namespace GestureSystem;

public interface ICursor
{

	public event ControllerEventDelegate onBackPressed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event ControllerEventDelegate onMenuPressed
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public InputMode Mode
	{
		 get { } //Length: 0
	}

	public Vector2 Position
	{
		 get { } //Length: 0
	}

	public ClickState State
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_onBackPressed(ControllerEventDelegate value) { }

	[CompilerGenerated]
	public void add_onMenuPressed(ControllerEventDelegate value) { }

	public InputMode get_Mode() { }

	public Vector2 get_Position() { }

	public ClickState get_State() { }

	public void Hide() { }

	public void Init(GameObject prefab, Transform parent) { }

	[CompilerGenerated]
	public void remove_onBackPressed(ControllerEventDelegate value) { }

	[CompilerGenerated]
	public void remove_onMenuPressed(ControllerEventDelegate value) { }

	public void Reveal() { }

	public void Update() { }

}

