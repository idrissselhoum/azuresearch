configuration AdminRestAp {


Import-DscResource -ModuleName 'xWebAdministration'

    Node "localhost" {
        <#
            Install windows features
        #>
        WindowsFeature InstallIIS {
            Name = "Web-Server"
            Ensure = "Present"
        }

        WindowsFeature IISManagementTools
    {
        Ensure = "Present"
        Name = "Web-Mgmt-Tools"
        DependsOn='[WindowsFeature]InstallIIS'
    }

    WindowsFeature ASPNET45
    {
            Name = "Web-Asp-Net45"
            Ensure = "Present"
    }


    xWebsite 'AzureSearchWebSite' {
            Ensure = "Present"
            Name = 'AzureSearch'
            BindingInfo = @( MSFT_xWebBindingInformation

                {
                    Protocol = 'HTTP'
                    Port = 80
                }
            )

            PhysicalPath = 'C:\inetpub\wwwroot'
            ApplicationPool = 'AzureSearchAppPool'
            DependsOn = '[xWebAppPool]AzureSearchAppPool'

        }

       xWebAppPool 'AzureSearchAppPool' {
            Name = 'AzureSearchAppPool'
            Ensure = "Present"
        }

 
 
}

}


AdminRestAp -OutputPath "C:\DSC"
Start-DscConfiguration -Path "C:\DSC" -Force -Verbose -Wait
