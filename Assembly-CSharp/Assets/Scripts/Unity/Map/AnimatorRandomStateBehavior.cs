namespace Assets.Scripts.Unity.Map;

public class AnimatorRandomStateBehavior : StateMachineBehaviour
{
	public string paramVariableName; //Field offset: 0x18
	public int numRandAnimChoices; //Field offset: 0x20
	[Range(0, 1)]
	public float minRandomWaitTime; //Field offset: 0x24
	public bool allowDuplicateChoices; //Field offset: 0x28
	private int lastChosenState; //Field offset: 0x2C
	private int id; //Field offset: 0x30
	private float randWaitTime; //Field offset: 0x34

	public AnimatorRandomStateBehavior() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

	public virtual void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

