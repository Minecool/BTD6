namespace System;

[CLSCompliant(False)]
public interface IConvertible
{

	public TypeCode GetTypeCode() { }

	public bool ToBoolean(IFormatProvider provider) { }

	public byte ToByte(IFormatProvider provider) { }

	public char ToChar(IFormatProvider provider) { }

	public DateTime ToDateTime(IFormatProvider provider) { }

	public decimal ToDecimal(IFormatProvider provider) { }

	public double ToDouble(IFormatProvider provider) { }

	public short ToInt16(IFormatProvider provider) { }

	public int ToInt32(IFormatProvider provider) { }

	public long ToInt64(IFormatProvider provider) { }

	public sbyte ToSByte(IFormatProvider provider) { }

	public float ToSingle(IFormatProvider provider) { }

	public string ToString(IFormatProvider provider) { }

	public object ToType(Type conversionType, IFormatProvider provider) { }

	public ushort ToUInt16(IFormatProvider provider) { }

	public uint ToUInt32(IFormatProvider provider) { }

	public ulong ToUInt64(IFormatProvider provider) { }

}

