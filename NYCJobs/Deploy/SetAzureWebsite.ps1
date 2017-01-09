param (
   [string] $AzureWebsiteName = "FridersLab",
   [string] $slot = "Staging",
   [hashtable] $appsettings =  @{"FacebookAppId" = "1"; "FacebookAppSecret" = "2"},
   [string] $subscriptionName = "",
   [string] $ResourceGroupName = "FridersLabRG"
)

#Login-AzureRmAccount

Get-AzureRmSubscription

#Get-AzureRmSubscription –SubscriptionName $subscriptionName | Select-AzureRmSubscription

#Set-AzureRmWebApp -Name $AzureWebsiteName -Slot $slot -AppSettings $appsettings

if(!$slot)
{
    Set-AzureRmWebApp -Name $AzureWebsiteName -ResourceGroupName $ResourceGroupName -AppSettings $appsettings
}
else
{
    Set-AzureRmWebAppSlot -Name $AzureWebsiteName -ResourceGroupName $ResourceGroupName -Slot $slot -AppSettings $appsettings
}