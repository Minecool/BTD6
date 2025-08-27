namespace Discord;

public struct LobbyMemberTransaction
{
	public struct FFIMethods
	{
		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class DeleteMetadataMethod : MulticastDelegate
		{

			public DeleteMetadataMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string key) { }

		}

		[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
		public sealed class SetMetadataMethod : MulticastDelegate
		{

			public SetMetadataMethod(object object, IntPtr method) { }

			public override IAsyncResult BeginInvoke(IntPtr methodsPtr, string key, string value, AsyncCallback callback, object object) { }

			public override Result EndInvoke(IAsyncResult result) { }

			public override Result Invoke(IntPtr methodsPtr, string key, string value) { }

		}

		internal SetMetadataMethod SetMetadata; //Field offset: 0x0
		internal DeleteMetadataMethod DeleteMetadata; //Field offset: 0x8

	}

	internal IntPtr MethodsPtr; //Field offset: 0x0
	internal object MethodsStructure; //Field offset: 0x8

	private FFIMethods Methods
	{
		private get { } //Length: 247
	}

	public void DeleteMetadata(string key) { }

	private FFIMethods get_Methods() { }

	public void SetMetadata(string key, string value) { }

}

