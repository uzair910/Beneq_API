# Beneq_API

Beneq API is implemented in .NET Core. 
It is the server side implementation that handles the Client requests, and forward it to the Arm controller.

In order to build the project, you may need to include a few packages.
  For ArmInterfaceControllerTests, 
    You maybe need to install NUnit package.
  For BeneqAPI, the following package is needed:
    SwashBuckle.AspNetCore.
    
  
  The project should compile in Visual studio, after these above packages are included in the correct (sub)projects.
