﻿#pragma warning disable CS1591
namespace CryptoPay.Types;

// ReSharper disable InconsistentNaming
// ReSharper disable IdentifierTypo
/// <summary>
///     Available currencies.
/// </summary>
public enum Assets
{
    // Crypto
    BTC,
    TON,
    ETH,
    BNB,
    USDT,
    USDC,
    BUSD,

    //Fiat
    RUB = 100, // Russian ruble
    USD = 101, // Dollar USA
    EUR = 102, // euro
    BYN = 103, // Belarusian ruble
    UAH = 104, // Ukrainian hryvnia
    GBP = 105, // Pound sterling
    CNY = 106, // Renminbi
    KZT = 107, // Kazakhstani tenge
    UZS = 108, // Uzbekistani som
    GEL = 109, // Georgian lari
    TRY = 110, // Turkish lira
    AMD = 111, // Armenian dram
    THB = 112, // Thai baht
    INR = 113 // Indian rupee
}