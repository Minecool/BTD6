namespace Assets.Scripts.Unity.UI_New.Legends;

public class RogueEnvironment : MonoBehaviour
{
	[Range(0, 1)]
	public float sway; //Field offset: 0x20
	[Range(0, 1)]
	public float wobble; //Field offset: 0x24

	public RogueEnvironment() { }

}

