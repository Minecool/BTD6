namespace System;

public class UriFormatException : FormatException, ISerializable
{

	public UriFormatException() { }

	public UriFormatException(string textString) { }

	public UriFormatException(string textString, Exception e) { }

	protected UriFormatException(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

}

