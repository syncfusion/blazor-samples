using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
namespace FinanceSample.Data
{
    public class StockItem
    {
        public int Id { get; set; }
        public string? Ticker { get; set; }
        public string? CompanyName { get; set; }
        public string? Sector { get; set; }
        public decimal LastPrice { get; set; }
        public decimal Change { get; set; }
        public decimal ChangePercent { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Volume { get; set; }
        public decimal MarketCap { get; set; }
        public required Collection<decimal> TrendData { get; init; } = new();
        public bool IsGain { get; set; }

#pragma warning disable CA2227
        public Collection<SparklinePoint> SparkLinePoints { get; set; } = new();
#pragma warning restore CA2227
    }

    public class StockCatalogueItem
    {
        public string? Ticker { get; set; }
        public string? CompanyName { get; set; }
        public string? Sector { get; set; }
        public decimal BasePrice { get; set; }
        public long MarketCapBase { get; set; }
    }

    public static class DataSource
    {
        private static readonly Collection<StockCatalogueItem> CATALOGUE = new()
        {
            new() { Ticker = "TECK", CompanyName = "Teck Stack Company", Sector = "Materials", BasePrice = 191.53m, MarketCapBase = 2_950_000_000_000 },
            new() { Ticker = "HLTH", CompanyName = "Healthcare Solutions Inc", Sector = "Healthcare", BasePrice = 269.94m, MarketCapBase = 3_080_000_000_000 },
            new() { Ticker = "FINC", CompanyName = "Financial Corp", Sector = "Financials", BasePrice = 126.06m, MarketCapBase = 2_180_000_000_000 },
            new() { Ticker = "RETL", CompanyName = "Retail Dynamics", Sector = "Consumer Discretionary", BasePrice = 495.30m, MarketCapBase = 1_260_000_000_000 },
            new() { Ticker = "MANU", CompanyName = "Manufacturing Pro", Sector = "Industrials", BasePrice = 214.01m, MarketCapBase = 559_000_000_000 },
            new() { Ticker = "ENRG", CompanyName = "Energy Solutions", Sector = "Energy", BasePrice = 96.83m, MarketCapBase = 190_000_000_000 },
            new() { Ticker = "CNSR", CompanyName = "Consumer Group", Sector = "Consumer Staples", BasePrice = 141.48m, MarketCapBase = 560_000_000_000 },
            new() { Ticker = "TLCM", CompanyName = "Telecom Networks", Sector = "Communication Services", BasePrice = 348.62m, MarketCapBase = 270_000_000_000 },
            new() { Ticker = "TRAN", CompanyName = "Transportation Ltd", Sector = "Industrials", BasePrice = 48.66m, MarketCapBase = 132_000_000_000 },
            new() { Ticker = "UTIL", CompanyName = "Utilities Global", Sector = "Utilities", BasePrice = 4118.56m, MarketCapBase = 40_000_000_000_000 },
            new() { Ticker = "BNDS", CompanyName = "Bond Securities", Sector = "Financials", BasePrice = 36107.00m, MarketCapBase = 38_000_000_000_000 },
            new() { Ticker = "FUND", CompanyName = "Fund Managers Co", Sector = "Financials", BasePrice = 14891.65m, MarketCapBase = 25_000_000_000_000 },
            new() { Ticker = "GAIN", CompanyName = "Gain Capital", Sector = "Financials", BasePrice = 7375.64m, MarketCapBase = 3_000_000_000_000 },
            new() { Ticker = "RUSH", CompanyName = "Rush Industries", Sector = "Industrials", BasePrice = 208.23m, MarketCapBase = 6_500_000_000_000 },
            new() { Ticker = "VEST", CompanyName = "Vest Financial", Sector = "Financials", BasePrice = 2120.64m, MarketCapBase = 4_000_000_000_000 },
            new() { Ticker = "ZEST", CompanyName = "Zest Tech Corp", Sector = "Information Technology", BasePrice = 5.18m, MarketCapBase = 2_000_000_000_000 },
            new() { Ticker = "PACE", CompanyName = "Pace Holdings", Sector = "Real Estate", BasePrice = 7909.28m, MarketCapBase = 2_500_000_000_000 },
            new() { Ticker = "LIFT", CompanyName = "Lift Ventures", Sector = "Industrials", BasePrice = 1675.07m, MarketCapBase = 3_000_000_000_000 },
            new() { Ticker = "SOAR", CompanyName = "Soar Analytics", Sector = "Information Technology", BasePrice = 80.50m, MarketCapBase = 100_000_000_000 },
            new() { Ticker = "RLTY", CompanyName = "Realty Trust", Sector = "Real Estate", BasePrice = 2050.73m, MarketCapBase = 500_000_000_000 },
            new() { Ticker = "HIVE", CompanyName = "Hive Blockchain", Sector = "Information Technology", BasePrice = 23.70m, MarketCapBase = 50_000_000_000 },
            new() { Ticker = "GLEN", CompanyName = "Glen Resources", Sector = "Materials", BasePrice = 4.03m, MarketCapBase = 30_000_000_000 },
            new() { Ticker = "VOLT", CompanyName = "Volt Energy", Sector = "Energy", BasePrice = 4.72m, MarketCapBase = 20_000_000_000 },
            new() { Ticker = "FEND", CompanyName = "Fend Securities", Sector = "Financials", BasePrice = 583.97m, MarketCapBase = 15_000_000_000 },
            new() { Ticker = "GRTH", CompanyName = "Growth Ventures", Sector = "Industrials", BasePrice = 249.84m, MarketCapBase = 12_000_000_000 },
            new() { Ticker = "RATE", CompanyName = "Rate Systems", Sector = "Information Technology", BasePrice = 1445.22m, MarketCapBase = 18_000_000_000 },
            new() { Ticker = "EDGE", CompanyName = "Edge Technologies", Sector = "Information Technology", BasePrice = 4116.68m, MarketCapBase = 8_000_000_000 },
            new() { Ticker = "JOLT", CompanyName = "Jolt Motors", Sector = "Consumer Discretionary", BasePrice = 66.30m, MarketCapBase = 5_000_000_000 },
            new() { Ticker = "VIVA", CompanyName = "Viva Tech", Sector = "Information Technology", BasePrice = 1.07m, MarketCapBase = 1_000_000_000 },
            new() { Ticker = "MKTX", CompanyName = "Market Express", Sector = "Industrials", BasePrice = 134.12m, MarketCapBase = 800_000_000 },
            new() { Ticker = "WAGE", CompanyName = "Wage Corp", Sector = "Industrials", BasePrice = 1.30m, MarketCapBase = 900_000_000 },
            new() { Ticker = "PEAK", CompanyName = "Peak Solutions", Sector = "Industrials", BasePrice = 0.69m, MarketCapBase = 600_000_000 },
            new() { Ticker = "OILG", CompanyName = "Oil & Gas Inc", Sector = "Energy", BasePrice = 1.32m, MarketCapBase = 700_000_000 },
            new() { Ticker = "WIND", CompanyName = "Wind Power Ltd", Sector = "Utilities", BasePrice = 0.60m, MarketCapBase = 500_000_000 },
            new() { Ticker = "BMCO", CompanyName = "Beam Co", Sector = "Industrials", BasePrice = 0.90m, MarketCapBase = 650_000_000 },
            new() { Ticker = "NOVA", CompanyName = "Nova Dynamics", Sector = "Information Technology", BasePrice = 0.85m, MarketCapBase = 550_000_000 },
            new() { Ticker = "HRKN", CompanyName = "Horizon Inc", Sector = "Industrials", BasePrice = 1.35m, MarketCapBase = 450_000_000 },
            new() { Ticker = "ROVE", CompanyName = "Rove Ventures", Sector = "Real Estate", BasePrice = 161.78m, MarketCapBase = 750_000_000 },
            new() { Ticker = "GWLN", CompanyName = "Greenwell Funds", Sector = "Financials", BasePrice = 35946.74m, MarketCapBase = 700_000_000_000 },
            new() { Ticker = "PHAR", CompanyName = "Pharma Solutions", Sector = "Healthcare", BasePrice = 1886.57m, MarketCapBase = 225_000_000_000 },
            new() { Ticker = "SPRX", CompanyName = "Sprex Industries", Sector = "Industrials", BasePrice = 0.50m, MarketCapBase = 17_000_000_000 },
            new() { Ticker = "YILD", CompanyName = "Yield Capital", Sector = "Financials", BasePrice = 60.56m, MarketCapBase = 30_000_000_000 },
            new() { Ticker = "SXPN", CompanyName = "Expansion Ltd", Sector = "Industrials", BasePrice = 80.56m, MarketCapBase = 6_000_000_000 },
            new() { Ticker = "PVTX", CompanyName = "Pivot Tech", Sector = "Information Technology", BasePrice = 14.62m, MarketCapBase = 8_000_000_000 },
            new() { Ticker = "TDAL", CompanyName = "Tidal Finance", Sector = "Financials", BasePrice = 56.09m, MarketCapBase = 7_000_000_000 },
            new() { Ticker = "HOPE", CompanyName = "Hope Industries", Sector = "Industrials", BasePrice = 69.14m, MarketCapBase = 10_000_000_000 },
            new() { Ticker = "BZLT", CompanyName = "Bazelt Holdings", Sector = "Industrials", BasePrice = 885.40m, MarketCapBase = 365_000_000_000 },
            new() { Ticker = "BETA", CompanyName = "Beta Systems", Sector = "Information Technology", BasePrice = 54.30m, MarketCapBase = 220_000_000_000 },
            new() { Ticker = "TILT", CompanyName = "Tilt Tech", Sector = "Information Technology", BasePrice = 145.20m, MarketCapBase = 130_000_000_000 },
            new() { Ticker = "NEST", CompanyName = "Nest Financial", Sector = "Financials", BasePrice = 68.50m, MarketCapBase = 135_000_000_000 },
            new() { Ticker = "HTCO", CompanyName = "HT Company", Sector = "Industrials", BasePrice = 12.40m, MarketCapBase = 4_500_000_000 },
            new() { Ticker = "MXTX", CompanyName = "Max Tech", Sector = "Information Technology", BasePrice = 125.60m, MarketCapBase = 78_000_000_000 },
            new() { Ticker = "VBRT", CompanyName = "Vibrant Corp", Sector = "Information Technology", BasePrice = 11.20m, MarketCapBase = 17_000_000_000 },
            new() { Ticker = "YARN", CompanyName = "Yarn Industries", Sector = "Materials", BasePrice = 28.40m, MarketCapBase = 18_000_000_000 },
            new() { Ticker = "LNKX", CompanyName = "Link Express", Sector = "Industrials", BasePrice = 72.30m, MarketCapBase = 91_000_000_000 },
            new() { Ticker = "VNTR", CompanyName = "Venture Capital", Sector = "Financials", BasePrice = 34.25m, MarketCapBase = 285_000_000_000 },
            new() { Ticker = "WHIZ", CompanyName = "Whiz Tech", Sector = "Information Technology", BasePrice = 385.40m, MarketCapBase = 125_000_000_000 },
            new() { Ticker = "AURA", CompanyName = "Aura Solutions", Sector = "Information Technology", BasePrice = 52.30m, MarketCapBase = 98_000_000_000 },
            new() { Ticker = "FSCO", CompanyName = "FSC Holdings", Sector = "Financials", BasePrice = 395.20m, MarketCapBase = 380_000_000_000 },
            new() { Ticker = "ZOOM", CompanyName = "Zoom Corp", Sector = "Communication Services", BasePrice = 75.30m, MarketCapBase = 84_000_000_000 },
            new() { Ticker = "VANT", CompanyName = "Vantage Point", Sector = "Financials", BasePrice = 165.30m, MarketCapBase = 120_000_000_000 },
            new() { Ticker = "CASH", CompanyName = "Cash Flow Inc", Sector = "Financials", BasePrice = 725.60m, MarketCapBase = 110_000_000_000 },
            new() { Ticker = "SURE", CompanyName = "Sure Capital", Sector = "Financials", BasePrice = 68.40m, MarketCapBase = 125_000_000_000 },
            new() { Ticker = "TWIN", CompanyName = "Twin Ventures", Sector = "Industrials", BasePrice = 165.40m, MarketCapBase = 410_000_000_000 },
            new() { Ticker = "ADVR", CompanyName = "Advance Corp", Sector = "Industrials", BasePrice = 485.30m, MarketCapBase = 455_000_000_000 },
            new() { Ticker = "NTRP", CompanyName = "Enterprise Plus", Sector = "Industrials", BasePrice = 565.20m, MarketCapBase = 535_000_000_000 },
            new() { Ticker = "RISE", CompanyName = "Rise Financial", Sector = "Financials", BasePrice = 145.60m, MarketCapBase = 257_000_000_000 },
            new() { Ticker = "CXRT", CompanyName = "Circuit Tech", Sector = "Information Technology", BasePrice = 108.30m, MarketCapBase = 190_000_000_000 },
            new() { Ticker = "LEND", CompanyName = "Lending Plus", Sector = "Financials", BasePrice = 165.40m, MarketCapBase = 445_000_000_000 },
            new() { Ticker = "PXLT", CompanyName = "Pixel Arts", Sector = "Communication Services", BasePrice = 145.20m, MarketCapBase = 67_000_000_000 },
            new() { Ticker = "BASE", CompanyName = "Base Holdings", Sector = "Real Estate", BasePrice = 225.40m, MarketCapBase = 135_000_000_000 },
            new() { Ticker = "MNCO", CompanyName = "Mint Company", Sector = "Consumer Discretionary", BasePrice = 565.30m, MarketCapBase = 250_000_000_000 },
            new() { Ticker = "QUTO", CompanyName = "Quantum Corp", Sector = "Information Technology", BasePrice = 115.30m, MarketCapBase = 175_000_000_000 },
            new() { Ticker = "BKRN", CompanyName = "Berkern Inc", Sector = "Industrials", BasePrice = 95.40m, MarketCapBase = 108_000_000_000 },
            new() { Ticker = "FMXR", CompanyName = "Format Labs", Sector = "Information Technology", BasePrice = 285.20m, MarketCapBase = 210_000_000_000 },
            new() { Ticker = "WVEX", CompanyName = "Wave Express", Sector = "Industrials", BasePrice = 62.30m, MarketCapBase = 270_000_000_000 },
            new() { Ticker = "BLNC", CompanyName = "Balance Corp", Sector = "Financials", BasePrice = 175.60m, MarketCapBase = 240_000_000_000 },
            new() { Ticker = "GDXR", CompanyName = "Gold Index", Sector = "Materials", BasePrice = 185.40m, MarketCapBase = 1_920_000_000_000 },
            new() { Ticker = "FXLN", CompanyName = "Flexion Ltd", Sector = "Consumer Discretionary", BasePrice = 495.30m, MarketCapBase = 1_260_000_000_000 },
            new() { Ticker = "APEX", CompanyName = "Apex Ventures", Sector = "Industrials", BasePrice = 95.40m, MarketCapBase = 175_000_000_000 },
            new() { Ticker = "SYNC", CompanyName = "Sync Network", Sector = "Communication Services", BasePrice = 44.20m, MarketCapBase = 185_000_000_000 },
            new() { Ticker = "RMPT", CompanyName = "Rampart Ltd", Sector = "Industrials", BasePrice = 16.80m, MarketCapBase = 120_000_000_000 },
            new() { Ticker = "FLWD", CompanyName = "Flowdown Inc", Sector = "Industrials", BasePrice = 145.20m, MarketCapBase = 175_000_000_000 },
            new() { Ticker = "JUMP", CompanyName = "Jumpstart Tech", Sector = "Information Technology", BasePrice = 115.30m, MarketCapBase = 475_000_000_000 },
            new() { Ticker = "DASH", CompanyName = "Dash Motor", Sector = "Consumer Discretionary", BasePrice = 158.40m, MarketCapBase = 295_000_000_000 },
            new() { Ticker = "PIER", CompanyName = "Pier Analytics", Sector = "Information Technology", BasePrice = 118.50m, MarketCapBase = 145_000_000_000 },
            new() { Ticker = "XRUX", CompanyName = "Xerox Tech", Sector = "Information Technology", BasePrice = 12.80m, MarketCapBase = 51_000_000_000 },
            new() { Ticker = "AXIS", CompanyName = "Axis Systems", Sector = "Information Technology", BasePrice = 38.50m, MarketCapBase = 55_000_000_000 },
            new() { Ticker = "ALLY", CompanyName = "Ally Financial", Sector = "Financials", BasePrice = 185.40m, MarketCapBase = 250_000_000_000 },
            new() { Ticker = "DMCO", CompanyName = "Dream Corp", Sector = "Industrials", BasePrice = 195.30m, MarketCapBase = 115_000_000_000 },
            new() { Ticker = "FRAM", CompanyName = "Frame Industries", Sector = "Materials", BasePrice = 425.60m, MarketCapBase = 115_000_000_000 },
            new() { Ticker = "KEEN", CompanyName = "Keen Ventures", Sector = "Industrials", BasePrice = 285.60m, MarketCapBase = 145_000_000_000 },
            new() { Ticker = "SNCX", CompanyName = "Sync Express", Sector = "Communication Services", BasePrice = 270.60m, MarketCapBase = 260_000_000_000 },
            new() { Ticker = "DCKX", CompanyName = "Dock Tech", Sector = "Industrials", BasePrice = 58.20m, MarketCapBase = 11_500_000_000 },
            new() { Ticker = "PMLX", CompanyName = "Primal Labs", Sector = "Information Technology", BasePrice = 285.60m, MarketCapBase = 145_000_000_000 },
            new() { Ticker = "HPWL", CompanyName = "Highpower Ltd", Sector = "Information Technology", BasePrice = 425.30m, MarketCapBase = 120_000_000_000 },
            new() { Ticker = "LMEX", CompanyName = "Lumex Corp", Sector = "Information Technology", BasePrice = 195.80m, MarketCapBase = 130_000_000_000 },
            new() { Ticker = "CLIX", CompanyName = "Click Media", Sector = "Communication Services", BasePrice = 175.40m, MarketCapBase = 150_000_000_000 },
            new() { Ticker = "SAGE", CompanyName = "Sage Analytics", Sector = "Information Technology", BasePrice = 245.60m, MarketCapBase = 63_000_000_000 },
            new() { Ticker = "GXLU", CompanyName = "GXL Utilities", Sector = "Utilities", BasePrice = 152.60m, MarketCapBase = 790_000_000_000 },
        };

