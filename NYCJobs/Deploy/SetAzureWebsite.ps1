param (
   [string] $AzureWebsiteName,
   [string] $slot,
   [hashtable] $appsettings,
   [string] $subscriptionName,
   [string] $ResourceGroupName
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