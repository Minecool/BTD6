namespace Assets.Scripts.Unity.UI_New.Nexus;

public static class NexusCodeManager
{
	internal sealed class CreatorIdChanged : MulticastDelegate
	{

		public CreatorIdChanged(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}


	public static bool CanSupportContentCreator
	{
		 get { } //Length: 175
	}

	public static string CreatorId
	{
		 get { } //Length: 114
	}

	public static bool HasValidCreatorId
	{
		 get { } //Length: 182
	}

	public static void ClearSavedCode() { }

	public static bool get_CanSupportContentCreator() { }

	public static string get_CreatorId() { }

	public static bool get_HasValidCreatorId() { }

	public static String[] GetIapNexusCodes() { }

	public static Task<Boolean> IsValidCreatorId(string creatorId) { }

	public static void SetValidCreatorId(string creatorCode) { }

}

