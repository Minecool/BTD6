namespace Assets.Scripts.Data.Global;

public class BuffIconSprites : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public string buffId; //Field offset: 0x10

		public <>c__DisplayClass3_0() { }

		internal bool <GetSpriteRef>b__0(BuffIconSprite o) { }

	}

	[SerializeField]
	private List<BuffIconSprite> buffIconSprites; //Field offset: 0x18

	public IEnumerable<BuffIconSprite> Sprites
	{
		 get { } //Length: 5
	}

	public BuffIconSprites() { }

	public IEnumerable<BuffIconSprite> get_Sprites() { }

	public SpriteReference GetSpriteRef(string buffId) { }

}

