//Type is in global namespace

public class OnClickHandler : MonoBehaviour
{
	public int clicksBeforeActivate; //Field offset: 0x20
	public int activationsTillDestroy; //Field offset: 0x24
	public float clickInterval; //Field offset: 0x28
	public float activationLockTime; //Field offset: 0x2C
	private int currentClicks; //Field offset: 0x30
	private int currentActivations; //Field offset: 0x34
	private float currentLockTime; //Field offset: 0x38
	private float currentTime; //Field offset: 0x3C
	private bool locked; //Field offset: 0x40
	public Action<GameObject> onActivated; //Field offset: 0x48

	public OnClickHandler() { }

	public void Awake() { }

	public override void OnActivate() { }

	private void OnDestroy() { }

	public override void OnReset() { }

	public override void OnSceneHit() { }

	public override void Process() { }

	private void Update() { }

}

