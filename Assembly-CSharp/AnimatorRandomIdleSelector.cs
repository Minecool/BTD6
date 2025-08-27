//Type is in global namespace

public class AnimatorRandomIdleSelector : StateMachineBehaviour
{
	public static bool LockToDefaultIdle; //Field offset: 0x0
	private static readonly int Idle; //Field offset: 0x4
	public int idleCount; //Field offset: 0x18
	public List<Single> weightOverrides; //Field offset: 0x20
	private List<Single> thresholds; //Field offset: 0x28
	public bool lockToDefault; //Field offset: 0x30

	private static AnimatorRandomIdleSelector() { }

	public AnimatorRandomIdleSelector() { }

	private List<Single> CalculateWeightedProbabilities() { }

	private int GetRandom() { }

	public virtual void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) { }

}