        /* ──────────────────────────────────────────────────────────
           Helpers
           ────────────────────────────────────────────────────────── */

        public static decimal GenerateVolume()
        {
            Span<byte> buffer = stackalloc byte[8];
            FillRandomBytes(buffer);
            var value = BitConverter.ToUInt64(buffer);
            return Math.Floor(500_000m + (value / (decimal)ulong.MaxValue * (50_000_001m - 500_000m)));
        }

        public static Collection<decimal> GenerateInitialTrend(decimal basePrice)
        {
            var prices = new Collection<decimal>();
            Span<byte> buffer = stackalloc byte[8];
            FillRandomBytes(buffer);
            var seed = BitConverter.ToUInt64(buffer);
            decimal price = basePrice * (0.92m + (decimal)(seed / (double)ulong.MaxValue) * 0.16m);

            Span<byte> stepBuffer = stackalloc byte[8];
            for (int i = 0; i < 20; i++)
            {
                FillRandomBytes(stepBuffer);
                var stepValue = BitConverter.ToUInt64(stepBuffer);
                var stepFraction = stepValue / (double)ulong.MaxValue;
                price *= (decimal)(1 + (stepFraction - 0.5) * 0.02);
                price = Math.Max(price, 0.01m);
                prices.Add(Math.Round(price, 2));
            }

            return prices;
        }

