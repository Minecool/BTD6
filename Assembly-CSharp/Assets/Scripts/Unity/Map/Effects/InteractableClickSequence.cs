namespace Assets.Scripts.Unity.Map.Effects;

public class InteractableClickSequence : MonoBehaviour
{
	public bool syncToSimulation; //Field offset: 0x20
	public OnClickHandler[] sequence; //Field offset: 0x28
	public AudioClip[] sequenceSounds; //Field offset: 0x30
	public float timeToBreakSequence; //Field offset: 0x38
	public AudioClip regularSound; //Field offset: 0x40
	public AudioClip failSound; //Field offset: 0x48
	public Action onSequenceComplete; //Field offset: 0x50
	private int currSeq; //Field offset: 0x58
	private float timer; //Field offset: 0x5C
	private bool sequenceCompleted; //Field offset: 0x60

	public InteractableClickSequence() { }

	private void InteractableClicked(GameObject clickedThing) { }

	private void OnDestroy() { }

	private void OnSimulationClearedWithoutQuitCallback() { }

	private void PlaySound(AudioClip clip) { }

	private void Reset() { }

	private void Start() { }

	private void Update() { }

}

