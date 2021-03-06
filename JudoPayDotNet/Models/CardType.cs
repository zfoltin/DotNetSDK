﻿using JudoPayDotNet.Enums;

namespace JudoPayDotNet.Models
{
    /// <summary>
    /// Card types
    /// </summary>
    /// <remarks>This enum is fed from two data sources</remarks>
    // ReSharper disable UnusedMember.Global
    // ReSharper disable InconsistentNaming
    public enum CardType
    {
        [Description("UNKNOWN")]
        UNKNOWN = 0,

        [LocalizedDescription("VISA CREDIT")]
        [Description("VISA")]
        VISA = 1,

        [LocalizedDescription("MCI CREDIT")]
        [Description("MASTERCARD")]
        MASTERCARD = 2,

        [LocalizedDescription("ELECTRON")]
        [Description("VISA_ELECTRON")]
        VISA_ELECTRON = 3,

        [Description("SWITCH")]
        SWITCH = 4,

        [Description("SOLO")]
        SOLO = 5,

        [Description("LASER")]
        LASER = 6,

        [Description("CHINA_UNION_PAY")]
        CHINA_UNION_PAY = 7,

        [Description("AMEX")]
        AMEX = 8,

        [Description("JCB")]
        JCB = 9,

        [Description("MAESTRO")]
        MAESTRO = 10,

        [LocalizedDescription("VISA DEBIT")]
        [Description("VISA_DEBIT")]
        VISA_DEBIT = 11,

		/// <summary>
		/// In Europe your more likely to see Maestro than Mastercard Debit, however it does exist.
		/// </summary>
        [LocalizedDescription("MCI DEBIT")]
        MASTERCARD_DEBIT = 12,

        [LocalizedDescription("VISA_PURCHASING")]
        VISA_PURCHASING = 13,

        // 8192
		DISCOVER = 14,

        // 16384
		CARNET = 15,

        // 32768
		CARTE_BANCAIRE = 16,

        // 65536
		DINERS_CLUB = 17,

        // 131072
		ELO = 18,

        // 262144
		FARMERS_CARD = 19,

        // 524288
		SORIANA = 20,

        // 1048576
		PRIVATE_LABEL_CARD = 21,

		Q_CARD = 22,

		STYLE = 23,

		TRUE_REWARDS = 24,

		UATP = 25,

		BANKCARD = 26,

		BANAMEX_COSTCO = 27
    }
    // ReSharper restore InconsistentNaming
    // ReSharper restore UnusedMember.Global
}
