param (
    [Parameter(Mandatory = $true)]
    [string]$Name,

    [Parameter(Mandatory = $true)]
    [int]$LuckyNum
)

Write-Host "Hello, $Name!."
Write-Host "Luck num is $LuckyNum"
