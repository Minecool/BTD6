namespace Assets.Scripts.Unity.Gamepad;

public class ConsoleShared : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Remap, PrefabReference> <>9__10_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal PrefabReference <GetRemap>b__10_1(Remap i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public PrefabReference source; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <GetRemap>b__0(Remap i) { }

	}

	private class Remap
	{
		public PrefabReference source; //Field offset: 0x10
		public PrefabReference replaceWith; //Field offset: 0x18

		public Remap() { }

	}

	public static ConsoleShared instance; //Field offset: 0x0
	[SerializeField]
	private List<Remap> remapPrefabs; //Field offset: 0x20
	[SerializeField]
	private AnimationCurve pulseCurve; //Field offset: 0x28
	[SerializeField]
	private Sprite mainCursorSprite; //Field offset: 0x30
	[SerializeField]
	private Sprite mainPressedCursorSprite; //Field offset: 0x38
	[SerializeField]
	private List<BTD6Gamepad> playerInputs; //Field offset: 0x40
	[SerializeField]
	private float pulseScale; //Field offset: 0x48
	private float pulseDuration; //Field offset: 0x4C

	public ConsoleShared() { }

	private void Awake() { }

	public float EvalPulse(float time) { }

	public Sprite GetCursorSprite(bool pressed) { }

	public PrefabReference GetRemap(PrefabReference source) { }

	public void Update() { }

}

