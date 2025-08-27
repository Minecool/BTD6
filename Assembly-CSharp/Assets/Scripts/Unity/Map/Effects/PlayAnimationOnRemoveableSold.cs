namespace Assets.Scripts.Unity.Map.Effects;

public class PlayAnimationOnRemoveableSold : OnRemoveableSold
{
	public Animator animator; //Field offset: 0x28
	public string triggerId; //Field offset: 0x30
	public GameObject animationPrefab; //Field offset: 0x38
	public bool useGameObjectPosition; //Field offset: 0x40
	public Vector3 position; //Field offset: 0x44
	public Vector3 rotation; //Field offset: 0x50
	private MonkeyAnimationController monkeyAnimator; //Field offset: 0x60
	private PlayableAnimatorSimple simpleAnimator; //Field offset: 0x68
	private float _triggerTime; //Field offset: 0x70
	public float clipLength; //Field offset: 0x74
	private GameObject prefab; //Field offset: 0x78
	private bool cloned; //Field offset: 0x80

	private float triggerTime
	{
		private get { } //Length: 6
		private set { } //Length: 6
	}

	public PlayAnimationOnRemoveableSold() { }

	private void FindAnimator() { }

	private float get_triggerTime() { }

	public virtual void PerformAction() { }

	private void set_triggerTime(float value) { }

	public virtual void SetToOriginalState(bool mapEventActive) { }

	private void Update() { }

}

