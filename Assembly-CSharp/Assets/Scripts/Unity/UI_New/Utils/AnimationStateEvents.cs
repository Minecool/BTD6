namespace Assets.Scripts.Unity.UI_New.Utils;

public class AnimationStateEvents : StateMachineBehaviour
{
	internal sealed class AnimStateDelegate : MulticastDelegate
	{

		public AnimStateDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	[CompilerGenerated]
	private AnimStateDelegate OnStateExitEvent; //Field offset: 0x18

	public event AnimStateDelegate OnStateExitEvent
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	public AnimationStateEvents() { }

	[CompilerGenerated]
	public void add_OnStateExitEvent(AnimStateDelegate value) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	[CompilerGenerated]
	public void remove_OnStateExitEvent(AnimStateDelegate value) { }

}

