namespace Assets.Scripts.Unity.Map.Triggers;

public class EnableGameObjectAction : MapUnityAction
{
	public GameObject[] gameObjects; //Field offset: 0x28
	public bool turnOn; //Field offset: 0x30
	public bool turnOff; //Field offset: 0x31
	public double delay; //Field offset: 0x38
	public bool bypassMapEventActive; //Field offset: 0x40
	private int currentFrame; //Field offset: 0x44
	private bool showedObject; //Field offset: 0x48
	private bool triggered; //Field offset: 0x49

	public EnableGameObjectAction() { }

	public virtual void GotoPostAction() { }

	public virtual void PerformAction() { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

	private void ShowGameObjects() { }

	private void Start() { }

	private void Update() { }

}

