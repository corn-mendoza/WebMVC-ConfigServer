# WebMVC-ConfigServer
#### Point Config Server to Git repository 
1. From the Terminal within Visual Studio Code, enter in the following command. This tells the Config Server where to get its configurations from: cf updateservice <your config server name> -c '{"git": { "uri":"https://github.com/corn-pivotal/cloud-native-netconfigs"}}' 2. From Apps Manager, navigate to the “Services” view, manage the Config Server instance, and notice the git URL in the configuration.
