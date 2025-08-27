namespace NinjaKiwi.GUTS.Models.ContentBrowser;

[JsonConverter(typeof(CurationVoteConverter))]
public class CurationVote
{
	private const char kSeparator = '\u5F'; //Field offset: 0x0
	private const char kAdminChar = '\u41'; //Field offset: 0x0
	private const char kRejectionChar = '\u52'; //Field offset: 0x0
	private const char kValidationChar = '\u56'; //Field offset: 0x0
	private static readonly string kAdminPrefix; //Field offset: 0x0
	private static readonly string kRejectionPrefix; //Field offset: 0x8
	private static readonly string kValidationPrefix; //Field offset: 0x10
	[CompilerGenerated]
	private string <UserId>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private DateTime <VoteTime>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Nullable<RejectionReason> <RejectionReason>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <IsAdminVote>k__BackingField; //Field offset: 0x28

	public bool IsAdminVote
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool IsValidationVote
	{
		 get { } //Length: 50
	}

	public Nullable<RejectionReason> RejectionReason
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public string UserId
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public DateTime VoteTime
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private static CurationVote() { }

	public CurationVote(string userId, DateTime voteTime, bool isAdminVote, Nullable<RejectionReason> rejectionReason) { }

	public virtual bool Equals(object obj) { }

	[CompilerGenerated]
	public bool get_IsAdminVote() { }

	public bool get_IsValidationVote() { }

	[CompilerGenerated]
	public Nullable<RejectionReason> get_RejectionReason() { }

	[CompilerGenerated]
	public string get_UserId() { }

	[CompilerGenerated]
	public DateTime get_VoteTime() { }

	public virtual int GetHashCode() { }

	[CompilerGenerated]
	public void set_IsAdminVote(bool value) { }

	[CompilerGenerated]
	public void set_RejectionReason(Nullable<RejectionReason> value) { }

	[CompilerGenerated]
	public void set_UserId(string value) { }

	[CompilerGenerated]
	public void set_VoteTime(DateTime value) { }

	public virtual string ToString() { }

	private static bool TryGetVoteTime(string rawSecondsString, out DateTime voteTime) { }

	public static bool TryParse(string rawString, out CurationVote curationVote) { }

}

