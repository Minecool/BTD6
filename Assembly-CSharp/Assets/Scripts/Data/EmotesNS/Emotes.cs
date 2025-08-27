namespace Assets.Scripts.Data.EmotesNS;

public class Emotes : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string id; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal bool <GetEmote>b__0(Emote o) { }

	}

	[SerializeField]
	private Emote standardHeroEmote; //Field offset: 0x18
	[SerializeField]
	private List<Emote> emotes; //Field offset: 0x20

	public IEnumerable<Emote> AllEmotes
	{
		 get { } //Length: 5
	}

	public Emote StandardHeroEmote
	{
		 get { } //Length: 5
	}

	public Emotes() { }

	public IEnumerable<Emote> get_AllEmotes() { }

	public Emote get_StandardHeroEmote() { }

	public Emote GetEmote(string id) { }

}

