namespace Assets.Scripts.Unity.VisionOS;

public class VisionOSObjectSwap : MonoBehaviour
{
	internal sealed class CreatedVisionOSObject : MulticastDelegate
	{

		public CreatedVisionOSObject(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(GameObject obj, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(GameObject obj) { }

	}

	[SerializeField]
	private GameObject remove; //Field offset: 0x20
	[SerializeField]
	private GameObject add; //Field offset: 0x28
	[SerializeField]
	private Transform parent; //Field offset: 0x30

	public VisionOSObjectSwap() { }

	private void Awake() { }

}

