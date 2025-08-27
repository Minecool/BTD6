namespace Assets.Scripts.Simulation.Behaviors;

public class DestroyOnTransformDestroy : RootBehavior
{
	private RootBehavior transform; //Field offset: 0x58

	public RootBehavior Transform
	{
		 set { } //Length: 140
	}

	public DestroyOnTransformDestroy() { }

	protected virtual void OnDestroy() { }

	private void OnTransformDestroy(RootObject obj) { }

	public void set_Transform(RootBehavior value) { }

}

