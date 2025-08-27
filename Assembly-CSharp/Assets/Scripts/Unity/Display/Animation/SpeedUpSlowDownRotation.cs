namespace Assets.Scripts.Unity.Display.Animation;

public class SpeedUpSlowDownRotation : InteractableObject
{
	private float baseSpeed; //Field offset: 0x20
	private float triggerTime; //Field offset: 0x24
	private float timeToWait; //Field offset: 0x28
	private float currentSpeed; //Field offset: 0x2C
	private CustomRotationSimple rotator; //Field offset: 0x30
	private bool decelerate; //Field offset: 0x38
	private bool activate; //Field offset: 0x39
	private bool trigger; //Field offset: 0x3A
	public bool anticlockwise; //Field offset: 0x3B
	public float maxSpeed; //Field offset: 0x3C
	public float acceleration; //Field offset: 0x40
	public float deceleration; //Field offset: 0x44
	public float minSpeed; //Field offset: 0x48
	public float triggerOffset; //Field offset: 0x4C

	public SpeedUpSlowDownRotation() { }

	public virtual void OnInteract() { }

	private void Start() { }

	private void Update() { }

}

