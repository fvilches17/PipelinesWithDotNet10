param (
    [Parameter(Mandatory = $true)]
    [string]$Name,

    [Parameter(Mandatory = $true)]
    [int]$LuckyNum,

    [Parameter(Mandatory = $true)]
    [bool]$DryRun,

    [Parameter(Mandatory = $false)]
    [string[]]$AdditionalSkipPatterns = @()
)

Write-Host "Hello, $Name!."
Write-Host "Luck num is $LuckyNum"

if ($DryRun) {
    Write-Host "Is a dry run"
} else {
    Write-Host "Is not a dry run"
}

$SkipPatterns = @(
    '^main$',
    '^master$',
    '^release/',
    '^hotfix/',
    '^datafix/',
    '^develop$'
)

if ($AdditionalSkipPatterns.Count -gt 0) {
    Write-Host "Concatenating patterns"
    $SkipPatterns = $SkipPatterns + $AdditionalSkipPatterns
}

# Print all skip patterns to the console
Write-Host "Skip Patterns:"
$SkipPatterns | ForEach-Object { Write-Host " - $_" }

# Print all skip patterns to the console
Write-Host "Additional Patterns:"
$AdditionalSkipPatterns | ForEach-Object { Write-Host " - $_" }

Write-Host "Total items sp: $($SkipPatterns.Count)"
Write-Host "Total items ap: $($AdditionalSkipPatterns.Count)"
