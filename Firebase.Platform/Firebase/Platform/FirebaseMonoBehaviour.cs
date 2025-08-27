namespace Firebase.Platform;

[Preserve]
internal sealed class FirebaseMonoBehaviour : MonoBehaviour
{

	public FirebaseMonoBehaviour() { }

	private FirebaseHandler GetFirebaseHandlerOrDestroyGameObject() { }

	[Preserve]
	private void OnApplicationFocus(bool hasFocus) { }

	private void OnDestroy() { }

	[Preserve]
	private void OnEnable() { }

	[Preserve]
	private void Update() { }

}

