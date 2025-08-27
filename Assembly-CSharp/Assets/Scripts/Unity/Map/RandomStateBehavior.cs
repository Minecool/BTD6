namespace Assets.Scripts.Unity.Map;

public class RandomStateBehavior : StateMachineBehaviour
{
	public string paramName; //Field offset: 0x18
	public bool turnOffRandomSpeed; //Field offset: 0x20
	public int numAnimChoices; //Field offset: 0x24
	private int lastChosenState; //Field offset: 0x28
	private int id; //Field offset: 0x2C

	public RandomStateBehavior() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

