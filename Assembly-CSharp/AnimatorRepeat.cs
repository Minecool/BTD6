//Type is in global namespace

public class AnimatorRepeat : StateMachineBehaviour
{
	[SerializeField]
	private int repeatCount; //Field offset: 0x18
	[SerializeField]
	private string booleanVariableName; //Field offset: 0x20
	private int repeatsRemaining; //Field offset: 0x28

	public AnimatorRepeat() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

