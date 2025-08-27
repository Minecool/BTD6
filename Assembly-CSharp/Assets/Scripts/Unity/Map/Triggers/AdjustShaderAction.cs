namespace Assets.Scripts.Unity.Map.Triggers;

public class AdjustShaderAction : MapUnityAction
{
	[SerializeField]
	private string propertyName; //Field offset: 0x28
	[SerializeField]
	private float transitionTime; //Field offset: 0x30
	private int propertyId; //Field offset: 0x34
	private float startedTransitioningAt; //Field offset: 0x38
	private bool transitioning; //Field offset: 0x3C

	public AdjustShaderAction() { }

	public virtual void GetOriginalState() { }

	public virtual void GotoPostAction() { }

	public virtual void OnDestroy() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

	private void Update() { }

}

