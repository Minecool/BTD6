namespace Assets.Scripts.Data.Bloons;

[CreateAssetMenu(fileName = "New Bloon Display", menuName = "BTD6/Bloon Display", order = 1)]
public class BloonDisplayScriptable : ScriptableObject
{
	internal class BloonDamageState
	{
		[SerializeField]
		public float healthPerc; //Field offset: 0x10
		[SerializeField]
		public PrefabReference display; //Field offset: 0x18

		public BloonDamageState() { }

	}

	internal class BloonKindDisplay
	{
		[SerializeField]
		public BloonKind kind; //Field offset: 0x10
		[SerializeField]
		public SpriteReference icon; //Field offset: 0x18
		[SerializeField]
		public PrefabReference display; //Field offset: 0x20
		[SerializeField]
		public List<BloonDamageState> damageStates; //Field offset: 0x28
		[SerializeField]
		public List<String> children; //Field offset: 0x30
		[SerializeField]
		public string regrowToo; //Field offset: 0x38
		[SerializeField]
		public string regrowOverrideChildWithColor; //Field offset: 0x40

		public BloonKindDisplay() { }

	}

	[SerializeField]
	public List<BloonKindDisplay> bloonKindDisplays; //Field offset: 0x18

	public BloonDisplayScriptable() { }

}

