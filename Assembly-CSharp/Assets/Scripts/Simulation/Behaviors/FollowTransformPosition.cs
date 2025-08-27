namespace Assets.Scripts.Simulation.Behaviors;

public class FollowTransformPosition : RootBehavior
{
	private TransformBehavior entityTransform; //Field offset: 0x58
	private TransformBehavior followTransform; //Field offset: 0x60

	public TransformBehavior FollowTransform
	{
		 set { } //Length: 140
	}

	public FollowTransformPosition() { }

	public virtual void Attatched() { }

	protected virtual void OnDestroy() { }

	private void OnTransformDestroy(RootObject obj) { }

	private void Process(int elapsed) { }

	public void set_FollowTransform(TransformBehavior value) { }

}

