//Type is in global namespace

public class SteamAvatar : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public SteamAvatar <>4__this; //Field offset: 0x10
		public ulong steamid; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal void <Fetch>b__0(Image i) { }

	}

	public ulong SteamId; //Field offset: 0x20
	public AvatarSize Size; //Field offset: 0x28
	public Texture FallbackTexture; //Field offset: 0x30

	public SteamAvatar() { }

	private void ApplyTexture(Texture texture) { }

	public void Fetch(ulong steamid) { }

	private void OnImage(Image image, ulong steamid) { }

	private void Start() { }

}

