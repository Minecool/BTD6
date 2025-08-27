namespace Assets.Scripts.Data.Cosmetics.Props;

public class Prop : AssetChangeItem
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<String, Vector3>, KeyValuePair`2<String, Vector3>> <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal KeyValuePair<String, Vector3> <get_Def>b__8_0(KeyValuePair<String, Vector3> kvp) { }

	}

	internal class OffsetDictionary : SerializableDictionary<String, Vector3>
	{

		public OffsetDictionary() { }

	}

	public string towerId; //Field offset: 0x20
	public string skinId; //Field offset: 0x28
	[SerializeField]
	public PrefabReference display; //Field offset: 0x30
	[SerializableDictionary]
	[SerializeField]
	public OffsetDictionary displayOffsets; //Field offset: 0x38
	[SerializeField]
	[SerializeReference]
	private IUIBehavior[] behaviours; //Field offset: 0x40
	private PropAssetChangeModel def; //Field offset: 0x48

	public PropAssetChangeModel Def
	{
		 get { } //Length: 626
	}

	public Prop() { }

	public PropAssetChangeModel get_Def() { }

}

