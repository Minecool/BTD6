namespace Assets.Scripts.Unity.Map;

internal class AnimatorRandomStatePlayLength : StateMachineBehaviour
{
	public string randomWaitVarName; //Field offset: 0x18
	[Range(0, 1)]
	public float minRandomWaitTime; //Field offset: 0x20
	private float randWaitTime; //Field offset: 0x24

	public AnimatorRandomStatePlayLength() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

