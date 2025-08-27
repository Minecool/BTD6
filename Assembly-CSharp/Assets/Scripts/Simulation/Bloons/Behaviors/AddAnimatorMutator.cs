namespace Assets.Scripts.Simulation.Bloons.Behaviors;

public class AddAnimatorMutator : BehaviorMutator
{
	public Vector3 startPos; //Field offset: 0x70
	public float startRotation; //Field offset: 0x7C
	public string animCurveId; //Field offset: 0x80
	public float animLength; //Field offset: 0x88
	public bool isInvulnerable; //Field offset: 0x8C
	public bool animateToTrackPosition; //Field offset: 0x8D

	public AddAnimatorMutator(string id, Vector3 startPos, float startRotation, string animCurveId, float animLength, bool isInvulnerable, bool animateToTrackPosition) { }

	public virtual bool Mutate(Model baseModel, Model model) { }

}

