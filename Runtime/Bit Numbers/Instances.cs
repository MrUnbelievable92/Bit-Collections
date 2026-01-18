namespace BitCollections
{
	public readonly struct Bit : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 1;

		public bool IsSigned => false;
		public byte Bits => 1;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt2 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 3;

		public bool IsSigned => false;
		public byte Bits => 2;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt3 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 7;

		public bool IsSigned => false;
		public byte Bits => 3;
		public byte MinFullyPackedBytes => 3;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt4 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 15;

		public bool IsSigned => false;
		public byte Bits => 4;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt5 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 31;

		public bool IsSigned => false;
		public byte Bits => 5;
		public byte MinFullyPackedBytes => 5;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt6 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 63;

		public bool IsSigned => false;
		public byte Bits => 6;
		public byte MinFullyPackedBytes => 3;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt7 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 127;

		public bool IsSigned => false;
		public byte Bits => 7;
		public byte MinFullyPackedBytes => 7;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt8 : BitInt
	{
		public const byte MinValue = 0;
		public const byte MaxValue = 255;

		public bool IsSigned => false;
		public byte Bits => 8;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt9 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 511;

		public bool IsSigned => false;
		public byte Bits => 9;
		public byte MinFullyPackedBytes => 9;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt10 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 1023;

		public bool IsSigned => false;
		public byte Bits => 10;
		public byte MinFullyPackedBytes => 5;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt11 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 2047;

		public bool IsSigned => false;
		public byte Bits => 11;
		public byte MinFullyPackedBytes => 11;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt12 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 4095;

		public bool IsSigned => false;
		public byte Bits => 12;
		public byte MinFullyPackedBytes => 3;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt13 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 8191;

		public bool IsSigned => false;
		public byte Bits => 13;
		public byte MinFullyPackedBytes => 13;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt14 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 16383;

		public bool IsSigned => false;
		public byte Bits => 14;
		public byte MinFullyPackedBytes => 7;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt15 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 32767;

		public bool IsSigned => false;
		public byte Bits => 15;
		public byte MinFullyPackedBytes => 15;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt16 : BitInt
	{
		public const ushort MinValue = 0;
		public const ushort MaxValue = 65535;

		public bool IsSigned => false;
		public byte Bits => 16;
		public byte MinFullyPackedBytes => 2;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt17 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 131071;

		public bool IsSigned => false;
		public byte Bits => 17;
		public byte MinFullyPackedBytes => 17;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt18 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 262143;

		public bool IsSigned => false;
		public byte Bits => 18;
		public byte MinFullyPackedBytes => 9;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt19 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 524287;

		public bool IsSigned => false;
		public byte Bits => 19;
		public byte MinFullyPackedBytes => 19;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt20 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 1048575;

		public bool IsSigned => false;
		public byte Bits => 20;
		public byte MinFullyPackedBytes => 5;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt21 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 2097151;

		public bool IsSigned => false;
		public byte Bits => 21;
		public byte MinFullyPackedBytes => 21;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt22 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 4194303;

		public bool IsSigned => false;
		public byte Bits => 22;
		public byte MinFullyPackedBytes => 11;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt23 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 8388607;

		public bool IsSigned => false;
		public byte Bits => 23;
		public byte MinFullyPackedBytes => 23;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt25 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 33554431;

		public bool IsSigned => false;
		public byte Bits => 25;
		public byte MinFullyPackedBytes => 25;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt26 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 67108863;

		public bool IsSigned => false;
		public byte Bits => 26;
		public byte MinFullyPackedBytes => 13;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt27 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 134217727;

		public bool IsSigned => false;
		public byte Bits => 27;
		public byte MinFullyPackedBytes => 27;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt28 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 268435455;

		public bool IsSigned => false;
		public byte Bits => 28;
		public byte MinFullyPackedBytes => 7;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt29 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 536870911;

		public bool IsSigned => false;
		public byte Bits => 29;
		public byte MinFullyPackedBytes => 29;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt30 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 1073741823;

		public bool IsSigned => false;
		public byte Bits => 30;
		public byte MinFullyPackedBytes => 15;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt31 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 2147483647;

		public bool IsSigned => false;
		public byte Bits => 31;
		public byte MinFullyPackedBytes => 31;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt32 : BitInt
	{
		public const uint MinValue = 0;
		public const uint MaxValue = 4294967295;

		public bool IsSigned => false;
		public byte Bits => 32;
		public byte MinFullyPackedBytes => 4;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct UInt33 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 8589934591;

		public bool IsSigned => false;
		public byte Bits => 33;
		public byte MinFullyPackedBytes => 33;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt34 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 17179869183;

		public bool IsSigned => false;
		public byte Bits => 34;
		public byte MinFullyPackedBytes => 17;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt35 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 34359738367;

		public bool IsSigned => false;
		public byte Bits => 35;
		public byte MinFullyPackedBytes => 35;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt36 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 68719476735;

		public bool IsSigned => false;
		public byte Bits => 36;
		public byte MinFullyPackedBytes => 9;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt37 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 137438953471;

		public bool IsSigned => false;
		public byte Bits => 37;
		public byte MinFullyPackedBytes => 37;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt38 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 274877906943;

		public bool IsSigned => false;
		public byte Bits => 38;
		public byte MinFullyPackedBytes => 19;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt39 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 549755813887;

		public bool IsSigned => false;
		public byte Bits => 39;
		public byte MinFullyPackedBytes => 39;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt41 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 2199023255551;

		public bool IsSigned => false;
		public byte Bits => 41;
		public byte MinFullyPackedBytes => 41;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt42 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 4398046511103;

		public bool IsSigned => false;
		public byte Bits => 42;
		public byte MinFullyPackedBytes => 21;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt43 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 8796093022207;

		public bool IsSigned => false;
		public byte Bits => 43;
		public byte MinFullyPackedBytes => 43;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt44 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 17592186044415;

		public bool IsSigned => false;
		public byte Bits => 44;
		public byte MinFullyPackedBytes => 11;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt45 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 35184372088831;

		public bool IsSigned => false;
		public byte Bits => 45;
		public byte MinFullyPackedBytes => 45;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt46 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 70368744177663;

		public bool IsSigned => false;
		public byte Bits => 46;
		public byte MinFullyPackedBytes => 23;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt47 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 140737488355327;

		public bool IsSigned => false;
		public byte Bits => 47;
		public byte MinFullyPackedBytes => 47;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt49 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 562949953421311;

		public bool IsSigned => false;
		public byte Bits => 49;
		public byte MinFullyPackedBytes => 49;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt50 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 1125899906842623;

		public bool IsSigned => false;
		public byte Bits => 50;
		public byte MinFullyPackedBytes => 25;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt51 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 2251799813685247;

		public bool IsSigned => false;
		public byte Bits => 51;
		public byte MinFullyPackedBytes => 51;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt52 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 4503599627370495;

		public bool IsSigned => false;
		public byte Bits => 52;
		public byte MinFullyPackedBytes => 13;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt53 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 9007199254740991;

		public bool IsSigned => false;
		public byte Bits => 53;
		public byte MinFullyPackedBytes => 53;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt54 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 18014398509481983;

		public bool IsSigned => false;
		public byte Bits => 54;
		public byte MinFullyPackedBytes => 27;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt55 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 36028797018963967;

		public bool IsSigned => false;
		public byte Bits => 55;
		public byte MinFullyPackedBytes => 55;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt57 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 144115188075855871;

		public bool IsSigned => false;
		public byte Bits => 57;
		public byte MinFullyPackedBytes => 57;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt58 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 288230376151711743;

		public bool IsSigned => false;
		public byte Bits => 58;
		public byte MinFullyPackedBytes => 29;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt59 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 576460752303423487;

		public bool IsSigned => false;
		public byte Bits => 59;
		public byte MinFullyPackedBytes => 59;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt60 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 1152921504606846975;

		public bool IsSigned => false;
		public byte Bits => 60;
		public byte MinFullyPackedBytes => 15;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt61 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 2305843009213693951;

		public bool IsSigned => false;
		public byte Bits => 61;
		public byte MinFullyPackedBytes => 61;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt62 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 4611686018427387903;

		public bool IsSigned => false;
		public byte Bits => 62;
		public byte MinFullyPackedBytes => 31;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt63 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 9223372036854775807;

		public bool IsSigned => false;
		public byte Bits => 63;
		public byte MinFullyPackedBytes => 63;
		public long MinValueAsLong => (long)MinValue;
		public long MaxValueAsLong => (long)MaxValue;
	}

	public readonly struct UInt64 : BitInt
	{
		public const ulong MinValue = 0;
		public const ulong MaxValue = 18446744073709551615;

		public bool IsSigned => false;
		public byte Bits => 64;
		public byte MinFullyPackedBytes => 8;
		public long MinValueAsLong => unchecked((long)MinValue);
		public long MaxValueAsLong => unchecked((long)MaxValue);
	}


	public readonly struct Int2 : BitInt
	{
		public const sbyte MinValue = -2;
		public const sbyte MaxValue =  1;

		public bool IsSigned => true;
		public byte Bits => 2;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int3 : BitInt
	{
		public const sbyte MinValue = -4;
		public const sbyte MaxValue =  3;

		public bool IsSigned => true;
		public byte Bits => 3;
		public byte MinFullyPackedBytes => 3;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int4 : BitInt
	{
		public const sbyte MinValue = -8;
		public const sbyte MaxValue =  7;

		public bool IsSigned => true;
		public byte Bits => 4;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int5 : BitInt
	{
		public const sbyte MinValue = -16;
		public const sbyte MaxValue =  15;

		public bool IsSigned => true;
		public byte Bits => 5;
		public byte MinFullyPackedBytes => 5;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int6 : BitInt
	{
		public const sbyte MinValue = -32;
		public const sbyte MaxValue =  31;

		public bool IsSigned => true;
		public byte Bits => 6;
		public byte MinFullyPackedBytes => 3;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int7 : BitInt
	{
		public const sbyte MinValue = -64;
		public const sbyte MaxValue =  63;

		public bool IsSigned => true;
		public byte Bits => 7;
		public byte MinFullyPackedBytes => 7;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int8 : BitInt
	{
		public const sbyte MinValue = -128;
		public const sbyte MaxValue =  127;

		public bool IsSigned => true;
		public byte Bits => 8;
		public byte MinFullyPackedBytes => 1;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int9 : BitInt
	{
		public const short MinValue = -256;
		public const short MaxValue =  255;

		public bool IsSigned => true;
		public byte Bits => 9;
		public byte MinFullyPackedBytes => 9;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int10 : BitInt
	{
		public const short MinValue = -512;
		public const short MaxValue =  511;

		public bool IsSigned => true;
		public byte Bits => 10;
		public byte MinFullyPackedBytes => 5;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int11 : BitInt
	{
		public const short MinValue = -1024;
		public const short MaxValue =  1023;

		public bool IsSigned => true;
		public byte Bits => 11;
		public byte MinFullyPackedBytes => 11;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int12 : BitInt
	{
		public const short MinValue = -2048;
		public const short MaxValue =  2047;

		public bool IsSigned => true;
		public byte Bits => 12;
		public byte MinFullyPackedBytes => 3;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int13 : BitInt
	{
		public const short MinValue = -4096;
		public const short MaxValue =  4095;

		public bool IsSigned => true;
		public byte Bits => 13;
		public byte MinFullyPackedBytes => 13;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int14 : BitInt
	{
		public const short MinValue = -8192;
		public const short MaxValue =  8191;

		public bool IsSigned => true;
		public byte Bits => 14;
		public byte MinFullyPackedBytes => 7;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int15 : BitInt
	{
		public const short MinValue = -16384;
		public const short MaxValue =  16383;

		public bool IsSigned => true;
		public byte Bits => 15;
		public byte MinFullyPackedBytes => 15;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int16 : BitInt
	{
		public const short MinValue = -32768;
		public const short MaxValue =  32767;

		public bool IsSigned => true;
		public byte Bits => 16;
		public byte MinFullyPackedBytes => 2;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int17 : BitInt
	{
		public const int MinValue = -65536;
		public const int MaxValue =  65535;

		public bool IsSigned => true;
		public byte Bits => 17;
		public byte MinFullyPackedBytes => 17;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int18 : BitInt
	{
		public const int MinValue = -131072;
		public const int MaxValue =  131071;

		public bool IsSigned => true;
		public byte Bits => 18;
		public byte MinFullyPackedBytes => 9;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int19 : BitInt
	{
		public const int MinValue = -262144;
		public const int MaxValue =  262143;

		public bool IsSigned => true;
		public byte Bits => 19;
		public byte MinFullyPackedBytes => 19;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int20 : BitInt
	{
		public const int MinValue = -524288;
		public const int MaxValue =  524287;

		public bool IsSigned => true;
		public byte Bits => 20;
		public byte MinFullyPackedBytes => 5;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int21 : BitInt
	{
		public const int MinValue = -1048576;
		public const int MaxValue =  1048575;

		public bool IsSigned => true;
		public byte Bits => 21;
		public byte MinFullyPackedBytes => 21;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int22 : BitInt
	{
		public const int MinValue = -2097152;
		public const int MaxValue =  2097151;

		public bool IsSigned => true;
		public byte Bits => 22;
		public byte MinFullyPackedBytes => 11;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int23 : BitInt
	{
		public const int MinValue = -4194304;
		public const int MaxValue =  4194303;

		public bool IsSigned => true;
		public byte Bits => 23;
		public byte MinFullyPackedBytes => 23;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int25 : BitInt
	{
		public const int MinValue = -16777216;
		public const int MaxValue =  16777215;

		public bool IsSigned => true;
		public byte Bits => 25;
		public byte MinFullyPackedBytes => 25;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int26 : BitInt
	{
		public const int MinValue = -33554432;
		public const int MaxValue =  33554431;

		public bool IsSigned => true;
		public byte Bits => 26;
		public byte MinFullyPackedBytes => 13;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int27 : BitInt
	{
		public const int MinValue = -67108864;
		public const int MaxValue =  67108863;

		public bool IsSigned => true;
		public byte Bits => 27;
		public byte MinFullyPackedBytes => 27;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int28 : BitInt
	{
		public const int MinValue = -134217728;
		public const int MaxValue =  134217727;

		public bool IsSigned => true;
		public byte Bits => 28;
		public byte MinFullyPackedBytes => 7;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int29 : BitInt
	{
		public const int MinValue = -268435456;
		public const int MaxValue =  268435455;

		public bool IsSigned => true;
		public byte Bits => 29;
		public byte MinFullyPackedBytes => 29;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int30 : BitInt
	{
		public const int MinValue = -536870912;
		public const int MaxValue =  536870911;

		public bool IsSigned => true;
		public byte Bits => 30;
		public byte MinFullyPackedBytes => 15;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int31 : BitInt
	{
		public const int MinValue = -1073741824;
		public const int MaxValue =  1073741823;

		public bool IsSigned => true;
		public byte Bits => 31;
		public byte MinFullyPackedBytes => 31;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int32 : BitInt
	{
		public const int MinValue = -2147483648;
		public const int MaxValue =  2147483647;

		public bool IsSigned => true;
		public byte Bits => 32;
		public byte MinFullyPackedBytes => 4;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int33 : BitInt
	{
		public const long MinValue = -4294967296;
		public const long MaxValue =  4294967295;

		public bool IsSigned => true;
		public byte Bits => 33;
		public byte MinFullyPackedBytes => 33;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int34 : BitInt
	{
		public const long MinValue = -8589934592;
		public const long MaxValue =  8589934591;

		public bool IsSigned => true;
		public byte Bits => 34;
		public byte MinFullyPackedBytes => 17;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int35 : BitInt
	{
		public const long MinValue = -17179869184;
		public const long MaxValue =  17179869183;

		public bool IsSigned => true;
		public byte Bits => 35;
		public byte MinFullyPackedBytes => 35;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int36 : BitInt
	{
		public const long MinValue = -34359738368;
		public const long MaxValue =  34359738367;

		public bool IsSigned => true;
		public byte Bits => 36;
		public byte MinFullyPackedBytes => 9;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int37 : BitInt
	{
		public const long MinValue = -68719476736;
		public const long MaxValue =  68719476735;

		public bool IsSigned => true;
		public byte Bits => 37;
		public byte MinFullyPackedBytes => 37;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int38 : BitInt
	{
		public const long MinValue = -137438953472;
		public const long MaxValue =  137438953471;

		public bool IsSigned => true;
		public byte Bits => 38;
		public byte MinFullyPackedBytes => 19;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int39 : BitInt
	{
		public const long MinValue = -274877906944;
		public const long MaxValue =  274877906943;

		public bool IsSigned => true;
		public byte Bits => 39;
		public byte MinFullyPackedBytes => 39;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int41 : BitInt
	{
		public const long MinValue = -1099511627776;
		public const long MaxValue =  1099511627775;

		public bool IsSigned => true;
		public byte Bits => 41;
		public byte MinFullyPackedBytes => 41;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int42 : BitInt
	{
		public const long MinValue = -2199023255552;
		public const long MaxValue =  2199023255551;

		public bool IsSigned => true;
		public byte Bits => 42;
		public byte MinFullyPackedBytes => 21;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int43 : BitInt
	{
		public const long MinValue = -4398046511104;
		public const long MaxValue =  4398046511103;

		public bool IsSigned => true;
		public byte Bits => 43;
		public byte MinFullyPackedBytes => 43;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int44 : BitInt
	{
		public const long MinValue = -8796093022208;
		public const long MaxValue =  8796093022207;

		public bool IsSigned => true;
		public byte Bits => 44;
		public byte MinFullyPackedBytes => 11;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int45 : BitInt
	{
		public const long MinValue = -17592186044416;
		public const long MaxValue =  17592186044415;

		public bool IsSigned => true;
		public byte Bits => 45;
		public byte MinFullyPackedBytes => 45;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int46 : BitInt
	{
		public const long MinValue = -35184372088832;
		public const long MaxValue =  35184372088831;

		public bool IsSigned => true;
		public byte Bits => 46;
		public byte MinFullyPackedBytes => 23;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int47 : BitInt
	{
		public const long MinValue = -70368744177664;
		public const long MaxValue =  70368744177663;

		public bool IsSigned => true;
		public byte Bits => 47;
		public byte MinFullyPackedBytes => 47;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int49 : BitInt
	{
		public const long MinValue = -281474976710656;
		public const long MaxValue =  281474976710655;

		public bool IsSigned => true;
		public byte Bits => 49;
		public byte MinFullyPackedBytes => 49;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int50 : BitInt
	{
		public const long MinValue = -562949953421312;
		public const long MaxValue =  562949953421311;

		public bool IsSigned => true;
		public byte Bits => 50;
		public byte MinFullyPackedBytes => 25;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int51 : BitInt
	{
		public const long MinValue = -1125899906842624;
		public const long MaxValue =  1125899906842623;

		public bool IsSigned => true;
		public byte Bits => 51;
		public byte MinFullyPackedBytes => 51;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int52 : BitInt
	{
		public const long MinValue = -2251799813685248;
		public const long MaxValue =  2251799813685247;

		public bool IsSigned => true;
		public byte Bits => 52;
		public byte MinFullyPackedBytes => 13;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int53 : BitInt
	{
		public const long MinValue = -4503599627370496;
		public const long MaxValue =  4503599627370495;

		public bool IsSigned => true;
		public byte Bits => 53;
		public byte MinFullyPackedBytes => 53;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int54 : BitInt
	{
		public const long MinValue = -9007199254740992;
		public const long MaxValue =  9007199254740991;

		public bool IsSigned => true;
		public byte Bits => 54;
		public byte MinFullyPackedBytes => 27;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int55 : BitInt
	{
		public const long MinValue = -18014398509481984;
		public const long MaxValue =  18014398509481983;

		public bool IsSigned => true;
		public byte Bits => 55;
		public byte MinFullyPackedBytes => 55;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int57 : BitInt
	{
		public const long MinValue = -72057594037927936;
		public const long MaxValue =  72057594037927935;

		public bool IsSigned => true;
		public byte Bits => 57;
		public byte MinFullyPackedBytes => 57;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int58 : BitInt
	{
		public const long MinValue = -144115188075855872;
		public const long MaxValue =  144115188075855871;

		public bool IsSigned => true;
		public byte Bits => 58;
		public byte MinFullyPackedBytes => 29;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int59 : BitInt
	{
		public const long MinValue = -288230376151711744;
		public const long MaxValue =  288230376151711743;

		public bool IsSigned => true;
		public byte Bits => 59;
		public byte MinFullyPackedBytes => 59;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int60 : BitInt
	{
		public const long MinValue = -576460752303423488;
		public const long MaxValue =  576460752303423487;

		public bool IsSigned => true;
		public byte Bits => 60;
		public byte MinFullyPackedBytes => 15;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int61 : BitInt
	{
		public const long MinValue = -1152921504606846976;
		public const long MaxValue =  1152921504606846975;

		public bool IsSigned => true;
		public byte Bits => 61;
		public byte MinFullyPackedBytes => 61;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int62 : BitInt
	{
		public const long MinValue = -2305843009213693952;
		public const long MaxValue =  2305843009213693951;

		public bool IsSigned => true;
		public byte Bits => 62;
		public byte MinFullyPackedBytes => 31;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int63 : BitInt
	{
		public const long MinValue = -4611686018427387904;
		public const long MaxValue =  4611686018427387903;

		public bool IsSigned => true;
		public byte Bits => 63;
		public byte MinFullyPackedBytes => 63;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}

	public readonly struct Int64 : BitInt
	{
		public const long MinValue = -9223372036854775808;
		public const long MaxValue =  9223372036854775807;

		public bool IsSigned => true;
		public byte Bits => 64;
		public byte MinFullyPackedBytes => 8;
		public long MinValueAsLong => MinValue;
		public long MaxValueAsLong => MaxValue;
	}
}