namespace SteamNative;

internal class CallResult : CallResult
{
	public sealed class ConvertFromPointer : MulticastDelegate
	{

		public ConvertFromPointer(object object, IntPtr method) { }

		public override T Invoke(IntPtr p) { }

	}

	private static Byte[] resultBuffer; //Field offset: 0x0
	private Action<T, Boolean> CallbackFunction; //Field offset: 0x0
	private ConvertFromPointer<T> ConvertFromPointerFunction; //Field offset: 0x0
	internal int ResultSize; //Field offset: 0x0
	internal int CallbackId; //Field offset: 0x0

	private static CallResult`1() { }

	internal CallResult`1(BaseSteamworks steamworks, SteamAPICall_t call, Action<T, Boolean> callbackFunction, ConvertFromPointer<T> fromPointer, int resultSize, int callbackId) { }

	internal virtual void RunCallback() { }

	public virtual string ToString() { }

}

