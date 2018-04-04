# Welcome to the AzureForge lab!

You can chose either to use your own machine and tools to develop your app or claim an existing Lab VM if you don't have such tools.

## Prerequisites
- Ensure that the Azure Portal default language is set to english
- Open your web browser in <u>private</u> mode or disconnect existing Active Directory connections

## Table of contents

- [Welcome to the AzureForge lab!](#welcome-to-the-azureforge-lab)
    - [Prerequisites](#prerequisites)
    - [Table of contents](#table-of-contents)
    - [Credentials](#credentials)
    - [Available Services](#available-services)
    - [Connect to SonarQube](#connect-to-sonarqube)
    - [Connect to LifeCycle](#connect-to-lifecycle)
    - [Connect to a lab machine](#connect-to-a-lab-machine)

## Credentials

X: Your team number, between 1..15
Y: Your user number, between 1..12

Account: SESummitX_YY@azure-paastr.com
Password: A password will be provided to you the day of the lab.

These credentials will give you access to each AzureForge services.

## Available Services

This is the list of the AzureForge services available on the lab environment

| Service        | Url           | Authentication  |
| ------------- |:-------------:| -----:|
| [VSTS](https://acctr.visualstudio.com)  | https://acctr.visualstudio.com | AzureAD Credentials: SESummitX_YY@azure-paastr.com  |
| [Azure Portal](https://portal.azure.com)  | https://portal.azure.com | AzureAD Credentials: SESummitX_YY@azure-paastr.com  |
| [Sonarqube](https://tr-ats-sonar.azure-paastr.com)  | https://tr-ats-sonar.azure-paastr.com | AzureAD Credentials: SESummitX_YY@azure-paastr.com  |
| [Lifecyle](https://tr-ats-lifecycle.azure-paastr.com)  | https://tr-ats-lifecycle.azure-paastr.com | AzureAD Credentials Short Name (without domain name): SESummitX_YY  |

---

## Connect to SonarQube
To consult SonarQube reports, please follow these steps:  
1. Browse this url : [Sonarqube](https://tr-ats-sonar.azure-paastr.com)
2. Click on Login with Azure AD : <br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/36-screenshot.jpg)</span><br/>
3. Accept the prompt from Azure AD : <br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/35-screenshot.jpg)</span><br/>
4. Browse to your project's reports : <br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/28-screenshot.jpg)</span><br/>


## Connect to LifeCycle
To consult LifeCycle reports, please follow these steps:
1. Browse this url : [Lifecyle](https://tr-ats-lifecycle.azure-paastr.com) 
2. Login using your username SESummitX_YY ( without @azure-paastr.com ) <br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/9-screenshot.jpg)</span><br/>
3. Browse to your project's reports : <br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/10-screenshot.jpg)</span><br/>


## Connect to a lab machine
If you don't have the required tools to run the lab on your machine, you can claim an existing lab VM from the DevtestLab.

Please follow these steps:
1. Connect on the Azure Portal with you lab credentials (SESummitX_YY@azure-paastr.com)<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/31-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/32-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/33-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/34-screenshot.jpg)</span><br/>
2. On the Azureportal, open the ACCTraining Devtestlab resource<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/37-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/38-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/screenshot.jpg)</span><br/>
3. Once the lab open, you can see your claimed VMs and the available VMs. If you have not claimed a machine yet, please click the "Claim any" button<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/1-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/2-screenshot.jpg)</span><br/>

4. {The operation may take a few minutes, it is going to select a free machine in the lab and assign it to your account. Then, the VM will be started automatically}<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/3-screenshot.jpg)</span><br/>
Once the machine is created, click on it and note its name (ie. SESummit002 )<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/18-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/26-screenshot.jpg)</span><br/>

5. Open a web browser: Chrome, IE or Firefox on your machine<br/><br/>
6. Browse this url: https://rds.azure-paastr.com
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/19-screenshot.jpg)</span><br/>
7. Connect with your lab credentials<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/20-screenshot.jpg)</span><br/>
8. Click on "Remote Destop Connection"<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/21-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/12-screenshot.jpg)</span><br/>
9. Once the "Remote Desktop Connection" app is available, enter the name of the machine you claimed in the lab. ex: SESummitXX where XX is the unique ID of the machine<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/22-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/23-screenshot.jpg)</span><br/>
10. You are now connected to the dev machine<br/><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/24-screenshot.jpg)</span><br/>
<span style="display:block;text-align:center">![alt](https://sesummit.blob.core.windows.net/images/27-screenshot.jpg)</span><br/>