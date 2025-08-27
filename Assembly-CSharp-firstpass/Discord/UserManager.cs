namespace Discord;

public class UserManager
{
	internal sealed class CurrentUserUpdateHandler : MulticastDelegate
	{

		public CurrentUserUpdateHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke() { }

	}

	public struct FFIEvents
	{
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class CurrentUserUpdateHandler : MulticastDelegate
		{

			public CurrentUserUpdateHandler(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, AsyncCallback callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr ptr) { }

		}

		internal CurrentUserUpdateHandler OnCurrentUserUpdate; //Field offset: 0x0

	}

	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class CurrentUserHasFlagMethod : MulticastDelegate
		{

			public CurrentUserHasFlagMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref bool hasFlag, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, UserFlag flag, ref bool hasFlag) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class GetCurrentUserMethod : MulticastDelegate
		{

			public GetCurrentUserMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref User currentUser, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref User currentUser, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref User currentUser) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class GetCurrentUserPremiumTypeMethod : MulticastDelegate
		{

			public GetCurrentUserPremiumTypeMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, ref PremiumType premiumType, AsyncCallback callback, object object) { }

			public override Result EndInvoke(ref PremiumType premiumType, IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, ref PremiumType premiumType) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class GetUserCallback : MulticastDelegate
		{

			public GetUserCallback(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr ptr, Result result, ref User user, AsyncCallback callback, object object) { }

			public override void EndInvoke(ref User user, IAsyncResult result) { }

			public override void Invoke(IntPtr ptr, Result result, ref User user) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class GetUserMethod : MulticastDelegate
		{

			public GetUserMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback, AsyncCallback __callback, object object) { }

			public override void EndInvoke(IAsyncResult result) { }

			public override void Invoke(IntPtr methodsPtr, long userId, IntPtr callbackData, GetUserCallback callback) { }

		}

		internal GetCurrentUserMethod GetCurrentUser; //Field offset: 0x0
		internal GetUserMethod GetUser; //Field offset: 0x8
		internal GetCurrentUserPremiumTypeMethod GetCurrentUserPremiumType; //Field offset: 0x10
		internal CurrentUserHasFlagMethod CurrentUserHasFlag; //Field offset: 0x18

	}

	internal sealed class GetUserHandler : MulticastDelegate
	{

		public GetUserHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Result result, ref User user, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref User user, IAsyncResult result) { }

		public override void Invoke(Result result, ref User user) { }

	}

	private IntPtr MethodsPtr; //Field offset: 0x10
	private object MethodsStructure; //Field offset: 0x18
	[CompilerGenerated]
	private CurrentUserUpdateHandler OnCurrentUserUpdate; //Field offset: 0x20

	public event CurrentUserUpdateHandler OnCurrentUserUpdate
	{
		[CompilerGenerated]
		 add { } //Length: 158
		[CompilerGenerated]
		 remove { } //Length: 158
	}

	private FFIMethods Methods
	{
		private get { } //Length: 256
	}

	internal UserManager(IntPtr ptr, IntPtr eventsPtr, ref FFIEvents events) { }

	[CompilerGenerated]
	public void add_OnCurrentUserUpdate(CurrentUserUpdateHandler value) { }

	public bool CurrentUserHasFlag(UserFlag flag) { }

	private FFIMethods get_Methods() { }

	public User GetCurrentUser() { }

	public PremiumType GetCurrentUserPremiumType() { }

	public void GetUser(long userId, GetUserHandler callback) { }

	[MonoPInvokeCallback]
	private static void GetUserCallbackImpl(IntPtr ptr, Result result, ref User user) { }

	private void InitEvents(IntPtr eventsPtr, ref FFIEvents events) { }

	[MonoPInvokeCallback]
	private static void OnCurrentUserUpdateImpl(IntPtr ptr) { }

	[CompilerGenerated]
	public void remove_OnCurrentUserUpdate(CurrentUserUpdateHandler value) { }

}

