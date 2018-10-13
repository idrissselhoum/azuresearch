configuration AdminRestAp {


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
 
        
}

}


AdminRestAp -OutputPath "C:\vstsagent"
Start-DscConfiguration -Path "C:\vstsagent"

