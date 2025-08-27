namespace GestureSystem;

public class GestureManager
{
	private const int MaxGestures = 1; //Field offset: 0x0
	private readonly Gesture[] gestures; //Field offset: 0x10
	private readonly List<IGestureDetector> detectors; //Field offset: 0x18
	private bool gesturesEnabled; //Field offset: 0x20
	[CompilerGenerated]
	private ICursor <InstalledCursor>k__BackingField; //Field offset: 0x28

	public ICursor InstalledCursor
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public GestureManager() { }

	public void AddDetector(IGestureDetector detector) { }

	private void CancelAll() { }

	public void DisableInteraction() { }

	public void EnableInteraction() { }

	[CompilerGenerated]
	public ICursor get_InstalledCursor() { }

	public void RemoveDetector(IGestureDetector detector) { }

	[CompilerGenerated]
	public void set_InstalledCursor(ICursor value) { }

	public void Update() { }

	private void UpdateGestureDetectors() { }

	private void UpdateGestures() { }

}

