namespace NinjaKiwi.LiNK.Transfer;

internal abstract class Session
{
	public sealed class TokenHistory
	{
		[CompilerGenerated]
		private string <Current>k__BackingField; //Field offset: 0x10
		private readonly int length; //Field offset: 0x18
		private readonly Queue<String> pastTokens; //Field offset: 0x20

		public private string Current
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 5
		}

		public TokenHistory(int length) { }

		public void Add(string token) { }

		public bool Contains(string token) { }

		[CompilerGenerated]
		public string get_Current() { }

		[CompilerGenerated]
		private void set_Current(string value) { }

	}

	public readonly SessionModel sessionModel; //Field offset: 0x10
	internal readonly TokenHistory tokenHistory; //Field offset: 0x18

	public override bool Exists
	{
		 get { } //Length: 3
	}

	public string Token
	{
		 get { } //Length: 27
		 set { } //Length: 177
	}

	public Session(SessionModel sessionModel) { }

	public override bool get_Exists() { }

	public string get_Token() { }

	public override Task<Boolean> Refresh() { }

	protected void set_Token(string value) { }

}

