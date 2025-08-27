namespace Assets.Scripts.Unity.Map.Effects;

public class OnRemoveableSold : MapUnityAction
{

	public OnRemoveableSold() { }

	public virtual void GotoPostAction() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

}

