namespace Assets.Scripts.Unity.Map.Triggers;

public class PlayAnimationAction : MapUnityAction
{
	public Animator anim; //Field offset: 0x28
	public string resetLabel; //Field offset: 0x30
	public string triggerLabel; //Field offset: 0x38
	public string postTriggerLabel; //Field offset: 0x40

	public PlayAnimationAction() { }

	public virtual void GotoPostAction() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

}

