# AutomatedTestingC-
Automated Testing framework in c# Specflow Nunit with templates


this is a rough boilerplate what you need to start automated testing. 

I prefere Gherkin syntax as its easier to connect Requirements to the TestCases 
This lead me to Specflow/Gherkin/Nunit/Selenium combination to automate testing 
Xunit works perfectly fine to use Xunit exchange Nunit for Xunit below


start by creating a new project for your tests

then open nuget browser and install

Nunit
Specflow.Nunit
Specflow
Nunit.Runners
Nunit.ConsoleRunner (helps when you automate the CI process to be able to run everything from a console command)
Nunit3TestAdapter (if  you run inside VS this makes it easy)
Selenium.Webdriver
Selenium.Chrome.Webdriver (headfull)
Selenium.phantomJs.Webdriver (headless)


there is ofcourse alot more webdrivers you can install i often begin with Chrome and PhantomJs and then expand depending on needs. 
for future comments i use a startup option that dictates the webdriver that should be used. 

there could be needs for NewtonSoftsJSon also but it depends on what your testing. 

then download the VS integration for Specflow from
https://github.com/techtalk/SpecFlow.VisualStudio/releases

this adds predefined features and steps files to be selected to the project.

after this is done now we need to specify how we test the project.

my default layout is normaly

TestProject
  src
    helpers
      connector (handles the webdriver connection)
      jsonParser (parses your jsons here)
      errorHandler (handles all errros)
      ...
    steps
      mainSteps (default mother file hold universal features for all steps) 
      stepFeatureDescription extends mainSteps
      stepFeatureDescription2 extends mainSteps
      ...
    features
      featureFeatureDescription
      ...
     
      


i try to write my feature files so i reflects the basic Requirement we are going to test.

example 

Req R001 Login: A user needs to be able to login....

featureLogin

TC-001-01 failure to login 
TC-001-02 successfull login
TC-001-03 successfull logout
TC-001-04 failure to login due to connection failure

