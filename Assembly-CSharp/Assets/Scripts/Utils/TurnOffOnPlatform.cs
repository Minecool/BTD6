namespace Assets.Scripts.Utils;

public class TurnOffOnPlatform : MonoBehaviour
{
	[LongEnumFlags(typeof(RuntimePlatform), False)]
	[SerializeField]
	private long destroyOnPlatforms; //Field offset: 0x20

	public TurnOffOnPlatform() { }

	private void Awake() { }

}

