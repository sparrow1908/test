
$majorPsVer = $PSVersionTable.PSVersion.Major
$folderCodeGenPath = $PSScriptRoot

Write-Host "[ServerLogic XSLT GEN] starting with major powershell version: $majorPsVer, CodeGen folder: $folderCodeGenPath"

if ($majorPsVer -lt 5)
{
    Write-Error "[ServerLogic XSLT GEN] Powershell installed engine version must be 5 or greater!" -ErrorAction Stop
}

$xsltprocToolPath = Join-Path $folderCodeGenPath "\Xslt-proc\xsltproc.exe"
Write-Host "[ServerLogic XSLT GEN] xsltproc tool path: $xsltprocToolPath"

$filesToGenerate = @{
    DataTypes = @{Xslt = "DataTypes"}
    CardData = @{Xslt = "CardData"}
    Notifications = @{Xslt = "Notifications"}
    BasicRequests = @{Xslt = "Requests"}
    BasicResponses = @{Xslt = "Responses"}
    Card112Requests = @{Xslt = "Requests"}
    Card112Responses = @{Xslt = "Responses"}
    ForcesRequests = @{Xslt = "Requests"}
    ForcesResponses = @{Xslt = "Responses"}
    MiscRequests = @{Xslt = "Requests"}
    MiscResponses = @{Xslt = "Responses"}
    CardVideoQARequests = @{Xslt = "Requests"}
    CardVideoQAResponses = @{Xslt = "Responses"}
    CardCustomServiceRequests = @{Xslt = "Requests"}
    CardCustomServiceResponses = @{Xslt = "Responses"}
    CardsRequests = @{Xslt = "Requests"}
    CardsResponses = @{Xslt = "Responses"}
}

foreach ($key in $filesToGenerate.keys)
{
    $generatedFile = "$folderCodeGenPath\Contract\Generated_$key.cs"
    $contractFile = "$folderCodeGenPath\Contract\$key.xml"
    $xsltFileTemplate = $filesToGenerate[$key].Xslt
    $xsltFile = "$folderCodeGenPath\Transformers\XmlToCS_$xsltFileTemplate.xslt"

    #Write-Host "[ServerLogic XSLT GEN] prepared data for file $key`:"
    #Write-Host "[ServerLogic XSLT GEN] generatedFile : $generatedFile"
    #Write-Host "[ServerLogic XSLT GEN] contractFile : $contractFile"
    #Write-Host "[ServerLogic XSLT GEN] xsltFile : $xsltFile"

    $generationArgs = "-o `"$generatedFile`" --nonet --stringparam filename `"$contractFile`" --stringparam transformername `"$xsltFile`" `"$xsltFile`" `"$contractFile`""
    #Write-Host "[ServerLogic XSLT GEN] generationArgs: $generationArgs"

    Start-Process $xsltprocToolPath -ArgumentList $generationArgs -NoNewWindow
}
