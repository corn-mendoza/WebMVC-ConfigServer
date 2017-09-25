# WebMVC-ConfigServer

#### Clone, Build, and Publish Application
This application requires Visual Studio 2017 with .NET 4.61. Build and publish the application and push the output of the publish directory to Cloud Foundry.

#### Instantiate Spring Cloud Services instances 
Spring Cloud Services wrap up key Spring Cloud projects with managed capabilities. Here we create a pair of these managed services. 
 
  1. In Pivotal Cloud Foundry Apps Manager, click on your “space” on the left, and switch to the “Services” tab. Note that all of these activities can also be done via the CF CLI. 
  2. Click “Add Service.” 
  3. Type “Spring” into the search box to narrow down the choices. 
  4. Select “Config Server” and select the default plan. 
  5. Choose the default plan, provide an instance name, and click “Add.” Wait a couple minutes before expecting to see this service fully operational. 

#### Point Config Server to Git repository 
  1. From the Terminal within Visual Studio Code, enter in the following command. This tells the Config Server where to get its configurations from: 
  
    > cf update-service <configservername> -c "{\"git\": { \"uri\":\"https://github.com/corn-pivotal/configserver-repo\"}}" 
  
      - Quotes must be escaped when using the Windows Command shell or Powershell

  2. From Apps Manager, navigate to the “Services” view, manage the Config Server instance, and notice the git URL in the configuration.

