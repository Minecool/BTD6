namespace UnityEngine.U2D;

[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
public class SpriteAtlas : object
{

	public bool isVariant
	{
		[NativeMethod("IsVariant")]
		 get { } //Length: 118
	}

	public int spriteCount
	{
		 get { } //Length: 118
	}

	public string tag
	{
		 get { } //Length: 256
	}

	public SpriteAtlas() { }

	public bool CanBindTo(Sprite sprite) { }

	private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite) { }

	[NativeMethod("IsVariant")]
	public bool get_isVariant() { }

	private static bool get_isVariant_Injected(IntPtr _unity_self) { }

	public int get_spriteCount() { }

	private static int get_spriteCount_Injected(IntPtr _unity_self) { }

	public string get_tag() { }

	private static void get_tag_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public Sprite GetSprite(string name) { }

	private static IntPtr GetSprite_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public int GetSprites(Sprite[] sprites) { }

	public int GetSprites(Sprite[] sprites, string name) { }

	private int GetSpritesScripting(Sprite[] sprites) { }

	private static int GetSpritesScripting_Injected(IntPtr _unity_self, Sprite[] sprites) { }

	private int GetSpritesWithNameScripting(Sprite[] sprites, string name) { }

	private static int GetSpritesWithNameScripting_Injected(IntPtr _unity_self, Sprite[] sprites, ref ManagedSpanWrapper name) { }

}

