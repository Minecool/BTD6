namespace Assets.Scripts.Models.Bloons.Behaviors;

[Implementation(typeof(MoveWithAnimator), False, False, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {}])]
public class MoveWithAnimatorModel : BloonBehaviorModel
{
	public Vector3 startPos; //Field offset: 0x30
	public float startRotation; //Field offset: 0x3C
	public string animCurveId; //Field offset: 0x40
	public float animationLength; //Field offset: 0x48
	public bool animateToTrackPosition; //Field offset: 0x4C

	public MoveWithAnimatorModel() { }

	public MoveWithAnimatorModel(string name, Vector3 startPos, float startRotation, string animCurveId, float animationLength, bool animateToTrackPosition) { }

	public virtual Model Clone() { }

	protected virtual bool IsEqualAfterReferenceCheck(Model to) { }

}

