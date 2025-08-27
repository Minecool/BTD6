namespace Assets.Scripts.Unity.Map.Triggers;

public class CycleAnimationsAction : MapUnityAction
{
	public Animator[] animations; //Field offset: 0x28
	public String[] triggerLabels; //Field offset: 0x30
	public String[] postTriggerLabels; //Field offset: 0x38
	public bool fromStartingRound; //Field offset: 0x40
	public int roundsPerRotate; //Field offset: 0x44
	private int startRound; //Field offset: 0x48
	private int currentRound; //Field offset: 0x4C
	private int lastRotationIndex; //Field offset: 0x50

	public CycleAnimationsAction() { }

	public virtual void GotoPostAction() { }

	public virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	public virtual void SetStartRound(int startRound) { }

	public virtual void UpdateRound(int round, bool isSet) { }

}

