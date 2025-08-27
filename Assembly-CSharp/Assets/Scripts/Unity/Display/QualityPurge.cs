namespace Assets.Scripts.Unity.Display;

public class QualityPurge : MonoBehaviour
{
	public Component behavior; //Field offset: 0x20
	public PurgeType purgeType; //Field offset: 0x28
	public RenderQuality quality; //Field offset: 0x2C

	public QualityPurge() { }

	internal void CheckForPurge() { }

	public override void Purge() { }

	private void PurgeAnimator(Animator animator) { }

	private void Start() { }

}