        private static readonly RandomNumberGenerator SharedRandom = RandomNumberGenerator.Create();

        internal static void FillRandomBytes(Span<byte> buffer)
        {
            lock (SharedRandom)
            {
                SharedRandom.GetBytes(buffer);
            }
        }

        /* Build initial stock list stored in a mutable list — NOT stateful.
           This means price updates via direct property mutation never trigger a full re-render. */
        public static Collection<StockItem> BuildInitialStocks()
        {
            var result = new Collection<StockItem>();

            for (int idx = 0; idx < CATALOGUE.Count; idx++)
            {
                var c = CATALOGUE[idx];
                var trendData = GenerateInitialTrend(c.BasePrice);
                var vol = GenerateVolume();
                var prevPrice = trendData.Count >= 2 ? trendData[trendData.Count - 2] : trendData[trendData.Count - 1];
                var initialPrice = trendData[trendData.Count - 1];
                var initialChange = Math.Round((initialPrice - prevPrice) * 100) / 100;
                var initialChangePct = prevPrice > 0
                    ? Math.Round((initialChange / prevPrice) * 100 * 1000) / 1000
                    : 0;
                var isInitialGain = initialChange >= 0;
                var stockItem = new StockItem
                {
                    Id = idx,
                    Ticker = c.Ticker,
                    CompanyName = c.CompanyName,
                    Sector = c.Sector,
                    LastPrice = initialPrice,
                    Change = initialChange,
                    ChangePercent = initialChangePct,
                    High = initialPrice,
                    Low = initialPrice,
                    Volume = vol,
                    MarketCap = c.MarketCapBase,
                    IsGain = isInitialGain,
                    TrendData = new Collection<decimal>(trendData.ToList()),
                    SparkLinePoints = new Collection<SparklinePoint>()
                };
                foreach (var point in stockItem.TrendData.Select((p, i) => new SparklinePoint { Index = i, Price = (double)p }).ToList())
                {
                    stockItem.SparkLinePoints.Add(point);
                }
                result.Add(stockItem);
            }

            return result;
        }
    }

    public class SparklinePoint
    {
        public int Index { get; set; }
        public double Price { get; set; }
    }
}
