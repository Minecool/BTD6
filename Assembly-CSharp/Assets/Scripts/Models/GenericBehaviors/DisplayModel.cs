namespace Assets.Scripts.Models.GenericBehaviors;

[Implementation(typeof(DisplayBehavior), False, True, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class DisplayModel : Model
{
	public PrefabReference display; //Field offset: 0x30
	public int layer; //Field offset: 0x38
	public Vector3 positionOffset; //Field offset: 0x3C
	public float scale; //Field offset: 0x48
	public bool ignoreRotation; //Field offset: 0x4C
	public List<AnimationChange> animationChanges; //Field offset: 0x50
	public float delayedReveal; //Field offset: 0x58
	public DisplayCategory category; //Field offset: 0x5C
	public bool isAnimationPaused; //Field offset: 0x5E

	public DisplayModel(string name, PrefabReference display, int layer, DisplayCategory category, Vector3 positionOffset = null, float scale = 1, bool ignoreRotation = false, float delayedReveal = 0, bool isAnimationPaused = false) { }

	public virtual void ApplyPrefabSwaps(PrefabSwap[] prefabSwaps) { }

	public virtual Model Clone() { }

	private bool CompareAnims(List<AnimationChange> to) { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

