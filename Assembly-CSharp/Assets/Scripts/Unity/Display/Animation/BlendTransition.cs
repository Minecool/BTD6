namespace Assets.Scripts.Unity.Display.Animation;

public class BlendTransition
{
	private float duration; //Field offset: 0x10
	private float elapsed; //Field offset: 0x14
	private int from; //Field offset: 0x18
	private int to; //Field offset: 0x1C
	[CompilerGenerated]
	private int <DestinationState>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Active>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <JustCompleted>k__BackingField; //Field offset: 0x25

	public private bool Active
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private int DestinationState
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool JustCompleted
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BlendTransition() { }

	internal void Cancel() { }

	[CompilerGenerated]
	public bool get_Active() { }

	[CompilerGenerated]
	public int get_DestinationState() { }

	[CompilerGenerated]
	public bool get_JustCompleted() { }

	public void Go(int from, int to, int destinationState, float duration) { }

	[CompilerGenerated]
	private void set_Active(bool value) { }

	[CompilerGenerated]
	private void set_DestinationState(int value) { }

	[CompilerGenerated]
	private void set_JustCompleted(bool value) { }

	public void Update(ref AnimationMixerPlayable mixer) { }

}

