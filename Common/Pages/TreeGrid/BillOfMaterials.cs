#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;

namespace BillOfMaterials
{
    public class BomItem
    {
        public string ItemId { get; set; } = "";
        public string? ParentId { get; set; }
        public string Name { get; set; } = "";
        public int? Qty { get; set; } // nullable so Assembly rows are blank
        public string Unit { get; set; } = "EA";
        public string Material { get; set; } = "";
        public string MakeBuy { get; set; } = "";
        public bool IsPhantom { get; set; }
        public decimal UnitCost { get; set; }
        public int LeadTimeDays { get; set; }
    }

    public static class BillOfMaterials
    {
        public static List<BomItem> GetBomData()
        {
            var data = new List<BomItem>();
            int id = 1000;
            var rand = new Random();

            string[] bikeModels = new[]
            {
                "Trek Fuel EX 9.9 XTR",
                "Specialized S-Works Epic",
                "Yeti SB160 T3 XX1",
                "Santa Cruz Megatower CC X01",
                "Canyon Spectral CF 9",
                "Pivot Firebird Pro",
                "Intense Tracer Expert",
                "Norco Sight A1",
                "Rocky Mountain Instinct Carbon 90",
                "Transition Sentinel Carbon GX"
            };

            void AddOrIncrement(string parentId, string name, int qty, decimal cost, int lead)
            {
                var existing = data.FirstOrDefault(d =>
                    d.ParentId == parentId && d.Name == name && d.MakeBuy != "Assembly");

                decimal variation = (decimal)(0.9 + rand.NextDouble() * 0.2);
                var finalCost = Math.Round(cost * variation, 2);
                var finalLead = Math.Max(2, (int)Math.Round(lead * (0.8 + rand.NextDouble() * 0.4)));

                if (existing != null)
                {
                    existing.Qty = (existing.Qty ?? 0) + qty;
                }
                else
                {
                    string mat = "Steel";
                    if (name.Contains("Carbon", StringComparison.OrdinalIgnoreCase)) mat = "Carbon Fiber";
                    else if (name.Contains("Aluminum", StringComparison.OrdinalIgnoreCase) ||
                             name.Contains("Titanium", StringComparison.OrdinalIgnoreCase)) mat = "Aluminum";

                    data.Add(new BomItem
                    {
                        ItemId = $"P-{id++}",
                        Name = name,
                        Qty = qty,
                        Unit = "EA",
                        Material = mat,
                        MakeBuy = finalLead > 45 ? "Make" : "Buy",
                        IsPhantom = false,
                        ParentId = parentId,
                        UnitCost = finalCost,
                        LeadTimeDays = finalLead
                    });
                }
            }

            for (int bikeIndex = 0; bikeIndex < bikeModels.Length; bikeIndex++)
            {
                var model = bikeModels[bikeIndex];
                var bikeId = $"BIKE-{2025 + bikeIndex}";
                data.Add(new BomItem
                {
                    ItemId = bikeId,
                    Name = model,
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = null,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                var frameId = $"FRM-{id++}";
                data.Add(new BomItem
                {
                    ItemId = frameId,
                    Name = "Frame Kit",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                AddOrIncrement(frameId, "Carbon Main Frame L", 1, 2899m, 92);
                AddOrIncrement(frameId, "Fox Float X2 Factory Shock", 1, 689m, 58);
                AddOrIncrement(frameId, "Seatpost Clamp 34.9mm", 1, 32m, 12);
                AddOrIncrement(frameId, "Derailleur Hanger UDH", 1, 48m, 15);
                AddOrIncrement(frameId, "M6x16mm Ti Frame Bolt", 8, 4.2m, 18);
                AddOrIncrement(frameId, "M5x12mm Bottle Cage Bolt", 4, 1.1m, 6);

                var wheelId = $"WHL-{id++}";
                data.Add(new BomItem
                {
                    ItemId = wheelId,
                    Name = "Wheelset",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = true,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                AddOrIncrement(wheelId, "DT Swiss EXC 1501 Carbon Rim 29\"", 2, 1024m, 68);
                AddOrIncrement(wheelId, "DT Swiss 240 EXP Hubset", 1, 920m, 52);
                AddOrIncrement(wheelId, "Sapim CX-Ray Spokes", 64, 3.2m, 24);
                AddOrIncrement(wheelId, "DT Swiss ProLock Brass Nipples", 64, 0.95m, 8);
                AddOrIncrement(wheelId, "Stans NoTubes Sealant 2oz", 2, 14m, 5);

                var driveId = $"DRV-{id++}";
                data.Add(new BomItem
                {
                    ItemId = driveId,
                    Name = "Drivetrain Group",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                AddOrIncrement(driveId, "SRAM XX1 Eagle AXS Group", 1, 2199m, 72);
                AddOrIncrement(driveId, "X0 Eagle Cassette 10-52T", 1, 620m, 42);
                AddOrIncrement(driveId, "XX1 Rainbow Chain 126L", 1, 98m, 8);

                var brakeId = $"BRK-{id++}";
                data.Add(new BomItem
                {
                    ItemId = brakeId,
                    Name = "Brake System",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                AddOrIncrement(brakeId, "Magura MT8 Raceline Set", 1, 789m, 58);
                AddOrIncrement(brakeId, "203mm Storm HC Rotor", 2, 112m, 18);
                AddOrIncrement(brakeId, "Organic Brake Pads", 4, 38m, 10);

                var cockId = $"COCK-{id++}";
                data.Add(new BomItem
                {
                    ItemId = cockId,
                    Name = "Cockpit",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                AddOrIncrement(cockId, "OneUp Carbon Handlebar 800mm", 1, 189m, 32);
                AddOrIncrement(cockId, "Deity Lockjaw Grips", 1, 28m, 6);
            }

            // Roll-up costs and lead times for assemblies
            for (int idx2 = data.Count - 1; idx2 >= 0; idx2--)
            {
                var parent = data[idx2];
                if (parent.MakeBuy == "Assembly" || parent.ParentId is null)
                {
                    var children = data.Where(d => d.ParentId == parent.ItemId).ToList();
                    if (children.Count > 0)
                    {
                        parent.UnitCost = Math.Round(children.Sum(c => c.UnitCost * (c.Qty ?? 0)), 2);
                        parent.LeadTimeDays = children.Max(c => c.LeadTimeDays);
                    }
                }
            }

            return data;
        }
        public static List<BomItem> GetBomDataStatic()
        {
            var data = new List<BomItem>();
            int id = 1000;

            string[] bikeModels = new[]
            {
            "Trek Fuel EX 9.9 XTR",
            "Specialized S-Works Epic",
            "Yeti SB160 T3 XX1",
            "Santa Cruz Megatower CC X01",
            "Canyon Spectral CF 9",
            "Pivot Firebird Pro",
            "Intense Tracer Expert",
            "Norco Sight A1",
            "Rocky Mountain Instinct Carbon 90",
            "Transition Sentinel Carbon GX"
        };

            void AddOrIncrementStatic(string parentId, string name, int qty, decimal cost, int lead)
            {
                var existing = data.FirstOrDefault(d =>
                    d.ParentId == parentId && d.Name == name && d.MakeBuy != "Assembly");

                // Deterministic variations (replace randomness)
                decimal costFactor = 0.9m + (decimal)Hash01(name) * 0.2m;            // [0.9, 1.1]
                decimal finalCost = Math.Round(cost * costFactor, 2);

                double leadFactor = 0.8 + Hash01(name + "|lead") * 0.4;              // [0.8, 1.2]
                int finalLead = Math.Max(2, (int)Math.Round(lead * leadFactor));

                if (existing != null)
                {
                    existing.Qty = (existing.Qty ?? 0) + qty;
                }
                else
                {
                    string mat = "Steel";
                    if (name.Contains("Carbon", StringComparison.OrdinalIgnoreCase)) mat = "Carbon Fiber";
                    else if (name.Contains("Aluminum", StringComparison.OrdinalIgnoreCase) ||
                             name.Contains("Titanium", StringComparison.OrdinalIgnoreCase)) mat = "Aluminum";

                    data.Add(new BomItem
                    {
                        ItemId = $"P-{id++}",
                        Name = name,
                        Qty = qty,
                        Unit = "EA",
                        Material = mat,
                        MakeBuy = finalLead > 45 ? "Make" : "Buy",
                        IsPhantom = false,
                        ParentId = parentId,
                        UnitCost = finalCost,
                        LeadTimeDays = finalLead
                    });
                }
            }

            for (int bikeIndex = 0; bikeIndex < bikeModels.Length; bikeIndex++)
            {
                var model = bikeModels[bikeIndex];
                var bikeId = $"BIKE-{2025 + bikeIndex}";
                data.Add(new BomItem
                {
                    ItemId = bikeId,
                    Name = model,
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = null,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });

                // Frame Kit
                var frameId = $"FRM-{id++}";
                data.Add(new BomItem
                {
                    ItemId = frameId,
                    Name = "Frame Kit",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });
                AddOrIncrementStatic(frameId, "Carbon Main Frame L", 1, 2899m, 92);
                AddOrIncrementStatic(frameId, "Fox Float X2 Factory Shock", 1, 689m, 58);
                AddOrIncrementStatic(frameId, "Seatpost Clamp 34.9mm", 1, 32m, 12);
                AddOrIncrementStatic(frameId, "Derailleur Hanger UDH", 1, 48m, 15);
                AddOrIncrementStatic(frameId, "M6x16mm Ti Frame Bolt", 8, 4.2m, 18);
                AddOrIncrementStatic(frameId, "M5x12mm Bottle Cage Bolt", 4, 1.1m, 6);

                // Wheelset (phantom)
                var wheelId = $"WHL-{id++}";
                data.Add(new BomItem
                {
                    ItemId = wheelId,
                    Name = "Wheelset",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = true,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });
                AddOrIncrementStatic(wheelId, "DT Swiss EXC 1501 Carbon Rim 29\"", 2, 1024m, 68);
                AddOrIncrementStatic(wheelId, "DT Swiss 240 EXP Hubset", 1, 920m, 52);
                AddOrIncrementStatic(wheelId, "Sapim CX-Ray Spokes", 64, 3.2m, 24);
                AddOrIncrementStatic(wheelId, "DT Swiss ProLock Brass Nipples", 64, 0.95m, 8);
                AddOrIncrementStatic(wheelId, "Stans NoTubes Sealant 2oz", 2, 14m, 5);

                // Drivetrain
                var driveId = $"DRV-{id++}";
                data.Add(new BomItem
                {
                    ItemId = driveId,
                    Name = "Drivetrain Group",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });
                AddOrIncrementStatic(driveId, "SRAM XX1 Eagle AXS Group", 1, 2199m, 72);
                AddOrIncrementStatic(driveId, "X0 Eagle Cassette 10-52T", 1, 620m, 42);
                AddOrIncrementStatic(driveId, "XX1 Rainbow Chain 126L", 1, 98m, 8);

                // Brakes
                var brakeId = $"BRK-{id++}";
                data.Add(new BomItem
                {
                    ItemId = brakeId,
                    Name = "Brake System",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });
                AddOrIncrementStatic(brakeId, "Magura MT8 Raceline Set", 1, 789m, 58);
                AddOrIncrementStatic(brakeId, "203mm Storm HC Rotor", 2, 112m, 18);
                AddOrIncrementStatic(brakeId, "Organic Brake Pads", 4, 38m, 10);

                // Cockpit
                var cockId = $"COCK-{id++}";
                data.Add(new BomItem
                {
                    ItemId = cockId,
                    Name = "Cockpit",
                    Qty = null, // Assembly -> blank
                    Unit = "EA",
                    MakeBuy = "Assembly",
                    IsPhantom = false,
                    ParentId = bikeId,
                    UnitCost = 0m,
                    LeadTimeDays = 0
                });
                AddOrIncrementStatic(cockId, "OneUp Carbon Handlebar 800mm", 1, 189m, 32);
                AddOrIncrementStatic(cockId, "Deity Lockjaw Grips", 1, 28m, 6);
            }

            // Roll-up costs and lead times for assemblies
            for (int idx2 = data.Count - 1; idx2 >= 0; idx2--)
            {
                var parent = data[idx2];
                if (parent.MakeBuy == "Assembly" || parent.ParentId is null)
                {
                    var children = data.Where(d => d.ParentId == parent.ItemId).ToList();
                    if (children.Count > 0)
                    {
                        parent.UnitCost = Math.Round(children.Sum(c => c.UnitCost * (c.Qty ?? 0)), 2);
                        parent.LeadTimeDays = children.Max(c => c.LeadTimeDays);
                    }
                }
            }

            return data;
        }

        // Stable hash -> [0, 1)
        private static double Hash01(string input)
        {
            unchecked
            {
                const uint fnvOffset = 2166136261;
                const uint fnvPrime = 16777619;
                uint hash = fnvOffset;
                foreach (char c in input)
                {
                    hash ^= c;
                    hash *= fnvPrime;
                }
                // Map to [0,1)
                return (hash % 100000u) / 100000.0;
            }
        }
    }
}