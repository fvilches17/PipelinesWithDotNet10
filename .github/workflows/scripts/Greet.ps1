param (
    [Parameter(Mandatory = $true)]
    [string]$Name,

    [Parameter(Mandatory = $true)]
    [int]$LuckyNum,

    [Parameter(Mandatory = $true)]
    [bool]$DryRun
)

Write-Host "Hello, $Name!."
Write-Host "Luck num is $LuckyNum"

if ($DryRun) {
    Write-Host "Is a dry run"
} else {
    Write-Host "Is not a dry run"
}
