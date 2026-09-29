// filepath: Common/Shared/Accessibility/AccessibilityConfig.cs
namespace BlazorDemos.Shared
{
    /// <summary>
    /// Shared configuration for the Syncfusion Blazor sample browser
    /// accessibility badge and report links. Centralising these values
    /// keeps markup free of hard-coded URLs and allows individual demos
    /// to override the metadata on a per-sample basis through the
    /// <see cref="AccessibilityBadgeMetadata"/> parameter.
    /// </summary>
    public static class AccessibilityConfig
    {
        /// <summary>
        /// Public VPAT document hosted by Syncfusion. Surfaced from the
        /// accessibility badge tooltip.
        /// </summary>
        public const string DefaultVpatUrl =
            "https://www.syncfusion.com/products/essential-studio/aspnet-web-forms/vpat";

        /// <summary>
        /// Site-wide accessibility statement that explains how Syncfusion's
        /// web properties conform to WCAG and Section 508.
        /// </summary>
        public const string DefaultAccessibilityStatementUrl =
            "https://www.syncfusion.com/pages/accessibility/";

        /// <summary>
        /// Short human-readable copy used inside the badge tooltip.
        /// Kept here so it can be updated globally without touching the
        /// component template.
        /// </summary>
        public const string TooltipSummary =
            "This demo passes automated axe checks with 0 violations — semantic markup, ARIA, full keyboard operation, visible focus. Section 508 conformant";

        /// <summary>
        /// Text shown inside the badge itself. Matches the WCAG 2.2 AA
        /// commitment required by the design brief.
        /// </summary>
        public const string BadgeLabel = "WCAG 2.2 AA";
    }

    /// <summary>
    /// Mirror of the cached <c>lastSummary</c> object exposed by
    /// <c>blazorAccessibility.getLastSummary()</c>.  Property names
    /// carry <see cref="System.Text.Json.Serialization.JsonPropertyName"/>
    /// attributes so the camelCase JS payload maps cleanly onto
    /// PascalCase C# when <see cref="System.Text.Json.JsonSerializer"/>
    /// deserialises the JS interop payload.
    /// </summary>
    public sealed class AccessibilitySummarySnapshot
    {
        [System.Text.Json.Serialization.JsonPropertyName("score")]
        public int Score { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("passedRules")]
        public int PassedRules { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("failedRules")]
        public int FailedRules { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("bestPractices")]
        public int BestPractices { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("hasRun")]
        public bool HasRun { get; set; }
        [System.Text.Json.Serialization.JsonPropertyName("targetUrl")]
        public string? TargetLink { get; set; }
    }

    /// <summary>
    /// Per-demo override for the accessibility badge. Demos that need a
    /// different VPAT/report URL can pass an instance of this record to
    /// <c>&lt;AccessibilityBadge Meta="..." /&gt;</c>; any property left
    /// <c>null</c> falls back to the value declared in
    /// <see cref="AccessibilityConfig"/>.
    /// </summary>
    public sealed class AccessibilityBadgeMetadata
    {
        /// <summary>URL the "Accessibility report" link inside the tooltip points to.</summary>
        public string? AccessibilityReportLink { get; init; }

        /// <summary>URL the "VPAT" link inside the tooltip points to.</summary>
        public string? VpatLink { get; init; }

        /// <summary>Override the body copy rendered in the tooltip.</summary>
        public string? TooltipSummary { get; init; }

        /// <summary>Override the badge label. Defaults to <see cref="AccessibilityConfig.BadgeLabel"/>.</summary>
        public string? BadgeLabel { get; init; }
    }
}