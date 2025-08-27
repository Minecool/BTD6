namespace Assets.Scripts.Unity.UI_New.Main.WorldItems;

public class PlayInteractableEffect : InteractableObject
{
	[Header("(Make sure this object destroys itself)")]
	public object effect; //Field offset: 0x20
	public GameObject effectLocationMarker; //Field offset: 0x28
	[Header("(Time in seconds)")]
	public float delay; //Field offset: 0x30
	public AnimationClip clip; //Field offset: 0x38
	private bool isActive; //Field offset: 0x40
	private float timeToTrigger; //Field offset: 0x44
	private float waitForAnimation; //Field offset: 0x48

	public PlayInteractableEffect() { }

	public virtual void OnInteract() { }

	private void Update() { }

}

