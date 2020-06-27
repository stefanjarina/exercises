#!/usr/bin/env pwsh

param (
    [string]$Name = "",
    [string]$Lang = ""
)

if ($Name) {
    $Name = $Name.ToLower()
}
if ($Lang) {
    $Lang = $Lang.ToLower()
}

$ErrorActionPreference = "Stop"

if ($Name -and !$Lang) {
    $result = Get-ChildItem -Path $PSScriptRoot/*/$Name
    foreach ($item in $result) {
        Write-Output "$($item.Parent)"
    }
}
elseif ($Name -and $Lang) {
    try {
        $result = Get-Item -Path $PSScriptRoot/$Lang/$Name
    }
    catch {
        Exit
    }
    $result
}
elseif (!$name -and $Lang) {
    Get-ChildItem -Path $PSScriptRoot/$Lang -Recurse -Depth 0
}
else {
    Get-ChildItem -Path $PSScriptRoot -Recurse -Depth 1
}
