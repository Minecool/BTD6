namespace Assets.Scripts.Unity.Display;

[RequireComponent(typeof(TrailRenderer))]
public class ProjectileTrailEffect : MonoBehaviour
{
	private TrailRenderer trailRenderer; //Field offset: 0x20
	private bool hasDoneLateUpdate; //Field offset: 0x28
	private float originalWidth; //Field offset: 0x2C

	public ProjectileTrailEffect() { }

	private void Awake() { }

	private void LateUpdate() { }

	private void OnDisable() { }

	public void SetScale(float value) { }

}

