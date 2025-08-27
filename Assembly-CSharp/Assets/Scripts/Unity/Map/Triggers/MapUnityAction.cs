namespace Assets.Scripts.Unity.Map.Triggers;

public abstract class MapUnityAction : MonoBehaviour
{
	public bool resetToOriginalState; //Field offset: 0x20

	protected MapUnityAction() { }

	public override void GetOriginalState() { }

	public override void GotoPostAction() { }

	public override void OnDestroy() { }

	public override void PerformAction() { }

	public override void SetStartRound(int startingRound) { }

	public override void SetToOriginalState(bool mapEventActive) { }

	public override void UpdateRound(int round, bool isSet) { }

}

