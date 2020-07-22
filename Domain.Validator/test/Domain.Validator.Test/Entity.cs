using System;

namespace Domain.Validator.Test
{
    public class Entity
    {
        public DateTime Birthdate { get; set; }

        public string Birthday { get; set; }

        public string Email { get; set; }

        public int? QuantityInt { get; set; }

        public uint? QuantityUInt { get; set; }

        public long? QuantityLong { get; set; }

        public ulong? QuantityUlong { get; set; }

        public short? QuantityShort { get; set; }

        public ushort? QuantityUshort { get; set; }

        public double? QuantityDouble { get; set; }

        public decimal? QuantityDecimal { get; set; }

        public byte? QuantityByte { get; set; }

        public sbyte? QuantitySbyte { get; set; }

        public string Text { get; internal set; }

        public char? Char { get; internal set; }

        public bool? Bool { get; internal set; }
    }
}
